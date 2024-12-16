using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;

namespace ApiGerenciadorSalas.Services;

public interface ISalaService
{
    Task<ResponseModel<IEnumerable<Sala>>> GetAll();
}