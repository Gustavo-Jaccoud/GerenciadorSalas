namespace ApiGerenciadorSalas.Dto.Sala;

public class SalaCriacaoDto
{
    public string Nome { get; set; }
    public string Chave { get; set; }
    public string ChaveReserva { get; set; }
    public int Cadeiras { get; set; }
}