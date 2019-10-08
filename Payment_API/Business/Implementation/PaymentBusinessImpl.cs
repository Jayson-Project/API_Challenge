using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment_API.Model;
using Payment_API.Repository.Generic;

namespace Payment_API.Business.Implementation
{
    public class PaymentBusinessImpl : IPayment
    {
        private readonly IRepository<Payment> _repository;

        public PaymentBusinessImpl(IRepository<Payment> repository)
        {
            _repository = repository;
        }

        public Payment Create(Payment payment)
        {
            try
            {
                //if (!IsCpf(Payment.CPF))
                //    return new Payment();

                if (!_repository.Exist(payment.Id))
                    return _repository.Create(payment);

                var result = _repository.FindAll().Where(p => p.Id.Equals(payment.Id)).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Payment> FindAll()
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
