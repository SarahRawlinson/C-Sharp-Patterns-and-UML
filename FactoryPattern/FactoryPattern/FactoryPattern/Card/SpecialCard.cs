using FactoryPattern.Card.Factory;

namespace FactoryPattern.Card
{
    internal class SpecialCard : ICard
    {
        protected int _score = 0;
        protected string _name = "Special";
        
        public SpecialCard(int score, string name)
        {
            _score = score;
            _name = name;
        }
        
        public string GetName()
        {
            return "Special";
        }

        public int GetScore()
        {
            return _score;
        }
    }
}