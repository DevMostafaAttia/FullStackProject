using Client.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Data
{
    public class ClientSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client.Model.Client>().HasData(
                new Model.Client { ClientId =1, ClientName="Mostafa Attia",ClientEmail ="mattia@eggate.com",Mobile = "+201008346362",Address="5 - 17 paradaise - October Gardens - Giza",WebSite="N.A" },
                new Model.Client { ClientId =2, ClientName="Mahmoud Nagy",ClientEmail ="mnagy@eggate.com",Mobile = "+201119849089",Address="Maadi",WebSite="N.A" },
                new Model.Client { ClientId =3, ClientName="Ahmed Elkady",ClientEmail ="aelkady@eggate.com",Mobile = "+201017413234",Address="6th of October City",WebSite="N.A" }
                );

            modelBuilder.Entity<Branch>().HasData(
                new Branch { BranchId = 1, BranchName = "New Cairo", ManagerName = "Ali", Location = "Elnarges 4, Villa 212", Budget = 120_000_000.00 },
                new Branch { BranchId = 2, BranchName = "Naser City", ManagerName = "Haitham", Location = "Elnozha st, 1 Suadi buildings", Budget = 90_000.00 },
                new Branch { BranchId = 3, BranchName = "Zayed", ManagerName = "Ramy", Location = "District 12", Budget = 6_000_000.00 },
                new Branch { BranchId = 4, BranchName = "October", ManagerName = "Samy", Location = "Elnarges 4, Villa 212", Budget = 30_000_000.00 }
                );
        }
    }
}
