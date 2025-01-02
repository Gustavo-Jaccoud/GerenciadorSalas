using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;

namespace ApiGerenciadorSalas.Services;

public interface ISalaService
{
    Task<ResponseModel<IEnumerable<Sala>>> GetAll();
    Task<ResponseModel<Sala>> Create(SalaDto salaDto);
    
    Task<ResponseModel<Sala>> GetById(int salaId);
    
    Task<ResponseModel<Sala>> Update(int salaId, SalaDto salaDto);
    
    Task<ResponseModel<Sala>> Delete(int salaId);
}