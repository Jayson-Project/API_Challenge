using System;
using System.Collections.Generic;
using Payment_API.Model;
using Payment_API.Repository.Generic;

namespace Payment_API.Business.Implementation
{
    public class ClientBusinessImpl : IClient
    {
        private readonly IRepository<Client> _repositoryClient;

        public ClientBusinessImpl(IRepository<Client> repository)
        {
            _repositoryClient = repository;
        }

        public Client Create(Client client)
        {
            try
            {
                return _repositoryClient.Create(client);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(long Id)
        {
            try
            {
                _repositoryClient.Delete(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Client> FindAll()
        {
            try
            {
                return _repositoryClient.FindAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client FindById(long Id)
        {
            try
            {
                return _repositoryClient.FindById(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Client Update(Client book)
        {
            try
            {
                return _repositoryClient.Update(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
