using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;

namespace ApiGerenciadorSalas.Repositories;

public interface ISalaRepository
{
    Task<IEnumerable<Sala>> GetAll();
    Task<Sala> Create(SalaDto salaDto);
    
    Task<Sala> GetById(int salaId);
    
    Task<Sala> Update(int salaId,SalaDto salaDto);
}