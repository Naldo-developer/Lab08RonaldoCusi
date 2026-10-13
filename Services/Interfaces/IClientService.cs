using Lab08RonaldoCusi.DTOs;
namespace Lab08RonaldoCusi.Services.Interfaces;
public interface IClientService
{
    Task<List<ClientDto>> GetClientsByNameExercise1Async(string nombre, CancellationToken ct = default);
}
