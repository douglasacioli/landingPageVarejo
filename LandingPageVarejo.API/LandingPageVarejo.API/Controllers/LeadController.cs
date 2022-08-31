using LandingPageVarejo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LandingPageVarejo.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LeadController : ControllerBase
    {
        public static int Id = 1;
        private static IEnumerable<Lead> leads = new List<Lead>()
        {
            new Lead()
            {
                Id = 1,
                Nome = "Douglas",
                Email = "douglas.acioli@gmail.com"
            },
             new Lead()
            {
                Id = 2,
                Nome = "Arthur",
                Email = "arthur.acioli@gmail.com"
            },
        };

        [HttpGet]
        public IEnumerable<Lead> RecuperarFilmes()
        {
            return leads;
        }

        [HttpGet("{id}")]
       public IActionResult ObterLeadPorId(int id)
        {
            Lead lead = leads.FirstOrDefault(lead => lead.Id == id);
            if(lead != null)
            {
                return Ok(lead);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionarLead([FromBody] Lead lead)
        {
          
            return CreatedAtAction(nameof(ObterLeadPorId), new { id = lead.Id }, lead);
        }

    }
}
