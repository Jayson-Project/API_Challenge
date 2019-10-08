using Payment_API.Model;
using System.Collections.Generic;

namespace Payment_API.Business
{
    public interface IPayment
    {
        Payment Create(Payment payment);
        List<Payment> FindAll();
    }
}
