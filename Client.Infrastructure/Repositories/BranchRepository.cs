using Client.Data;
using Client.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Infrastructure.Repositories
{
    public interface IBranchRepository :IRepository<Branch>
    {

    }

    public class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
        public BranchRepository(ClientEntities _dataContext) : base(_dataContext)
        {
        }
    }
}
