using Microsoft.AspNetCore.Mvc;
using API_Estacionamento.Models;

namespace API_Estacionamento.Controllers;

[ApiController]
[Route("[controller]")]
public class CarroController : ControllerBase
{
    private readonly ILogger<CarroController> _logger;
    public CarroController(ILogger<CarroController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCarro")]
    public IEnumerable<Carro> Get()
    {
        List<Carro> carroList = new()
        {
            new Carro("ABC1234", "FIAT Argo"),
            new Carro("DEF5678", "GM Ônix")
        };
        return carroList;
    }
}
