using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Lab08RonaldoCusi.Services.Interfaces;
namespace Lab08RonaldoCusi.Services;
public class OrderService(IOrderRepository repository) : IOrderService
{
    public Task<List<OrderDto>> GetOrdersAfterDateExercise6Async(DateTime fecha, CancellationToken ct = default) =>
        repository.GetOrdersAfterDateExercise6Async(fecha, ct);

    public Task<ClientOrderCountDto?> GetClientWithMostOrdersExercise9Async(CancellationToken ct = default) =>
        repository.GetClientWithMostOrdersExercise9Async(ct);

    public Task<List<ProductNameDto>> GetProductsSoldToClientExercise11Async(int clientId, CancellationToken ct = default) =>
        repository.GetProductsSoldToClientExercise11Async(clientId, ct);

    public Task<List<ClientDto>> GetClientsWhoBoughtProductExercise12Async(int productId, CancellationToken ct = default) =>
        repository.GetClientsWhoBoughtProductExercise12Async(productId, ct);
}
