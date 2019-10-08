using Payment_API.Model.Base;

namespace Payment_API.Model
{
    public class Buyer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public long Id_Client { get; set; }
        
    }
}
