using Payment_API.Model.Base;
using System;

namespace Payment_API.Model
{
    public class Payment : BaseEntity
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
