namespace ApiGerenciadorSalas.Dto.Sala;

public class SalaDto
{
    public string Nome { get; set; }
    public bool Chave { get; set; }
    public bool ChaveReserva { get; set; }
    public int Cadeiras { get; set; }
}