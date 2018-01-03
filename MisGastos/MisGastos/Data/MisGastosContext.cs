using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MisGastos.Models
{
    public class MisGastosContext : DbContext
    {
        public MisGastosContext (DbContextOptions<MisGastosContext> options)
            : base(options)
        {
        }

        public DbSet<MisGastos.Models.Gasto> Gasto { get; set; }
    }
}
