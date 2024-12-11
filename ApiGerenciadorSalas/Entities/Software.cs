namespace ApiGerenciadorSalas.Entities;

public class Software
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Versao { get; set; }
    
    public ICollection<SalaSoftware> SalaSoftwares { get; set; }
}