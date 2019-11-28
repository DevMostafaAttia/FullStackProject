using Client.Infrastructure;
using Client.Infrastructure.Repositories;
using Client.Model;
using Client.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Service
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetBranches();
        Branch GetBranch(int id);
        void DeleteBranch(int id);
        void CreateBranch(Branch assetType);
        void UpdateBranch(Branch assetType);
        void SaveBranch();
    }

    public class BranchService : IBranchService
    {
        private readonly IBranchRepository branchRepository;
        private readonly IUnitOfWork unitOfWork;


        public BranchService(IBranchRepository branchRepository, IUnitOfWork unitOfWork)
        {
            this.branchRepository = branchRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateBranch(Branch branch)
        {
            branchRepository.Add(branch);
        }

        public void DeleteBranch(int id)
        {
            branchRepository.Delete(id);
        }

        public Branch GetBranch(int id)
        {
            return branchRepository.GetById(id);
        }

        public IEnumerable<Branch> GetBranches()
        {
            return branchRepository.GetAll();
        }

        public void SaveBranch()
        {
            unitOfWork.Commit();
        }

        public void UpdateBranch(Branch branch)
        {
            branchRepository.Update(branch);
        }
    }
}
