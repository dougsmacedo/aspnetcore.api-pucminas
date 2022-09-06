using aspnetcore.api_pucminas.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore.api_pucminas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public VeiculosController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Veiculos.ToListAsync();
            return Ok(model);
        }
        [HttpPost]
        public async Task<ActionResult> Create(Veiculo model)
        {
            if(model.AnoFabricacao <=0 || model.AnoModelo <= 0)
            {
                return BadRequest(new { message = "Obrigatorio Ano do modelo e Ano fabricação" });
            }
            _context.Veiculos.Add(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpGet("id")]
        public asy MyProperty { get; set; }

    }
}
