using Lab08RonaldoCusi.Data;
using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Lab08RonaldoCusi.Repositories;
public class ClientRepository(AppDbContext context) : IClientRepository
{
    public Task<List<ClientDto>> GetClientsByNameExercise1Async(string nombre, CancellationToken ct = default) =>
        context.Clients.AsNoTracking().Where(c => c.Name.Contains(nombre)).Select(c => new ClientDto(c.Clientid,c.Name,c.Email)).ToListAsync(ct);
}
