using Microsoft.EntityFrameworkCore;
using mvcApplication1.Models;

namespace mvcApplication1.Data
{
    public class Mvc : DbContext
    {
        public Mvc(DbContextOptions<Mvc> options) : base(options)
        {
        }    
        public DbSet<KYC> KYC { get; set; }
        }
    }

