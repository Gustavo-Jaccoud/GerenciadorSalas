using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Dto.Software;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Entities.Responses;

namespace ApiGerenciadorSalas.Services.Interfaces;

public interface ISoftwareService
{
    Task<ResponseModel<IEnumerable<Software>>> GetAll();
    Task<ResponseModel<Software>> Create(SoftwareDto softwareDto);
    
    Task<ResponseModel<Software>> GetById(int softwareId);
    
    Task<ResponseModel<Software>> Update(int softwareId, SoftwareDto softwareDto);
    
    Task<ResponseModel<Software>> Delete(int softwareId);
}