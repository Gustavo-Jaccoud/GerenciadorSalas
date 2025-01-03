using ApiGerenciadorSalas.Context;
using ApiGerenciadorSalas.Dto.Sala;
using ApiGerenciadorSalas.Entities;
using ApiGerenciadorSalas.Repositories.Interfaces;
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

    public async Task<Sala> Create(SalaDto salaDto)
    {

            var sala = new Sala()
            {
                Nome = salaDto.Nome,
                Chave = salaDto.Chave,
                ChaveReserva = salaDto.ChaveReserva,
                Cadeiras = salaDto.Cadeiras,
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

    public async Task<Sala> Update(int salaId, SalaDto salaDto)
    {
        var sala = await GetById(salaId);

        if (sala != null)
        {
            sala.Nome = salaDto.Nome;
            sala.Chave = salaDto.Chave;
            sala.ChaveReserva = salaDto.ChaveReserva;
            sala.Cadeiras = salaDto.Cadeiras;
        }

        _context.Update(sala);
        await _context.SaveChangesAsync();
        
        return sala;
    }

    public async Task<Sala> Delete(int salaId)
    {
        var sala = await GetById(salaId);
        _context.Remove(sala);
        await _context.SaveChangesAsync();
        return sala;
    }
}