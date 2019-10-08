using Payment_API.Model.Base;

namespace Payment_API.Model
{
    public class Client : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
