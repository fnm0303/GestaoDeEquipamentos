using GestaoDeEquipamentos.ConsoleApp.Dominio;

int contadorIds = 1;

//array = coleção de objetos - declarado antes do escopo do while para as informações continuarem salvas durante o uso
Equipamento[] equipamentosSalvos = new Equipamento[100];

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Gestão de Equipamentos");
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
        equipamento.id = contadorIds++;
        equipamento.nome = nome;
        equipamento.precoAquisicao = precoAquisicao;
        equipamento.dataFabricacao = dataFabricacao;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = equipamento;
                break;
            }
        }
        Console.WriteLine($"O equipamento {equipamento.nome} foi salvo com sucesso.");
        Console.ReadLine();
    }
    else if (opcaoMenu == "2")
    {
    }
    else if (opcaoMenu == "3")
    {
    }
    else if (opcaoMenu == "4")
    {
    }
}
