using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace Lab08RonaldoCusi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class OrderDetailsController(IOrderDetailService service) : ControllerBase
{
    [HttpGet("ejercicio3", Name = "Ejercicio3")]
    [EndpointSummary("Ejercicio 3: GetOrderProductDetails")]
    public async Task<ActionResult<List<ProductQuantityDto>>> Ejercicio3([BindRequired, FromQuery] int orderId, CancellationToken ct) =>
        Ok(await service.GetOrderProductDetailsExercise3Async(orderId, ct));

    [HttpGet("ejercicio4", Name = "Ejercicio4")]
    [EndpointSummary("Ejercicio 4: GetTotalProductQuantity")]
    public async Task<ActionResult<int>> Ejercicio4([BindRequired, FromQuery] int orderId, CancellationToken ct) =>
        Ok(await service.GetTotalProductQuantityExercise4Async(orderId, ct));

    [HttpGet("ejercicio10", Name = "Ejercicio10")]
    [EndpointSummary("Ejercicio 10: GetOrdersWithDetails")]
    public async Task<ActionResult<List<OrderWithDetailsDto>>> Ejercicio10(CancellationToken ct) =>
        Ok(await service.GetOrdersWithDetailsExercise10Async(ct));
}
