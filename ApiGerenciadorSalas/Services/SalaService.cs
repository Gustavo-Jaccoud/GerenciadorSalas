using ApiGerenciadorSalas.Dto.Sala;
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

    public async Task<ResponseModel<Sala>> Create(SalaCriacaoDto salaCriacaoDto)
    {
        ResponseModel<Sala> response = new ResponseModel<Sala>();
        try
        {
            
            response.Data = await _repository.Create(salaCriacaoDto);
            response.Message = "Sala criada com sucesso.";
            response.StatusCode = 201;
            return response;
        }
        catch (Exception ex)
        {
            response.Data = null;
            response.Message = $"Erro ao criar a sala: {ex.Message}";
            response.StatusCode = 500;
            return response;
        }
    }
}