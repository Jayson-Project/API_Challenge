using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment_API.Model;
using Payment_API.Repository.Generic;

namespace Payment_API.Business.Implementation
{
    public class BuyerBusinessImpl : IBuyer
    {
        private readonly IRepository<Buyer> _repository;

        public BuyerBusinessImpl(IRepository<Buyer> repository)
        {
            _repository = repository;
        }

        public Buyer Create(Buyer buyer)
        {
            try
            {
                //if (!IsCpf(buyer.CPF))
                //    return new Buyer();

                if (!_repository.Exist(buyer.Id))
                    return _repository.Create(buyer);

                var result = _repository.FindAll().Where(p => p.Id.Equals(buyer.Id)).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Buyer> FindAll()
        {
            try
            {
                return _repository.FindAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
