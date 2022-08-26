using System.Collections.Generic;

namespace FactoryPattern.Card.Factory
{
    public static class CardFactory
    {
        private class Ace : StandardCard
        {
            public Ace() : base(10, "Ace")
            {
            }

            private protected override int CalculateScore()
            {
                return 100;
            }
        }

        public static ICard GetCard(Cards reference)
        {
            switch (reference)
            {
               case Cards.Ace:
                   return new Ace();
               case Cards.Two:
                   return new StandardCard(2, "two");
               case Cards.Three:
                   return new StandardCard(3, "three");
               case Cards.Four:
                   return new StandardCard(4, "four");
               case Cards.Five:
                   return new StandardCard(5, "five");
               case Cards.Six:
                   return new StandardCard(6, "six");
               case Cards.Seven:
                   return new StandardCard(7, "seven");
               case Cards.Eight:
                   return new StandardCard(8, "eight");
               case Cards.Nine:
                   return new StandardCard(9, "nine");
               case Cards.Ten:
                   return new StandardCard(10, "ten");
               case Cards.SpecialWild:
                   return new SpecialCard(0, "Wild");
               case Cards.SpecialTwo:
                   return new SpecialCard(2, "two");
               case Cards.SpecialThree:
                   return new SpecialCard(3, "three");
               default:
                   return new StandardCard(0, "Error");
                   
            }
        }
    }
}