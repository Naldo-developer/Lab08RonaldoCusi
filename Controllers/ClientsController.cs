using Lab08RonaldoCusi.DTOs;
using Lab08RonaldoCusi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace Lab08RonaldoCusi.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ClientsController(IClientService service) : ControllerBase
{
    [HttpGet("ejercicio1", Name = "Ejercicio1")]
    [EndpointSummary("Ejercicio 1: GetClientsByName")]
    public async Task<ActionResult<List<ClientDto>>> Ejercicio1([BindRequired, FromQuery] string nombre, CancellationToken ct) =>
        Ok(await service.GetClientsByNameExercise1Async(nombre, ct));
}
