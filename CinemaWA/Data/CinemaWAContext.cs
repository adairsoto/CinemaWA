using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CinemaWA.Models;

namespace CinemaWA.Data
{
    public class CinemaWAContext : DbContext
    {
        public CinemaWAContext (DbContextOptions<CinemaWAContext> options)
            : base(options)
        {
        }

        public DbSet<CinemaWA.Models.Reserva> Reserva { get; set; }

        public DbSet<CinemaWA.Models.Sessao> Sessao { get; set; }

        public DbSet<CinemaWA.Models.Sala> Sala { get; set; }

        public DbSet<CinemaWA.Models.Assento> Assento { get; set; }

        public DbSet<CinemaWA.Models.Filme> Filme { get; set; }

        public DbSet<CinemaWA.Models.Cliente> Cliente { get; set; }
    }
}
