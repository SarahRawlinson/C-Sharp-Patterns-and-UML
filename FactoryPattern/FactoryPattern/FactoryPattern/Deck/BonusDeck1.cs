using System.Collections.Generic;
using FactoryPattern.Card.Factory;
using FactoryPattern.Deck.Factory;

namespace FactoryPattern.Deck
{
    internal class BonusDeck1 : IDeck
    {
        private List<ICard> _cards = new List<ICard>();
        
        public BonusDeck1()
        {
            CreateCards();
        }

        private void CreateCards()
        {
            _cards.Add(CardFactory.GetCard(Cards.SpecialTwo));
            _cards.Add(CardFactory.GetCard(Cards.SpecialThree));
        }

        public List<ICard> GetCards()
        {
            return _cards;
        }
    }
}