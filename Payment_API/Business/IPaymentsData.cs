using Payment_API.Model;
using System.Collections.Generic;

namespace Payment_API.Business
{
    public interface IPaymentsData
    {
        string Create(PaymentsData paymentDados);
        List<Payment> FindAll();
    }
}
