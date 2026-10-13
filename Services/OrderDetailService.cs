using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Lab08RonaldoCusi.Services.Interfaces;
namespace Lab08RonaldoCusi.Services;
public class OrderDetailService(IOrderDetailRepository repository) : IOrderDetailService
{
    public Task<List<ProductQuantityDto>> GetOrderProductDetailsExercise3Async(int orderId, CancellationToken ct = default) =>
        repository.GetOrderProductDetailsExercise3Async(orderId, ct);

    public Task<int> GetTotalProductQuantityExercise4Async(int orderId, CancellationToken ct = default) =>
        repository.GetTotalProductQuantityExercise4Async(orderId, ct);

    public Task<List<OrderWithDetailsDto>> GetOrdersWithDetailsExercise10Async(CancellationToken ct = default) =>
        repository.GetOrdersWithDetailsExercise10Async(ct);
}
