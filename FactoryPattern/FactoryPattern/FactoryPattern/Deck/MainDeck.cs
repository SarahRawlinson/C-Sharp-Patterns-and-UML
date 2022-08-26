using System.Collections.Generic;
using FactoryPattern.Card.Factory;
using FactoryPattern.Deck.Factory;

namespace FactoryPattern.Deck
{
    internal class MainDeck : IDeck
    {
        
        private List<ICard> _cards = new List<ICard>();
        public MainDeck()
        {
            CreateCards();
        }

        public List<ICard> GetCards()
        {
            return _cards;
        }

        public void AddToDeck(IDeck deck)
        {
            _cards.AddRange(deck.GetCards());
        }
        

        public void CreateCards()
        {
            _cards.Add(CardFactory.GetCard(Cards.Ace));
            _cards.Add(CardFactory.GetCard(Cards.Two));
            _cards.Add(CardFactory.GetCard(Cards.Three));
            _cards.Add(CardFactory.GetCard(Cards.Four));
            _cards.Add(CardFactory.GetCard(Cards.Five));
            _cards.Add(CardFactory.GetCard(Cards.Six));
            _cards.Add(CardFactory.GetCard(Cards.Seven));
            _cards.Add(CardFactory.GetCard(Cards.Eight));
            _cards.Add(CardFactory.GetCard(Cards.Nine));
            _cards.Add(CardFactory.GetCard(Cards.Ten));
            _cards.Add(CardFactory.GetCard(Cards.SpecialWild));
        }
    }
}