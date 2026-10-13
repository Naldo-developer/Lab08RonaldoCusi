using Lab08RonaldoCusi.Data;
using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Lab08RonaldoCusi.Repositories;
public class OrderDetailRepository(AppDbContext context) : IOrderDetailRepository
{
    public Task<List<ProductQuantityDto>> GetOrderProductDetailsExercise3Async(int orderId, CancellationToken ct = default) =>
        context.Orderdetails.AsNoTracking().Where(d => d.Orderid == orderId).Select(d => new ProductQuantityDto(d.Product.Name,d.Quantity)).ToListAsync(ct);

    public Task<int> GetTotalProductQuantityExercise4Async(int orderId, CancellationToken ct = default) =>
        context.Orderdetails.AsNoTracking().Where(d => d.Orderid == orderId).Select(d => d.Quantity).SumAsync(ct);

    public Task<List<OrderWithDetailsDto>> GetOrdersWithDetailsExercise10Async(CancellationToken ct = default) =>
        context.Orders.AsNoTracking().Select(o => new OrderWithDetailsDto(o.Orderid,o.Clientid,o.Orderdate,context.Orderdetails.Where(d => d.Orderid == o.Orderid).Select(d => new ProductQuantityDto(d.Product.Name,d.Quantity)).ToList())).ToListAsync(ct);
}
