using System.Reflection.Metadata;
using GestaoDeEquipamentos.ConsoleApp.Apresentacao;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();

TelaPrincipal telaPrincipal = new TelaPrincipal();
TelaEquipamento telaEquipamento = new TelaEquipamento();

telaEquipamento.repositorioEquipamento = repositorioEquipamento;

TelaChamado telaChamado = new TelaChamado();

while (true)
{
    string? opcaoMenuPrincipal = telaPrincipal.ObterOpcaoMenuPrincipal();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    if (opcaoMenuPrincipal == "1")
    {
        while (true)
        {
            string? opcaoMenu = telaEquipamento.ObterOpcaoMenuEquipamento();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telaEquipamento.Cadastrar();

            else if (opcaoMenu == "2")
                telaEquipamento.Editar();

            else if (opcaoMenu == "3")
                telaEquipamento.Excluir();

            else if (opcaoMenu == "4")
                telaEquipamento.Visualizar();
        }

    }

    if (opcaoMenuPrincipal == "2")
    {
        while (true)
        {
            string? opcaoMenu = telaChamado.ObterMenuChamado();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
            {

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
    }
}

