using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;

namespace ApiGerenciadorSalas.Services;

public interface ISalaService
{
    Task<ResponseModel<IEnumerable<Sala>>> GetAll();
    Task<ResponseModel<Sala>> Create(SalaCriacaoDto salaCriacaoDto);
}