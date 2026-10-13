using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Lab08RonaldoCusi.Services.Interfaces;
namespace Lab08RonaldoCusi.Services;
public class ClientService(IClientRepository repository) : IClientService
{
    public Task<List<ClientDto>> GetClientsByNameExercise1Async(string nombre, CancellationToken ct = default) =>
        repository.GetClientsByNameExercise1Async(nombre, ct);
}
