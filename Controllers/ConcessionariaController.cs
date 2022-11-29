using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ProjetoEstacionamento.Model;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoEstacionamento.Controllers;

[ApiController]
[Route("concessionaria/")]
public class ConcessionariaController : ControllerBase
{
    [HttpGet("{numberConc}")]
    public async Task<IActionResult> VerifyCar(int numberConc)
    {
        var context = new SistemaFabricaAutomotivaContext();
        var verify = await context.Alocacaos.FirstOrDefaultAsync(u => u.Area == numberConc);
        if(verify.Area >= 0)
            return Ok(false);
        return Ok(true);
    }
    [HttpGet("consultCar/{CarName}")]
    public async Task<IActionResult> consultCar(string CarName)
    {
        var context = new SistemaFabricaAutomotivaContext();
        var verify = await context.Automoveis.FirstOrDefaultAsync(u => u.Modelo == CarName);
        return Ok(verify);
    }
    
}
