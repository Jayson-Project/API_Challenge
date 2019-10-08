using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Model
{
    public class Payment
    {
        public long Id_Client { get; set; }
        public string Name_Buyer { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Card { get; set; }
        public string Holder_name { get; set; }
        public string Number { get; set; }
        public DateTime Expiration_date { get; set; }
        public string CVV { get; set; }
    }
}
