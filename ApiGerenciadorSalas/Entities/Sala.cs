using System.Text.Json.Serialization;

namespace ApiGerenciadorSalas.Entities;

public class Sala
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public bool Chave { get; set; }
    public bool ChaveReserva { get; set; }
    public int Cadeiras { get; set; }
    [JsonIgnore]
    public ICollection<SalaSoftware> SalaSoftwares { get; set; }
}