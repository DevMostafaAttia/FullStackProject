using System;
using System.Collections.Generic;
using System.Text;
using Client.Infrastructure;
using Client.Infrastructure.Repositories;
using Client.Model;

namespace Client.Service
{
    public interface IClientService
    {
        IEnumerable<Client.Model.Client> GetClients();
        Model.Client GetClient(int id);
        void DeleteClient(int id);
        void CreateClient(Model.Client assetType);
        void UpdateClient(Model.Client assetType);
        void SaveClient();
    }

    public class ClientService : IClientService
    {
        private readonly IClientRepository ClientRepository;
        private readonly IUnitOfWork unitOfWork;


        public ClientService(IClientRepository clientRepository, IUnitOfWork unitOfWork)
        {
            this.ClientRepository = clientRepository;
            this.unitOfWork = unitOfWork;
        }

        public void CreateClient(Model.Client client)
        {
            ClientRepository.Add(client);
        }

        public void DeleteClient(int id)
        {
            ClientRepository.Delete(id);
        }

        public Model.Client GetClient(int id)
        {
            return ClientRepository.GetById(id);
        }

        public IEnumerable<Model.Client> GetClients()
        {
            return ClientRepository.GetAll();
        }
        public void UpdateClient(Model.Client client)
        {
            ClientRepository.Update(client);
        }

        public void SaveClient()
        {
            unitOfWork.Commit();
        }

    }
}
