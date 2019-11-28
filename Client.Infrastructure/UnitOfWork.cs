using Client.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private ClientEntities dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public ClientEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }


        public void Commit()
        {
            DbContext.Commit();
        }
    }
}
