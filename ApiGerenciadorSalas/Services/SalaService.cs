using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;
using ApiGerenciadorSalas.Repositories;

namespace ApiGerenciadorSalas.Services;

public class SalaService : ISalaService
{
    private readonly ISalaRepository _repository;

    public SalaService(ISalaRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResponseModel<IEnumerable<Sala>>> GetAll()
    {
        ResponseModel<IEnumerable<Sala>> response = new ResponseModel<IEnumerable<Sala>>();
        response.Data = await _repository.GetAll();
        response.Message = "Sucesso";
        response.StatusCode = 200;
        return response;
    }
}