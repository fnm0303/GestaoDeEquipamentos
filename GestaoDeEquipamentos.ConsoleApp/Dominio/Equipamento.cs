using System;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

/*
• Deve ter identificador único (id)
• Deve ter um nome com no mínimo 6 caracteres;
• Deve ter um preço de aquisição;
• Deve ter uma fabricante;
• Deve ter uma data de fabricação;
*/
public class Equipamento
{
    public int id;
    public string nome;
    public decimal precoAquisicao;
    public DateTime dataFabricacao;

    // método construtor
    public Equipamento(string nome, decimal precoAquisicao, DateTime dataFabricacao)
    {
        this.nome = nome;
        this.precoAquisicao = precoAquisicao;
        this.dataFabricacao = dataFabricacao;
    }
}
