using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Payment_API.Model;
using Payment_API.Repository.Generic;

namespace Payment_API.Business.Implementation
{
    public class CardBusinessImpl : ICard
    {
        private readonly IRepository<Card> _repository;

        public CardBusinessImpl(IRepository<Card> repository)
        {
            _repository = repository;
        }

        public Card Create(Card card)
        {
            try
            {
                //if (!IsCpf(Card.CPF))
                //    return new Card();

                if (!_repository.Exist(card.Id))
                    return _repository.Create(card);

                var result = _repository.FindAll().Where(p => p.Id.Equals(card.Id)).FirstOrDefault();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Card> FindAll()
        {
            try
            {
                return _repository.FindAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
