using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioEquipamento //armazém
{
    public int contadorIdsEquipamentos = 1;
    //array = coleção de objetos - declarado antes do escopo do while para as informações continuarem salvas durante o uso
    private Equipamento[] equipamentosSalvos = new Equipamento[100];

    public void Cadastrar(Equipamento novoEquipamento)
    {
        novoEquipamento.id = contadorIdsEquipamentos++;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = novoEquipamento; //guardando valores no array
                break;
            }
        }
    }

    public void Editar(int idSelecionado, Equipamento equipamentoAtualizado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.id == idSelecionado)
            {
                equipamentoSelecionado.nome = equipamentoAtualizado.nome;
                equipamentoSelecionado.precoAquisicao = equipamentoAtualizado.precoAquisicao;
                equipamentoSelecionado.dataFabricacao = equipamentoAtualizado.dataFabricacao;
                break;
            }
        }
    }

    public void Excluir(int idSelecionado)
    {
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
    }
    public Equipamento[] SelecionarTodos()
    {
        return equipamentosSalvos;
    }
}