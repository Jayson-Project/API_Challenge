using Payment_API.Model.Base;
using System;

namespace Payment_API.Model
{
    public class Card : BaseEntity
    {
        public long Id_Buyer { get; set; }
        public string Holder_name { get; set; }
        public string Number { get; set; }
        public DateTime Expiration_date { get; set; }
        public int CVV { get; set; }

    }
}
