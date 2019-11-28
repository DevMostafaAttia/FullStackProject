using System;
using System.Collections.Generic;
using System.Text;
using Client.Data;

namespace Client.Infrastructure.Repositories
{
    public interface IClientRepository : IRepository<Client.Model.Client>
    {

    }
    public class ClientRepository : RepositoryBase<Client.Model.Client>, IClientRepository
    {
        public ClientRepository(ClientEntities _dataContext) : base(_dataContext)
        {
        }
    }
}
