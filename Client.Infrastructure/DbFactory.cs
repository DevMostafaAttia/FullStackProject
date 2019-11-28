using Client.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        ClientEntities dbContext;
        public ClientEntities Init()
        {

            var options = new DbContextOptions<ClientEntities>();
            //options.UseSqlServer("data source=.;initial catalog=MAINTENANCE;integrated security=True;MultipleActiveResultSets=True;", providerOptions => providerOptions.CommandTimeout(60))
            //       .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            return dbContext ?? (dbContext = new ClientEntities(options));
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
