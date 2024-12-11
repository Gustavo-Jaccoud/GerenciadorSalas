namespace ApiGerenciadorSalas.Entities;

public class SalaSoftware
{
    public int SalaId { get; set; }
    public Sala Sala { get; set; }

    public int SoftwareId { get; set; }
    public Software Software { get; set; }
}