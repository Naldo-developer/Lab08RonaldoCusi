using Lab08RonaldoCusi.DTOs;
namespace Lab08RonaldoCusi.Services.Interfaces;
public interface IOrderDetailService
{
    Task<List<ProductQuantityDto>> GetOrderProductDetailsExercise3Async(int orderId, CancellationToken ct = default);
    Task<int> GetTotalProductQuantityExercise4Async(int orderId, CancellationToken ct = default);
    Task<List<OrderWithDetailsDto>> GetOrdersWithDetailsExercise10Async(CancellationToken ct = default);
}
