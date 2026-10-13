using Lab08RonaldoCusi.DTOs;
namespace Lab08RonaldoCusi.Services.Interfaces;
public interface IOrderService
{
    Task<List<OrderDto>> GetOrdersAfterDateExercise6Async(DateTime fecha, CancellationToken ct = default);
    Task<ClientOrderCountDto?> GetClientWithMostOrdersExercise9Async(CancellationToken ct = default);
    Task<List<ProductNameDto>> GetProductsSoldToClientExercise11Async(int clientId, CancellationToken ct = default);
    Task<List<ClientDto>> GetClientsWhoBoughtProductExercise12Async(int productId, CancellationToken ct = default);
}
