using System;

namespace singleton
{
    class Program
    {
        private static Director _director = Director.GetDirector();
        static void Main(string[] args)
        {
            GameLogData gameLogData = GameLogData.GetLogAsync("Program : Game Log Get Instance").Result;
            Director director = Director.GetDirector();
            for (int i = 0; i < 10; i++)
            {
                gameLogData.PrintToLog($"Program : {director.GetNextPlayer()} takes there turn");
                gameLogData.PrintToLog($"Program : {_director.GetNextPlayer()} takes there turn");
            }
            Console.WriteLine(gameLogData.GetLog());
            Console.ReadLine();
        }
    }
}