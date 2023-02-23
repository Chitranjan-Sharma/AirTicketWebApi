using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AirTicketWebApi.Models;

namespace AirTicketWebApi.Data
{
    public class AirTicketWebApiDbContext : DbContext
    {
        public AirTicketWebApiDbContext (DbContextOptions<AirTicketWebApiDbContext> options)
            : base(options)
        {
        }

        public DbSet<AirTicketWebApi.Models.Customer> Customer { get; set; } = default!;

        public DbSet<AirTicketWebApi.Models.Flight> Flight { get; set; }

        public DbSet<AirTicketWebApi.Models.Feedback> Feedback { get; set; }

        public DbSet<AirTicketWebApi.Models.Ticket> Ticket { get; set; }

        public DbSet<AirTicketWebApi.Models.Admin> Admin { get; set; }

        public DbSet<AirTicketWebApi.Models.Payment> Payment { get; set; }

        public DbSet<AirTicketWebApi.Models.Logs> Logs { get; set; }

        
    }
}
