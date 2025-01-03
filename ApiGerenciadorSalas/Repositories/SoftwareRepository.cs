using ApiGerenciadorSalas.Context;
using ApiGerenciadorSalas.Dto.Software;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiGerenciadorSalas.Repositories;

public class SoftwareRepository : ISoftwareRepository
{
    private readonly AppDbContext _context;

    public SoftwareRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<Software>> GetAll()
    {
       return await _context.Softwares
           .AsNoTracking()
           .ToListAsync();
    }

    public async Task<Software> Create(SoftwareDto softwareDto)
    {
        var software = new Software()
        {
            Nome = softwareDto.Nome,
            Versao = softwareDto.Versao
        };
        _context.Add(software);
        await _context.SaveChangesAsync();
        return software;
    }

    public Task<Software> GetById(int softwareId)
    {
        throw new NotImplementedException();
    }

    public Task<Software> Update(int softwareId, SoftwareDto softwareDto)
    {
        throw new NotImplementedException();
    }

    public Task<Software> Delete(int softwareId)
    {
        throw new NotImplementedException();
    }
}