using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace Lab08RonaldoCusi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductsController(IProductService service) : ControllerBase
{
    [HttpGet("ejercicio2", Name = "Ejercicio2")]
    [EndpointSummary("Ejercicio 2: GetProductsAbovePrice")]
    public async Task<ActionResult<List<ProductDto>>> Ejercicio2([BindRequired, FromQuery] decimal precio, CancellationToken ct) =>
        Ok(await service.GetProductsAbovePriceExercise2Async(precio, ct));

    [HttpGet("ejercicio5", Name = "Ejercicio5")]
    [EndpointSummary("Ejercicio 5: GetMostExpensiveProduct")]
    public async Task<ActionResult<ProductDto?>> Ejercicio5(CancellationToken ct) =>
        Ok(await service.GetMostExpensiveProductExercise5Async(ct));

    [HttpGet("ejercicio7", Name = "Ejercicio7")]
    [EndpointSummary("Ejercicio 7: GetAverageProductPrice")]
    public async Task<ActionResult<decimal?>> Ejercicio7(CancellationToken ct) =>
        Ok(await service.GetAverageProductPriceExercise7Async(ct));

    [HttpGet("ejercicio8", Name = "Ejercicio8")]
    [EndpointSummary("Ejercicio 8: GetProductsWithoutDescription")]
    public async Task<ActionResult<List<ProductDto>>> Ejercicio8(CancellationToken ct) =>
        Ok(await service.GetProductsWithoutDescriptionExercise8Async(ct));
}
