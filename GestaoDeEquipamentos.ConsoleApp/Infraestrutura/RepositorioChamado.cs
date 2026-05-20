using System.Xml.Serialization;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioChamado
{
    int contadorIdsChamados = 1;
    private Chamado[] chamadosSalvos = new Chamado[100];

    public void Cadastrar(Chamado novoChamado)
    {
        novoChamado.id = contadorIdsChamados++;


    }

    public void Editar()
    {

    }

    public void Excluir()
    {

    }

    public void Visualizar()
    {

    }

    public Chamado[] SelecionarTodos()
    {
        return chamadosSalvos;
    }
}