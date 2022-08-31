using LandingPageVarejo.API.Data;
using LandingPageVarejo.API.DTOS;
using LandingPageVarejo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LandingPageVarejo.API.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LeadController : ControllerBase
    {
        private LeadContext _context;
        public LeadController(LeadContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Lead> ObterLeads()
        {
            return _context.Leads;
        }

        [HttpGet("{id}")]
       public IActionResult ObterLeadPorId(int id)
        {
            Lead lead = _context.Leads.FirstOrDefault(lead => lead.Id == id);
            if(lead != null)
            {
                ReadLeadDTO leadDTO = new ReadLeadDTO()
                {
                    Id = lead.Id,
                    Nome = lead.Nome,
                    Email = lead.Email,
                    HoraDaConsulta = DateTime.Now
                };
                return Ok(lead);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionarLead([FromBody] CreateLeadDTO leadDTO)
        {
            Lead lead = new Lead()
            {
                Nome = leadDTO.Nome,  
                Email = leadDTO.Email,
            };
            _context.Leads.Add(lead);
            _context.SaveChanges();
            return CreatedAtAction(nameof(ObterLeadPorId), new { id = lead.Id }, lead);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarLead(int id, [FromBody] UpdataLeadDTO novolead)
        {
            Lead lead = _context.Leads.FirstOrDefault(lead => lead.Id == id);
            if(lead == null)
            {
                return NotFound();
            }
            lead.Nome = novolead.Nome;
            lead.Email = novolead.Email;
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult ExcluirLead(int id)
        {
            Lead lead = _context.Leads.FirstOrDefault(lead => lead.Id == id);
            if(lead == null)
            {
                return NotFound();
            }
            _context.Remove(lead);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
