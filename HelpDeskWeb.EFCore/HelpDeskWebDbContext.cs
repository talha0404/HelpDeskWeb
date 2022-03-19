using HelpDeskWeb.Domain.Entities;
using HelpDeskWeb.EFCore.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpDeskWeb.EFCore
{
    public class HelpDeskWebDbContext : DbContext
    {
        public HelpDeskWebDbContext(DbContextOptions<HelpDeskWebDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new FirmMap());
            modelBuilder.ApplyConfiguration(new TicketHistoryMap());
            modelBuilder.ApplyConfiguration(new TicketMap());
            modelBuilder.ApplyConfiguration(new UsersMap());
            modelBuilder.ApplyConfiguration(new AutoNumberMap());
           
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AutoNumber> AutoNumber { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Firm> Firm { get; set; }
        public DbSet<Priority> Priority { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<TicketHistory> TicketHistory { get; set; }
        public DbSet<TicketType> TicketType { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
