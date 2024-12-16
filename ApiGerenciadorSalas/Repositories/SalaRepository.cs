using ApiGerenciadorSalas.Context;
using ApiGerenciadorSalas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGerenciadorSalas.Repositories;

public class SalaRepository : ISalaRepository
{
    private readonly AppDbContext _context;

    public SalaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Sala>> GetAll()
    {
        return await _context.Set<Sala>()
            .AsNoTracking()
            .ToListAsync();
    }
}