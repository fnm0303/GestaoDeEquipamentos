using System;
using GestaoDeEquipamentos.ConsoleApp.Utilidades;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

public class Chamado
{
    public int Id { get; private set; }
    public string Titulo { get; private set; }
    public string Descricao { get; private set; }
    public DateTime DataAbertura { get; private set; }

    public Equipamento Equipamento; //relacionamento entre classes

    public Chamado(string titulo, string descricao, Equipamento equipamento)
    {
        Id = GeradorIds.ObterIdChamado();

        Titulo = titulo;
        Descricao = descricao;
        Equipamento = equipamento;

        DataAbertura = DateTime.Now;
    }

    public void Atualizar(Chamado chamadoAtualizado)
    {
        Titulo = chamadoAtualizado.Titulo;
        Descricao = chamadoAtualizado.Descricao;
        Equipamento = chamadoAtualizado.Equipamento;
    }
}
