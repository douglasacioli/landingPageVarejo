using LandingPageVarejo.API.Models;
using Microsoft.EntityFrameworkCore;

namespace LandingPageVarejo.API.Data
{
    public class LeadContext : DbContext
    {
        public LeadContext(DbContextOptions<LeadContext> options) : base(options)
        {

        }
        public DbSet<Lead> Leads{ get; set; }
    }
}
