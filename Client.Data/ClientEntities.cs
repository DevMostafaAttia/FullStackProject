using Client.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Data
{
    public class ClientEntities : DbContext
    {
        public ClientEntities(DbContextOptions<ClientEntities> options) : base(options) { }//"MaintenanceEntities") { }

        public ClientEntities() { }

        public DbSet<Client.Model.Client> Clients { get; set; }
        public DbSet<Branch> Branches { get; set; }


        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ClientConfiguration());

            ClientSeedData.Seed(modelBuilder);
        }
    }
}
