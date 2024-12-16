using ApiGerenciadorSalas.Context;
using ApiGerenciadorSalas.Dto.Sala;
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
        return await _context.Salas
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task<Sala> Create(SalaCriacaoDto salaCriacaoDto)
    {

            var sala = new Sala()
            {
                Nome = salaCriacaoDto.Nome,
                Chave = salaCriacaoDto.Chave,
                ChaveReserva = salaCriacaoDto.ChaveReserva,
                Cadeiras = salaCriacaoDto.Cadeiras,
            };
            _context.Add(sala);
            await _context.SaveChangesAsync();
          
            return sala;
            
    }

    public async Task<Sala> GetById(int salaId)
    {
        return await _context.Salas
            .AsNoTracking()
            .FirstOrDefaultAsync(s => s.Id == salaId);
    }
}