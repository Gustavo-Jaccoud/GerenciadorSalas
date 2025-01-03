using ApiGerenciadorSalas.Dto.Software;
using ApiGerenciadorSalas.Entities;

namespace ApiGerenciadorSalas.Repositories.Interfaces;

public interface ISoftwareRepository
{
    Task<IEnumerable<Software>> GetAll();
    Task<Software> Create(SoftwareDto softwareDto);
    
    Task<Software> GetById(int softwareId);
    
    Task<Software> Update(int softwareId,SoftwareDto softwareDto);
    
    Task<Software> Delete(int softwareId);
}