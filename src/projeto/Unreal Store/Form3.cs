using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Unreal_Store
{
    public partial class Form3 : Form
    {
        private string currentUsername;
        private decimal sessionBalance = 0m;
        private Control[] storeControls;
        private Panel currentDynamicPanel = null;

        private System.Collections.Generic.List<string> sessionOwnedGames = new System.Collections.Generic.List<string>();

        private readonly string[] gameIds = new string[]
            { AccountStore.GAME_ACAO, AccountStore.GAME_EXPLORACAO, AccountStore.GAME_POINTCLICK, AccountStore.GAME_MULTI };
        private readonly string[] gameTitles = new string[]
            { "Jogo de Ação", "Jogo de Exploração", "Point-and-Click 2D", "Multi-jogador" };
        private readonly decimal[] gamePrices = new decimal[]
            { 19.99m, 9.99m, 3.99m, 0m };
        private readonly Button[] gameButtons = new Button[4];
        private readonly Label[] gamePriceLabels = new Label[4];
        private readonly Label[] gameTitleLabels = new Label[4];

        public Form3()
        {
            InitializeComponent();

           
            this.Resize += Form3_Resize;

          
            gameButtons[0] = button1;
            gameButtons[1] = button2;
            gameButtons[2] = button3;
            gameButtons[3] = button4;

           
            gamePriceLabels[0] = label6;
            gamePriceLabels[1] = label7;
            gamePriceLabels[2] = label8;
            gamePriceLabels[3] = label9;

           
            gameTitleLabels[0] = label2;
            gameTitleLabels[1] = label3;
            gameTitleLabels[2] = label4;
            gameTitleLabels[3] = label5;

           
            panelNavStore.Click += (s, e) => ShowStore();
            lblStoreIcon.Click += (s, e) => ShowStore();
            lblStoreText.Click += (s, e) => ShowStore();

            panelNavLibrary.Click += (s, e) => ShowLibrary();
            lblLibraryIcon.Click += (s, e) => ShowLibrary();
            lblLibraryText.Click += (s, e) => ShowLibrary();

            panelNavEngine.Click += (s, e) => ShowUpdate();
            lblEngineIcon.Click += (s, e) => ShowUpdate();
            lblEngineText.Click += (s, e) => ShowUpdate();

            panelNavSettings.Click += (s, e) => ShowSettings();
            lblSettingsIcon.Click += (s, e) => ShowSettings();
            lblSettingsText.Click += (s, e) => ShowSettings();

      
            storeControls = new Control[]
            {
                button1, button2, button3, button4,
                label2, label3, label4, label5,
                label6, label7, label8, label9
            };

           
            for (int i = 0; i < gameButtons.Length; i++)
            {
                gameButtons[i].Click -= GameButton_Click;
                gameButtons[i].Click += GameButton_Click;
            }

            ShowStore();
            UpdateBalanceDisplay();
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            
            if (currentDynamicPanel != null && mainContentPanel.Controls.Contains(currentDynamicPanel))
            {
                currentDynamicPanel.Size = new Size(mainContentPanel.Width - 40, mainContentPanel.Height - 80);
            }

            
            if (mainContentLabel.Text == "Loja")
            {
                AdjustStoreButtons();
            }
        }

        private void AdjustStoreButtons()
        {
            int panelWidth = mainContentPanel.Width - 40;
            int buttonWidth = Math.Max(120, (panelWidth - 60) / 4);
            int spacing = (panelWidth - (buttonWidth * 4)) / 5;

            for (int i = 0; i < gameButtons.Length; i++)
            {
                int x = spacing + (i * (buttonWidth + spacing));
                gameButtons[i].Width = buttonWidth;
                gameButtons[i].Location = new Point(x, gameButtons[i].Location.Y);

               
                gameTitleLabels[i].Location = new Point(x, gameTitleLabels[i].Location.Y);
                gameTitleLabels[i].Width = buttonWidth;
                gameTitleLabels[i].TextAlign = ContentAlignment.MiddleCenter;

                
                gamePriceLabels[i].Location = new Point(x, gamePriceLabels[i].Location.Y);
                gamePriceLabels[i].Width = buttonWidth;
                gamePriceLabels[i].TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        public string Username
        {
            set
            {
                bool hadSessionGames = sessionOwnedGames.Count > 0;
                int sessionGamesCount = sessionOwnedGames.Count;
                bool hadSessionBalance = sessionBalance > 0;
                decimal sessionBalanceAmount = sessionBalance;

                currentUsername = value;

                if (hadSessionGames)
                {
                    foreach (string gameId in sessionOwnedGames)
                    {
                        if (!AccountStore.HasGame(currentUsername, gameId))
                        {
                            AccountStore.AddOwnedGame(currentUsername, gameId);
                        }
                    }

                    MessageBox.Show($"{sessionGamesCount} jogo(s) comprado(s) durante a sessão foram adicionados à sua conta!", "Jogos transferidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sessionOwnedGames.Clear();
                }

                if (hadSessionBalance)
                {
                    AccountStore.AddFunds(currentUsername, sessionBalanceAmount);
                    MessageBox.Show($"O saldo de {sessionBalanceAmount.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))} da sessão foi transferido para a sua conta!", "Saldo transferido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sessionBalance = 0m;
                }

                UpdateBalanceDisplay();
                UpdateStoreButtonsState();

                if (mainContentLabel.Text == "Biblioteca")
                {
                    ShowLibrary();
                }
            }
            get { return currentUsername; }
        }

        private void UpdateBalanceDisplay()
        {
            decimal displayAmount;
            if (string.IsNullOrWhiteSpace(currentUsername))
            {
                displayAmount = sessionBalance;
            }
            else
            {
                displayAmount = AccountStore.GetBalance(currentUsername);
            }

            lblBalance.Text = displayAmount.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"));
        }

        public void UpdateStoreButtonsState()
        {
            for (int i = 0; i < gameIds.Length; i++)
            {
                bool owned = false;

                if (!string.IsNullOrWhiteSpace(currentUsername))
                {
                    owned = AccountStore.HasGame(currentUsername, gameIds[i]);
                }
                else
                {
                    owned = sessionOwnedGames.Contains(gameIds[i]);
                }

                if (owned)
                {
                    gameButtons[i].Enabled = false;
                    gameButtons[i].BackColor = Color.FromArgb(80, 80, 80);
                    gamePriceLabels[i].Text = "COMPRADO";
                    gamePriceLabels[i].ForeColor = Color.Gold;
                }
                else
                {
                    gameButtons[i].Enabled = true;
                    gameButtons[i].BackColor = SystemColors.Control;
                    gamePriceLabels[i].Text = gamePrices[i] > 0 ?
                        gamePrices[i].ToString("C2", CultureInfo.GetCultureInfo("pt-PT")) : "Gratuito";
                    gamePriceLabels[i].ForeColor = Color.WhiteSmoke;
                }
            }
        }

        private void ClearDynamicPanels()
        {
            if (currentDynamicPanel != null && mainContentPanel.Controls.Contains(currentDynamicPanel))
            {
                mainContentPanel.Controls.Remove(currentDynamicPanel);
                currentDynamicPanel.Dispose();
                currentDynamicPanel = null;
            }

            var toRemove = mainContentPanel.Controls.Cast<Control>()
                .Where(c => c != mainContentLabel && !storeControls.Contains(c) && c.Parent == mainContentPanel)
                .ToList();

            foreach (var c in toRemove)
            {
                if (!storeControls.Contains(c))
                {
                    mainContentPanel.Controls.Remove(c);
                    c.Dispose();
                }
            }
        }

        private void ShowStore()
        {
            ClearDynamicPanels();

            foreach (var c in storeControls)
            {
                c.Visible = true;
            }

            panelNavStore.BackColor = Color.FromArgb(48, 48, 48);
            panelNavLibrary.BackColor = Color.FromArgb(22, 22, 22);
            panelNavEngine.BackColor = Color.FromArgb(22, 22, 22);
            panelNavSettings.BackColor = Color.FromArgb(22, 22, 22);

            lblStoreText.ForeColor = Color.White;
            lblStoreIcon.ForeColor = Color.White;
            lblLibraryText.ForeColor = Color.LightGray;
            lblLibraryIcon.ForeColor = Color.LightGray;
            lblEngineText.ForeColor = Color.LightGray;
            lblEngineIcon.ForeColor = Color.LightGray;
            lblSettingsText.ForeColor = Color.LightGray;
            lblSettingsIcon.ForeColor = Color.LightGray;

            mainContentLabel.Text = "Loja";
            UpdateStoreButtonsState();
            AdjustStoreButtons();
        }

        private void ShowLibrary()
        {
            ClearDynamicPanels();

            foreach (var c in storeControls)
            {
                c.Visible = false;
            }

            panelNavStore.BackColor = Color.FromArgb(22, 22, 22);
            panelNavLibrary.BackColor = Color.FromArgb(48, 48, 48);
            panelNavEngine.BackColor = Color.FromArgb(22, 22, 22);
            panelNavSettings.BackColor = Color.FromArgb(22, 22, 22);

            lblStoreText.ForeColor = Color.LightGray;
            lblStoreIcon.ForeColor = Color.LightGray;
            lblLibraryText.ForeColor = Color.White;
            lblLibraryIcon.ForeColor = Color.White;
            lblEngineText.ForeColor = Color.LightGray;
            lblEngineIcon.ForeColor = Color.LightGray;
            lblSettingsText.ForeColor = Color.LightGray;
            lblSettingsIcon.ForeColor = Color.LightGray;

            mainContentLabel.Text = "Biblioteca";

            Panel libraryPanel = new Panel()
            {
                Location = new Point(20, 60),
                Size = new Size(mainContentPanel.Width - 40, mainContentPanel.Height - 80),
                AutoScroll = true,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            System.Collections.Generic.List<string> ownedGames;

            if (!string.IsNullOrWhiteSpace(currentUsername))
            {
                ownedGames = AccountStore.GetOwnedGames(currentUsername).ToList();
            }
            else
            {
                ownedGames = sessionOwnedGames;
            }

            int yOffset = 0;

            if (ownedGames.Count == 0)
            {
                Label emptyLabel = new Label()
                {
                    Text = "Não tens jogos na tua biblioteca. Visita a Loja para comprar jogos!",
                    ForeColor = Color.LightGray,
                    AutoSize = true,
                    Location = new Point(0, 0)
                };
                libraryPanel.Controls.Add(emptyLabel);
            }
            else
            {
                foreach (string gameId in ownedGames)
                {
                    int gameIndex = -1;
                    for (int i = 0; i < gameIds.Length; i++)
                    {
                        if (gameIds[i] == gameId)
                        {
                            gameIndex = i;
                            break;
                        }
                    }

                    if (gameIndex == -1) continue;

                    Panel gamePanel = new Panel()
                    {
                        Size = new Size(libraryPanel.Width - 20, 80),
                        Location = new Point(0, yOffset),
                        BackColor = Color.FromArgb(45, 45, 45),
                        Margin = new Padding(0, 0, 0, 10),
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                    };

                    string iconText = "🎮";
                    switch (gameIds[gameIndex])
                    {
                        case AccountStore.GAME_ACAO: iconText = "🎮"; break;
                        case AccountStore.GAME_EXPLORACAO: iconText = "🗺️"; break;
                        case AccountStore.GAME_POINTCLICK: iconText = "🖱️"; break;
                        case AccountStore.GAME_MULTI: iconText = "👥"; break;
                    }

                    Label gameIcon = new Label()
                    {
                        Text = iconText,
                        Font = new Font("Segoe UI Emoji", 24F),
                        ForeColor = Color.White,
                        Location = new Point(10, 20),
                        AutoSize = true
                    };

                    Label gameTitle = new Label()
                    {
                        Text = gameTitles[gameIndex],
                        Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                        ForeColor = Color.White,
                        Location = new Point(70, 15),
                        AutoSize = true
                    };

                    Label gameStatus = new Label()
                    {
                        Text = "✔️ Já na sua biblioteca",
                        Font = new Font("Segoe UI", 9F),
                        ForeColor = Color.LightGreen,
                        Location = new Point(70, 45),
                        AutoSize = true
                    };

                    Button playButton = new Button()
                    {
                        Text = "JOGAR",
                        Location = new Point(gamePanel.Width - 100, 25),
                        Size = new Size(80, 30),
                        BackColor = Color.FromArgb(70, 130, 180),
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.White,
                        Tag = gameTitles[gameIndex],
                        Anchor = AnchorStyles.Top | AnchorStyles.Right
                    };
                    playButton.Click += PlayButton_Click;

                    gamePanel.Controls.Add(gameIcon);
                    gamePanel.Controls.Add(gameTitle);
                    gamePanel.Controls.Add(gameStatus);
                    gamePanel.Controls.Add(playButton);
                    libraryPanel.Controls.Add(gamePanel);

                    yOffset += 90;
                }
            }

            mainContentPanel.Controls.Add(libraryPanel);
            currentDynamicPanel = libraryPanel;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string gameTitle = button?.Tag?.ToString() ?? "jogo";
            MessageBox.Show($"A iniciar {gameTitle}...", "A iniciar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowUpdate()
        {
            ClearDynamicPanels();

            foreach (var c in storeControls)
            {
                c.Visible = false;
            }

            panelNavStore.BackColor = Color.FromArgb(22, 22, 22);
            panelNavLibrary.BackColor = Color.FromArgb(22, 22, 22);
            panelNavEngine.BackColor = Color.FromArgb(48, 48, 48);
            panelNavSettings.BackColor = Color.FromArgb(22, 22, 22);

            lblStoreText.ForeColor = Color.LightGray;
            lblStoreIcon.ForeColor = Color.LightGray;
            lblLibraryText.ForeColor = Color.LightGray;
            lblLibraryIcon.ForeColor = Color.LightGray;
            lblEngineText.ForeColor = Color.White;
            lblEngineIcon.ForeColor = Color.White;
            lblSettingsText.ForeColor = Color.LightGray;
            lblSettingsIcon.ForeColor = Color.LightGray;

            mainContentLabel.Text = "Atualizar - Adicionar Fundos / Reembolsos";

            Panel updatePanel = new Panel()
            {
                Location = new Point(20, 60),
                Size = new Size(mainContentPanel.Width - 40, mainContentPanel.Height - 80),
                AutoScroll = true,
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom
            };

            int yOffset = 0;

           
            Label lblAddFundsTitle = new Label()
            {
                Text = "--- ADICIONAR FUNDOS ---",
                ForeColor = Color.LightGreen,
                Location = new Point(0, yOffset),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            yOffset += 30;

            Label lblInfo = new Label()
            {
                Text = "Valor a adicionar (€):",
                ForeColor = Color.LightGray,
                Location = new Point(0, yOffset),
                AutoSize = true
            };
            yOffset += 28;

            TextBox tbAmount = new TextBox()
            {
                Location = new Point(0, yOffset),
                Size = new Size(120, 24),
                Text = "0,00"
            };
            yOffset += 30;

            Button btnAdd = new Button()
            {
                Text = "Adicionar",
                Location = new Point(0, yOffset),
                Size = new Size(100, 30),
                BackColor = Color.FromArgb(70, 130, 180),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White
            };
            yOffset += 50;

            btnAdd.Click += (s, e) =>
            {
                decimal amount;
                if (!decimal.TryParse(tbAmount.Text.Trim(), NumberStyles.Number, CultureInfo.GetCultureInfo("pt-PT"), out amount))
                {
                    if (!decimal.TryParse(tbAmount.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out amount))
                    {
                        MessageBox.Show("Valor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (amount <= 0)
                {
                    MessageBox.Show("Insira um valor maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(currentUsername))
                {
                    sessionBalance += amount;
                }
                else
                {
                    AccountStore.AddFunds(currentUsername, amount);
                }

                UpdateBalanceDisplay();
                MessageBox.Show($"Foram adicionados {amount.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))} à carteira.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            updatePanel.Controls.Add(lblAddFundsTitle);
            updatePanel.Controls.Add(lblInfo);
            updatePanel.Controls.Add(tbAmount);
            updatePanel.Controls.Add(btnAdd);

            Label lblRefundTitle = new Label()
            {
                Text = "--- REEMBOLSOS ---",
                ForeColor = Color.LightCoral,
                Location = new Point(0, yOffset),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            };
            yOffset += 30;

            Label lblRefundInfo = new Label()
            {
                Text = "Selecione um jogo para reembolsar (apenas jogos pagos):",
                ForeColor = Color.LightGray,
                Location = new Point(0, yOffset),
                AutoSize = true
            };
            yOffset += 30;

            updatePanel.Controls.Add(lblRefundTitle);
            updatePanel.Controls.Add(lblRefundInfo);

            System.Collections.Generic.List<string> ownedGames;
            if (!string.IsNullOrWhiteSpace(currentUsername))
            {
                ownedGames = AccountStore.GetOwnedGames(currentUsername).ToList();
            }
            else
            {
                ownedGames = sessionOwnedGames;
            }

            var refundableGames = new System.Collections.Generic.List<(string id, string title, decimal price)>();
            foreach (string gameId in ownedGames)
            {
                decimal price = AccountStore.GetGamePrice(gameId);
                if (price > 0)
                {
                    string title = AccountStore.GetGameTitle(gameId);
                    refundableGames.Add((gameId, title, price));
                }
            }

            if (refundableGames.Count == 0)
            {
                Label lblNoRefunds = new Label()
                {
                    Text = "Não tens jogos elegíveis para reembolso. (Apenas jogos pagos podem ser reembolsados)",
                    ForeColor = Color.Gray,
                    Location = new Point(0, yOffset),
                    AutoSize = true
                };
                updatePanel.Controls.Add(lblNoRefunds);
            }
            else
            {
                foreach (var game in refundableGames)
                {
                    Panel refundPanel = new Panel()
                    {
                        Size = new Size(updatePanel.Width - 40, 50),
                        Location = new Point(0, yOffset),
                        BackColor = Color.FromArgb(45, 45, 45),
                        Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                    };

                    Label gameNameLabel = new Label()
                    {
                        Text = $"{game.title} - {game.price.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))}",
                        ForeColor = Color.White,
                        Location = new Point(10, 15),
                        AutoSize = true,
                        Font = new Font("Segoe UI", 10F)
                    };

                    Button refundButton = new Button()
                    {
                        Text = "REEMBOLSAR",
                        Location = new Point(refundPanel.Width - 120, 10),
                        Size = new Size(100, 30),
                        BackColor = Color.FromArgb(220, 80, 80),
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.White,
                        Tag = game.id,
                        Anchor = AnchorStyles.Top | AnchorStyles.Right
                    };
                    refundButton.Click += RefundButton_Click;

                    refundPanel.Controls.Add(gameNameLabel);
                    refundPanel.Controls.Add(refundButton);
                    updatePanel.Controls.Add(refundPanel);

                    yOffset += 60;
                }
            }

            mainContentPanel.Controls.Add(updatePanel);
            currentDynamicPanel = updatePanel;
        }

        private void RefundButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string gameId = btn?.Tag?.ToString();

            if (string.IsNullOrEmpty(gameId)) return;

            string gameTitle = AccountStore.GetGameTitle(gameId);
            decimal gamePrice = AccountStore.GetGamePrice(gameId);

            DialogResult confirm = MessageBox.Show(
                $"Tem a certeza que deseja reembolsar '{gameTitle}'?\n\nValor a ser devolvido: {gamePrice.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))}\n\nNota: O jogo será removido da sua biblioteca e ficará disponível para compra novamente.",
                "Confirmar Reembolso",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            bool success = false;

            if (!string.IsNullOrWhiteSpace(currentUsername))
            {
                success = AccountStore.TryRefund(currentUsername, gameId);
            }
            else
            {
                if (sessionOwnedGames.Contains(gameId))
                {
                    decimal price = AccountStore.GetGamePrice(gameId);
                    if (price > 0)
                    {
                        sessionOwnedGames.Remove(gameId);
                        sessionBalance += price;
                        success = true;
                    }
                }
            }

            if (success)
            {
                UpdateBalanceDisplay();
                UpdateStoreButtonsState();

                if (mainContentLabel.Text == "Loja")
                {
                    UpdateStoreButtonsState();
                }
                else if (mainContentLabel.Text == "Biblioteca")
                {
                    ShowLibrary();
                }
                else if (mainContentLabel.Text == "Atualizar - Adicionar Fundos / Reembolsos")
                {
                    ShowUpdate();
                }

                MessageBox.Show(
                    $"Reembolso de '{gameTitle}' efectuado com sucesso!\n\nValor devolvido: {gamePrice.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))}\n\nO jogo já está disponível novamente na loja.",
                    "Reembolso efectuado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Não foi possível efectuar o reembolso. Certifique-se que o jogo está na sua biblioteca e que é um jogo pago.",
                    "Erro no reembolso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            int gameIndex = -1;
            for (int i = 0; i < gameButtons.Length; i++)
            {
                if (gameButtons[i] == sender)
                {
                    gameIndex = i;
                    break;
                }
            }

            if (gameIndex == -1) return;

            
            if (!string.IsNullOrWhiteSpace(currentUsername))
            {
                if (AccountStore.HasGame(currentUsername, gameIds[gameIndex]))
                {
                    MessageBox.Show($"Já possui '{gameTitles[gameIndex]}' na sua biblioteca!", "Jogo já comprado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (sessionOwnedGames.Contains(gameIds[gameIndex]))
                {
                    MessageBox.Show($"Já comprou '{gameTitles[gameIndex]}' nesta sessão!", "Jogo já comprado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            string priceText = gamePrices[gameIndex] > 0 ? gamePrices[gameIndex].ToString("C2", CultureInfo.GetCultureInfo("pt-PT")) : "Gratuito";
            string msg = gamePrices[gameIndex] > 0 ? $"Comprar '{gameTitles[gameIndex]}' por {priceText}?" : $"'{gameTitles[gameIndex]}' é gratuito. Deseja adicionar à sua biblioteca?";
            DialogResult res = MessageBox.Show(msg, "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res != DialogResult.Yes) return;

        
            if (gamePrices[gameIndex] <= 0m)
            {
                if (!string.IsNullOrWhiteSpace(currentUsername))
                {
                    AccountStore.AddOwnedGame(currentUsername, gameIds[gameIndex]);
                    MessageBox.Show($"{gameTitles[gameIndex]} adicionado à sua biblioteca!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateStoreButtonsState();
                }
                else
                {
                    sessionOwnedGames.Add(gameIds[gameIndex]);
                    MessageBox.Show($"{gameTitles[gameIndex]} adicionado à sua biblioteca de sessão! Crie uma conta para guardar os seus jogos permanentemente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateStoreButtonsState();
                }
                return;
            }

        
            if (!string.IsNullOrWhiteSpace(currentUsername))
            {
                bool success = AccountStore.TrySpend(currentUsername, gamePrices[gameIndex]);
                if (success)
                {
                    AccountStore.AddOwnedGame(currentUsername, gameIds[gameIndex]);
                    UpdateBalanceDisplay();
                    UpdateStoreButtonsState();
                    MessageBox.Show($"Compra de '{gameTitles[gameIndex]}' efectuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult ask = MessageBox.Show("Saldo insuficiente. Deseja adicionar fundos agora?", "Saldo insuficiente", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (ask == DialogResult.Yes) ShowUpdate();
                    return;
                }
            }

            if (sessionBalance >= gamePrices[gameIndex])
            {
                sessionBalance -= gamePrices[gameIndex];
                sessionOwnedGames.Add(gameIds[gameIndex]);
                UpdateBalanceDisplay();
                UpdateStoreButtonsState();
                MessageBox.Show($"Compra de '{gameTitles[gameIndex]}' efectuada com sucesso (sessão). Crie uma conta para guardar os seus jogos permanentemente.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult ask = MessageBox.Show("Saldo de sessão insuficiente. Deseja adicionar fundos agora ou criar uma conta?", "Saldo insuficiente", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (ask == DialogResult.Yes)
                {
                    ShowUpdate();
                }
                else if (ask == DialogResult.Cancel)
                {
                    DialogResult createAccount = MessageBox.Show("Deseja criar uma conta agora? (Os jogos comprados serão transferidos)", "Criar conta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (createAccount == DialogResult.Yes)
                    {
                        OpenCreateAccountAndLogin();
                    }
                }
            }
        }

        private void OpenCreateAccountAndLogin()
        {
            using (Form2 createForm = new Form2())
            {
                if (createForm.ShowDialog(this) == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(createForm.CreatedUsername))
                    {
                        string newUsername = createForm.CreatedUsername;

                        foreach (string gameId in sessionOwnedGames)
                        {
                            if (!AccountStore.HasGame(newUsername, gameId))
                            {
                                AccountStore.AddOwnedGame(newUsername, gameId);
                            }
                        }

                        if (sessionBalance > 0)
                        {
                            AccountStore.AddFunds(newUsername, sessionBalance);
                        }

                        int gamesTransferred = sessionOwnedGames.Count;
                        decimal balanceTransferred = sessionBalance;

                        sessionOwnedGames.Clear();
                        sessionBalance = 0m;

                        currentUsername = newUsername;

                        UpdateBalanceDisplay();
                        UpdateStoreButtonsState();

                        string message = $"Conta '{newUsername}' criada com sucesso!\n";
                        if (gamesTransferred > 0) message += $"\n{gamesTransferred} jogo(s) transferido(s) da sessão.";
                        if (balanceTransferred > 0) message += $"\n{balanceTransferred.ToString("C2", CultureInfo.GetCultureInfo("pt-PT"))} transferido(s) da sessão.";

                        MessageBox.Show(message, "Conta criada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (mainContentLabel.Text == "Biblioteca")
                        {
                            ShowLibrary();
                        }
                    }
                }
            }
        }

        private void ShowSettings()
        {
            ClearDynamicPanels();

            foreach (var c in storeControls)
            {
                c.Visible = false;
            }

            panelNavStore.BackColor = Color.FromArgb(22, 22, 22);
            panelNavLibrary.BackColor = Color.FromArgb(22, 22, 22);
            panelNavEngine.BackColor = Color.FromArgb(22, 22, 22);
            panelNavSettings.BackColor = Color.FromArgb(48, 48, 48);

            lblStoreText.ForeColor = Color.LightGray;
            lblStoreIcon.ForeColor = Color.LightGray;
            lblLibraryText.ForeColor = Color.LightGray;
            lblLibraryIcon.ForeColor = Color.LightGray;
            lblEngineText.ForeColor = Color.LightGray;
            lblEngineIcon.ForeColor = Color.LightGray;
            lblSettingsText.ForeColor = Color.White;
            lblSettingsIcon.ForeColor = Color.White;

            mainContentLabel.Text = "Definições";

            using (Form4 f4 = new Form4())
            {
                this.Hide();
                f4.ShowDialog(this);
                if (!this.IsDisposed) this.Show();
            }
            UpdateBalanceDisplay();
            UpdateStoreButtonsState();

            ShowStore();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void panelNavLibrary_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}