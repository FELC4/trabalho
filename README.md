Unreal Store - Uma Loja de Jogos em C#
Sobre o Projeto
O Unreal Store é uma aplicação desktop que criei para simular uma loja de jogos digitais, inspirada em plataformas como a Steam. Desenvolvi este projeto como parte de um trabalho académico para demonstrar os meus conhecimentos em C#, Windows Forms e integração com bases de dados SQL Server.

A ideia era criar uma aplicação funcional que permitisse aos utilizadores criar contas, navegar por um catálogo de jogos, fazer compras, gerir a sua biblioteca e até pedir reembolsos. No fundo, queria replicar a experiência de uma loja de jogos real, mas num ambiente mais simples e controlado.

Funcionalidades Principais
Quando comecei a planear este projeto, pensei nas funcionalidades que considerava essenciais para uma loja de jogos:

👤 Gestão de Utilizadores
A aplicação permite criar contas com nome de utilizador e palavra-passe. Fiz questão de incluir validações básicas, como verificar se o nome já existe ou se tem pelo menos 3 caracteres. O login é simples e direto, com feedback claro em caso de erro. Também implementei um modo convidado, onde as pessoas podem explorar a loja sem criar conta - e se decidirem criar uma conta depois, todos os jogos que compraram e o saldo que adicionaram são transferidos automaticamente.

🛍️ Loja
A loja apresenta quatro jogos diferentes, cada um com a sua imagem, título e preço. Implementei a lógica de compra que verifica se o utilizador já tem o jogo, se tem saldo suficiente e processa a transação. Para os jogos gratuitos, a compra é instantânea e sem custos. A interface tenta ser visualmente apelativa, com botões grandes e cores que contrastam bem.

📚 Biblioteca
Quando um utilizador compra um jogo, ele aparece na sua biblioteca pessoal. Criei uma lista visual onde cada jogo é apresentado num painel com ícone, título, estado e um botão "JOGAR" (que por enquanto só mostra uma mensagem, mas já dá para ter uma ideia do fluxo). A biblioteca fica vazia quando o utilizador não tem jogos, com uma mensagem amigável a sugerir que visite a loja.

💰 Gestão Financeira
Uma das partes mais interessantes foi implementar o sistema de carteira digital. Os utilizadores podem adicionar fundos à sua conta e usar esse saldo para comprar jogos. Preocupei-me em garantir a consistência dos dados, usando transações SQL para operações como compras e reembolsos - assim, se algo correr mal, as alterações são revertidas e o saldo não fica inconsistente.

Os reembolsos foram outro desafio. Permiti que os utilizadores peçam reembolso de jogos pagos, com a garantia que o jogo é removido da biblioteca e o dinheiro devolvido à carteira. É um processo que exige confirmação do utilizador para evitar acidentes.

⚙️ Definições
Na área de definições, os utilizadores podem editar o seu perfil (mudar nome ou palavra-passe) ou eliminar completamente a conta. Para eliminar a conta, implementei um sistema de dupla confirmação: primeiro uma caixa de diálogo de aviso, depois uma janela onde o utilizador tem de inserir a palavra-passe para confirmar. Isto evita eliminações acidentais e dá mais segurança.

Tecnologias que Usei
Para este projeto, utilizei:

C# com .NET Framework 4.7.2 - A linguagem principal para toda a lógica da aplicação.

Windows Forms - Para criar a interface gráfica. É uma tecnologia mais antiga, mas para este tipo de aplicação desktop funcionou perfeitamente.

SQL Server LocalDB - Para a base de dados local. É uma versão leve do SQL Server que não precisa de instalação complexa, o que facilita a distribuição da aplicação.

ADO.NET - Para a comunicação entre a aplicação e a base de dados. Usei SqlConnection, SqlCommand e SqlDataReader para executar consultas e transações.

System.Data.SqlClient - O driver que permite a conexão com o SQL Server.

A arquitetura que segui foi relativamente simples mas organizada: uma camada de acesso a dados (DatabaseHelper.cs) que trata de todas as operações SQL, uma camada de negócio (AccountStore.cs) que expõe métodos mais amigáveis para a interface, e depois os formulários (Forms 1 a 4) que lidam com a interação do utilizador.

A Base de Dados
A base de dados tem três tabelas principais:

Utilizadores - Guarda os dados das contas: ID, nome, palavra-passe, saldo e data de criação.

Jogos - Contém o catálogo de jogos: ID, código (tipo "ACAO" ou "EXPLORACAO"), título, preço, descrição e se está ativo.

JogosComprados - Faz a ligação entre utilizadores e jogos, registando as compras com data e valor pago. Esta tabela usa chaves estrangeiras para garantir a integridade referencial e uma restrição UNIQUE para evitar que um utilizador compre o mesmo jogo duas vezes.

Criei um script SQL que verifica se a base de dados já existe antes de a criar, o que torna a configuração inicial mais fácil. O script também insere dados de exemplo (dois utilizadores de teste e quatro jogos) para que a aplicação funcione logo de imediato.

Como Correr o Projeto
Para experimentar a aplicação, o processo é bastante simples:

Primeiro, é preciso ter o Visual Studio 2022 instalado, com a carga de trabalho "Desenvolvimento para desktop .NET". Também é necessário ter o SQL Server Management Studio (SSMS) para configurar a base de dados.

O próximo passo é clonar o repositório para o computador e abrir o projeto no Visual Studio.

Depois, no SSMS, conecto ao servidor (localdb)\MSSQLLocalDB e executo o script Unreal_StoreDB.sql que está na raiz do projeto. Este script cria a base de dados e as tabelas, e insere os jogos e contas de teste.

Se a base de dados estiver noutro local, posso alterar a string de conexão no ficheiro DatabaseHelper.cs.

Por fim, no Visual Studio, compilo e executo a aplicação (F5). O projeto restaura automaticamente os pacotes NuGet necessários.

O projeto inclui duas contas de teste: "admin" com palavra-passe "admin123" e saldo de 100€, e "teste" com "teste123" e 50€. Dá para experimentar todas as funcionalidades com estas contas.

Desafios que Encontrei
Durante o desenvolvimento, deparei-me com alguns desafios interessantes:

Transações SQL - Garantir que operações como compras e reembolsos eram atómicas foi crucial. Usei transações com BEGIN TRANSACTION, COMMIT e ROLLBACK para manter a consistência dos dados.

Modo Convidado - Gerir o estado da sessão sem conta foi um desafio. Tive que guardar os jogos comprados e o saldo em memória, e depois transferir tudo para a conta quando o utilizador se registava.

Interface Responsiva - Fazer com que os elementos da interface se ajustassem quando a janela era redimensionada deu algum trabalho, mas consegui com TableLayoutPanels e eventos de resize.

Segurança das Palavras-passe - Neste protótipo, as palavras-passe estão em texto plano. Sei que não é seguro para produção, mas para um projeto académico serviu o propósito. Numa versão futura, gostava de implementar hashing com BCrypt ou SHA256.

O Que Gostava de Melhorar
Se tivesse mais tempo para trabalhar neste projeto, há várias coisas que gostava de adicionar:

Hash de palavras-passe - Em vez de guardar em texto plano, usaria BCrypt para maior segurança.

Sistema de amigos e partilha - Permitir que os utilizadores adicionem amigos e partilhem jogos.

Avaliações e comentários - Os utilizadores poderiam avaliar os jogos e deixar comentários.

Descontos e promoções - Um sistema de promoções temporárias.

Conquistas - Adicionar conquistas que os jogadores podem desbloquear.

Modo offline - Funcionar sem conexão à base de dados.

Tema escuro/claro - Permitir que os utilizadores escolham o tema.

Notificações - Alertas em tempo real para eventos como reembolsos ou promoções.

Como Contribuir
Se alguém quiser contribuir para o projeto, fico muito agradecido! O processo é simples:

Fazem um fork do repositório.

Criam uma branch para a funcionalidade que querem adicionar.

Desenvolvem e testam a funcionalidade.

Fazem commit e push das alterações.

Abrem um Pull Request.

Licença
Este projeto está disponível sob a licença MIT - isso significa que podem usar, modificar e distribuir o código livremente, desde que mantenham a atribuição ao autor original. É uma licença permissiva que incentiva a colaboração e o desenvolvimento comunitário.

Reflexão Final
Este projeto foi uma excelente oportunidade para consolidar os meus conhecimentos em C# e desenvolvimento de aplicações desktop. Aprendi muito sobre gestão de estado, integração com bases de dados e design de interfaces. Também me fez perceber a importância de pensar na experiência do utilizador - desde a forma como os erros são apresentados até ao fluxo de navegação na aplicação.

Se estiveres a ler isto e estiveres a aprender programação, recomendo-te a criares um projeto semelhante. É uma ótima forma de praticares conceitos como orientação a objetos, acesso a dados e design de interfaces. E se tiveres dúvidas ou sugestões sobre o projeto, não hesites em abrir uma issue no GitHub!

Espero que gostes do projeto e que te seja útil de alguma forma. Qualquer questão, estou disponível para ajudar. Boas programações! 🚀
