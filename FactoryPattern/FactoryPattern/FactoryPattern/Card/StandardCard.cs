using FactoryPattern.Card.Factory;

namespace FactoryPattern.Card
{
    internal class StandardCard: ICard
    {
        protected int _score = 0;
        protected string _name = "Standard";

        public StandardCard(int score, string name)
        {
            _score = score;
            _name = name;
        }
        
        public string GetName()
        {
            return _name;
        }

        public int GetScore()
        {
            return CalculateScore();
        }

        private protected virtual int CalculateScore()
        {
            return _score;
        }
    }
}