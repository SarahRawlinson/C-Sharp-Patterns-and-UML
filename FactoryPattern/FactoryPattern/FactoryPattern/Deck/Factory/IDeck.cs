using System.Collections.Generic;
using FactoryPattern.Card.Factory;

namespace FactoryPattern.Deck.Factory
{
    public interface IDeck
    {
        public List<ICard> GetCards();
    }
}