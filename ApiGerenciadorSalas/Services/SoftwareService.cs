using ApiGerenciadorSalas.Dto.Software;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;
using ApiGerenciadorSalas.Repositories.Interfaces;
using ApiGerenciadorSalas.Services.Interfaces;

namespace ApiGerenciadorSalas.Services;

public class SoftwareService : ISoftwareService
{
    private readonly ISoftwareRepository _repository;

    public SoftwareService(ISoftwareRepository repository)
    {
        _repository = repository;
    }
    public async Task<ResponseModel<IEnumerable<Software>>> GetAll()
    {
        ResponseModel<IEnumerable<Software>> response = new ResponseModel<IEnumerable<Software>>();
        try
        {
            response.Data = await _repository.GetAll();
            response.Message = "Sucesso";
            response.StatusCode = 200;
            Console.WriteLine(response.Data);
            if (!response.Data.Any())
            {
                response.Message = "Nenhum software registrado";
            }
            return response;
        }
        catch (Exception ex)
        { 
            response.Data = null;     
            response.Message = $"Erro ao encontrar softwares: {ex.Message}";
            response.StatusCode = 500;
            return response;
        }
    }

    public Task<ResponseModel<Software>> Create(SoftwareDto softwareDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<Software>> GetById(int softwareId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<Software>> Update(int softwareId, SoftwareDto softwareDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseModel<Software>> Delete(int softwareId)
    {
        throw new NotImplementedException();
    }
}