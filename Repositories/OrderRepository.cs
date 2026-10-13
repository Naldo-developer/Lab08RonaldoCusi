using Lab08RonaldoCusi.Data;
using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
namespace Lab08RonaldoCusi.Repositories;
public class OrderRepository(AppDbContext context) : IOrderRepository
{
    public Task<List<OrderDto>> GetOrdersAfterDateExercise6Async(DateTime fecha, CancellationToken ct = default) =>
        context.Orders.AsNoTracking().Where(o => o.Orderdate > DateTime.SpecifyKind(fecha, DateTimeKind.Unspecified)).Select(o => new OrderDto(o.Orderid,o.Clientid,o.Orderdate)).ToListAsync(ct);

    public Task<ClientOrderCountDto?> GetClientWithMostOrdersExercise9Async(CancellationToken ct = default) =>
        context.Orders.AsNoTracking().GroupBy(o => o.Clientid)
            .Select(g => new { ClientId = g.Key, OrderCount = g.Count() })
            .OrderByDescending(c => c.OrderCount).ThenBy(c => c.ClientId)
            .Select(c => new ClientOrderCountDto(c.ClientId,
                context.Clients.Where(client => client.Clientid == c.ClientId).Select(client => client.Name).First(),
                c.OrderCount))
            .FirstOrDefaultAsync(ct);

    public Task<List<ProductNameDto>> GetProductsSoldToClientExercise11Async(int clientId, CancellationToken ct = default) =>
        context.Orders.AsNoTracking().Where(o => o.Clientid == clientId).SelectMany(o => o.Orderdetails).Select(d => d.Product.Name).Distinct().Select(n => new ProductNameDto(n)).ToListAsync(ct);

    public Task<List<ClientDto>> GetClientsWhoBoughtProductExercise12Async(int productId, CancellationToken ct = default) =>
        context.Orderdetails.AsNoTracking().Where(d => d.Productid == productId).Select(d => new {d.Order.Client.Clientid,d.Order.Client.Name,d.Order.Client.Email}).Distinct().Select(c => new ClientDto(c.Clientid,c.Name,c.Email)).ToListAsync(ct);
}
