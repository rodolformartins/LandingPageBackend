using LandingPageBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace LandingPageBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LeadController : ControllerBase
    {
        [HttpPost]
        public IActionResult PostLead([FromBody] Lead lead)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Aqui você poderia processar os dados (armazenar no banco ou enviar um email).
            return Ok(new { message = "Lead recebido com sucesso1!" });
        }
    }
}