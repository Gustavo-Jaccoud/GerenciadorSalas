using ApiGerenciadorSalas.Entities;

namespace ApiGerenciadorSalas.Repositories;

public interface ISalaRepository
{
    Task<IEnumerable<Sala>> GetAll();
}