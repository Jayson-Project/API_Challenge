using System;

namespace Payment_API.Model
{
    public class PaymentsData
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
