using System;
using FactoryPattern.Card.Factory;
using FactoryPattern.Deck.Factory;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IDeck mainDeck = DeckFactory.GetDeck(Decks.Main);
            foreach (ICard card in mainDeck.GetCards())
            {
                Console.WriteLine($"Card {card.GetName()}, score {card.GetScore().ToString()}");
            }
            IDeck bonusDeck = DeckFactory.GetDeck(Decks.Bonus1);
            foreach (ICard card in bonusDeck.GetCards())
            {
                Console.WriteLine($"Card {card.GetName()}, score {card.GetScore().ToString()}");
            }
            DeckFactory.TryAddToDeck(mainDeck,bonusDeck);
            foreach (ICard card in mainDeck.GetCards())
            {
                Console.WriteLine($"Card {card.GetName()}, score {card.GetScore().ToString()}");
            }
            
            Console.ReadLine();
        }
    }
}