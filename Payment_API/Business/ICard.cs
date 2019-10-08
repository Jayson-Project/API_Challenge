using Payment_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment_API.Business
{
    public interface ICard
    {
        Card Create(Card card);
        List<Card> FindAll();
    }
}
