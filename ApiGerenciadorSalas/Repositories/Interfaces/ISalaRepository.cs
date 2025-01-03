using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;

namespace ApiGerenciadorSalas.Repositories.Interfaces;

public interface ISalaRepository
{
    Task<IEnumerable<Sala>> GetAll();
    Task<Sala> Create(SalaDto salaDto);
    
    Task<Sala> GetById(int salaId);
    
    Task<Sala> Update(int salaId,SalaDto salaDto);
    
    Task<Sala> Delete(int salaId);
}