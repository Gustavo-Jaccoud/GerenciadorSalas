using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;

namespace ApiGerenciadorSalas.Repositories;

public interface ISalaRepository
{
    Task<IEnumerable<Sala>> GetAll();
    Task<Sala> Create(SalaCriacaoDto salaCriacaoDto);
}