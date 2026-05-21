namespace GestaoDeEquipamentos.ConsoleApp.Utilidades;

public static class GeradorIds
{
    private static int contadorIdsEquipamentos = 1;
    private static int contadorIdsChamados = 1;

    public static int ObterIdEquipamento()
    {
        return contadorIdsEquipamentos++;
    }

    public static int ObterIdChamado()
    {
        return contadorIdsChamados++;
    }
}
