using Payment_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_API.Business
{
    public interface IClient 
    {
        Client Create(Client client);
        Client Update(Client book);
        void Delete(long Id);
        Client FindById(long Id);
        List<Client> FindAll();
         
    }
}
