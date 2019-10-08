using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Model
{
    public class MadePayment
    {
        public long Id_Buyer { get; set; }
        public long? Id_Card { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public string Card { get; set; }
        public string Cod_barras { get; set; }
        public string Status { get; set; }
    }
}
