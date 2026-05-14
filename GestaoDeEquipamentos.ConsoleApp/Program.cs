using System.Reflection.Metadata;
using GestaoDeEquipamentos.ConsoleApp.Dominio;

int contadorIdsEquipamentos = 1;
//array = coleção de objetos - declarado antes do escopo do while para as informações continuarem salvas durante o uso
Equipamento[] equipamentosSalvos = new Equipamento[100];

int contadorIdsChamados = 1;
Chamado[] chamadosSalvos = new Chamado[100];

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de Equipamentos");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1 - Controle de Equipamentos");
    Console.WriteLine("2 - Controle de Chamados");
    Console.WriteLine("S - Sair");
    Console.WriteLine("---------------------------------");
    Console.Write("> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenuPrincipal == "1")
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Controle de Equipamentos");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Cadastrar equipamento");
            Console.WriteLine("2 - Editar equipamento");
            Console.WriteLine("3 - Excluir equipamento");
            Console.WriteLine("4 - Visualizar equipamentos");
            Console.WriteLine("S - Sair");
            Console.WriteLine("---------------------------------");
            Console.Write("> ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Cadastro de Equipamentos");
                Console.WriteLine("---------------------------------");

                Console.Write("Digite o nome do equipamento: ");
                string nome = Console.ReadLine();

                Console.Write("\nDigite o preço de aquisição do equipamento: ");
                decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite a data de fabricação do equipamento: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                Equipamento equipamento = new Equipamento();
                equipamento.id = contadorIdsEquipamentos++;
                equipamento.nome = nome;
                equipamento.precoAquisicao = precoAquisicao;
                equipamento.dataFabricacao = dataFabricacao;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    if (equipamentosSalvos[i] == null)
                    {
                        equipamentosSalvos[i] = equipamento; //guardando valores no array
                        break;
                    }
                }
                Console.WriteLine($"O equipamento {equipamento.nome} foi salvo com sucesso.");
                Console.ReadLine();
            }
            else if (opcaoMenu == "2")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Edição de Equipamentos");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(
                   "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                   "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                   ); //definindo ordem da coluna e tamanho

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i]; //extraindo valores do array
                    if (eq == null)
                        continue;

                    Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                    eq.id, eq.nome, "R$ " + eq.precoAquisicao, eq.dataFabricacao
                    ); //definindo ordem da coluna e tamanho
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite o Id que deseja editar: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o nome do equipamento: ");
                string nome = Console.ReadLine();

                Console.Write("\nDigite o preço de aquisição do equipamento: ");
                decimal precoAquisicao = Convert.ToDecimal(Console.ReadLine());

                Console.Write("\nDigite a data de fabricação do equipamento: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];

                    if (equipamentoSelecionado == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentoSelecionado.nome = nome;
                        equipamentoSelecionado.precoAquisicao = precoAquisicao;
                        equipamentoSelecionado.dataFabricacao = dataFabricacao;
                        break;
                    }
                }

                Console.WriteLine($"O equipamento {nome} foi salvo com sucesso.");
                Console.ReadLine();

            }
            else if (opcaoMenu == "3")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Exclusão de Equipamentos");
                Console.WriteLine("---------------------------------");
                Console.WriteLine(
                   "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                   "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                   ); //definindo ordem da coluna e tamanho

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i]; //extraindo valores do array
                    if (eq == null)
                        continue;

                    Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                    eq.id, eq.nome, "R$ " + eq.precoAquisicao, eq.dataFabricacao
                    );
                }

                Console.WriteLine("---------------------------------");
                Console.Write("Digite o Id que deseja excluir: ");
                int idSelecionado = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento equipamentoSelecionado = equipamentosSalvos[i];
                    if (equipamentoSelecionado == null)
                        continue;

                    if (equipamentoSelecionado.id == idSelecionado)
                    {
                        equipamentosSalvos[i] = null;
                        break;
                    }
                }

                Console.WriteLine($"O equipamento foi excluído com sucesso.");
                Console.ReadLine();
            }

            else if (opcaoMenu == "4")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Visualização de Equipamentos");
                Console.WriteLine("---------------------------------");

                //Tabela do console
                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    ); //definindo ordem da coluna e tamanho

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i]; //extraindo valores do array
                    if (eq == null)
                        continue;

                    Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                    eq.id, eq.nome, "R$ " + eq.precoAquisicao, eq.dataFabricacao
                    ); //definindo ordem da coluna e tamanho
                }
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Digite Enter para continuar...");
                Console.ReadLine();
            }
        }

    }

    if (opcaoMenuPrincipal == "2")
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Controle de Chamados");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Cadastrar chamado");
            Console.WriteLine("2 - Editar chamado");
            Console.WriteLine("3 - Excluir chamado");
            Console.WriteLine("4 - Visualizar chamado");
            Console.WriteLine("S - Sair");
            Console.WriteLine("---------------------------------");
            Console.Write("> ");
            string? opcaoMenu = Console.ReadLine()?.ToUpper();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Cadastro de Chamados");
                Console.WriteLine("---------------------------------");

                Console.Write("Digite o título do chamado: ");
                string titulo = Console.ReadLine();

                Console.Write("Digite a descrição do chamado: ");
                string descricao = Console.ReadLine();

                DateTime dataAbertura = DateTime.Now;

                Console.WriteLine("---------------------------------");

                //Tabela do console
                Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                    "Id", "Nome", "Preço de Aquisição", "Data de Fabricação"
                    ); //definindo ordem da coluna e tamanho

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i]; //extraindo valores do array
                    if (eq == null)
                        continue;

                    Console.WriteLine(
                    "{0, -7} | {1, -15} | {2, -20} | {3, -15}", //negativos para alinhar a esquerda
                    eq.id, eq.nome, "R$ " + eq.precoAquisicao, eq.dataFabricacao
                    ); //definindo ordem da coluna e tamanho
                }
                Console.WriteLine("---------------------------------");

                Console.Write("Digite o ID do equipamento que deseja selecionar: ");
                int idEquipamentoSelecionado = Convert.ToInt32(Console.ReadLine());

                Equipamento equipamentoSelecionado = null;

                for (int i = 0; i < equipamentosSalvos.Length; i++)
                {
                    Equipamento eq = equipamentosSalvos[i];
                    if (eq == null)
                        continue;

                    if (eq.id == idEquipamentoSelecionado)
                    {
                        equipamentoSelecionado = eq;
                        break;
                    }

                }
                Chamado novoChamado = new Chamado();
                novoChamado.id = contadorIdsChamados++;
                novoChamado.titulo = titulo;
                novoChamado.descricao = descricao;
                novoChamado.dataAbertura = dataAbertura;
                novoChamado.equipamento = equipamentoSelecionado;

                for (int i = 0; i < chamadosSalvos.Length; i++)
                {
                    if (chamadosSalvos[i] == null)
                    {
                        chamadosSalvos[i] = novoChamado;
                        break;
                    }
                }
                Console.WriteLine($"O chamado {novoChamado.titulo} foi cadastrado com sucesso.");
                Console.ReadLine();
            }
        }
    }
}

