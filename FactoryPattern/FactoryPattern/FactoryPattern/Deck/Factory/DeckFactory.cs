using System;
using System.Collections.Generic;
using FactoryPattern.Card.Factory;

namespace FactoryPattern.Deck.Factory
{
    public static class DeckFactory
    {
        private class DefaultDeck : IDeck
        {
            public List<ICard> GetCards()
            {
                return new List<ICard>();
            }
        }
        public static IDeck GetDeck(Decks deck)
        {
            switch (deck)
            {
                case Decks.Bonus1:
                    return new BonusDeck1();
                case Decks.Main:
                    return new MainDeck();
                default:
                    return new DefaultDeck();
            }
        }

        public static bool TryAddToDeck(IDeck deck, IDeck addDeck)
        {
            try
            {
                ((MainDeck)deck).AddToDeck(addDeck);
                return true;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e);
                return false;
            }
        }
    }
}