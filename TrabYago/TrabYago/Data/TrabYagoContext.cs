using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabYago.Models;

namespace TrabYago.Models
{
    public class TrabYagoContext : DbContext
    {
        public TrabYagoContext (DbContextOptions<TrabYagoContext> options)
            : base(options)
        {
        }

        public DbSet<TrabYago.Models.Jogador> Jogador { get; set; }

        public DbSet<TrabYago.Models.Placar> Placar { get; set; }
    }
}
