using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace Lab08RonaldoCusi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class OrdersController(IOrderService service) : ControllerBase
{
    [HttpGet("ejercicio6", Name = "Ejercicio6")]
    [EndpointSummary("Ejercicio 6: GetOrdersAfterDate")]
    public async Task<ActionResult<List<OrderDto>>> Ejercicio6([BindRequired, FromQuery] DateTime fecha, CancellationToken ct) =>
        Ok(await service.GetOrdersAfterDateExercise6Async(fecha, ct));

    [HttpGet("ejercicio9", Name = "Ejercicio9")]
    [EndpointSummary("Ejercicio 9: GetClientWithMostOrders")]
    public async Task<ActionResult<ClientOrderCountDto?>> Ejercicio9(CancellationToken ct) =>
        Ok(await service.GetClientWithMostOrdersExercise9Async(ct));

    [HttpGet("ejercicio11", Name = "Ejercicio11")]
    [EndpointSummary("Ejercicio 11: GetProductsSoldToClient")]
    public async Task<ActionResult<List<ProductNameDto>>> Ejercicio11([BindRequired, FromQuery] int clientId, CancellationToken ct) =>
        Ok(await service.GetProductsSoldToClientExercise11Async(clientId, ct));

    [HttpGet("ejercicio12", Name = "Ejercicio12")]
    [EndpointSummary("Ejercicio 12: GetClientsWhoBoughtProduct")]
    public async Task<ActionResult<List<ClientDto>>> Ejercicio12([BindRequired, FromQuery] int productId, CancellationToken ct) =>
        Ok(await service.GetClientsWhoBoughtProductExercise12Async(productId, ct));
}
