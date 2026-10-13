using Lab08RonaldoCusi.DTOs;
namespace Lab08RonaldoCusi.Repositories.Interfaces;
public interface IClientRepository
{
    Task<List<ClientDto>> GetClientsByNameExercise1Async(string nombre, CancellationToken ct = default);
}
