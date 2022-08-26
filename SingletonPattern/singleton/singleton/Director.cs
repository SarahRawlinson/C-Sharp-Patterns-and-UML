using System;
using System.Collections.Generic;

namespace singleton
{
    public class Director
    {
        private static readonly Director _instance = new Director();
        GameLogData _gameLogData = GameLogData.GetLogAsync("Director: Game Log Get Instance").Result;
        private List<string> playersNames = new List<string>();
        private int playerIndex = 0;
        private Director()
        {
            GameLogData gameLogData = GameLogData.GetLogAsync("Director: Game Log Get Instance").Result;
            gameLogData.PrintToLog("Director: Created director instance");
            playersNames.Add("player 1");
            gameLogData.PrintToLog("Director: created player 1");
            playersNames.Add("player 2");
            gameLogData.PrintToLog("Director: created player 2");
            playersNames.Add("player 3");
            gameLogData.PrintToLog("Director: created player 3");
            playersNames.Add("player 4");
            gameLogData.PrintToLog("Director: created player 4");
        }

        public static Director GetDirector()
        {
            GameLogData.GetLogAsync("Director: Get Director");
            return _instance;
        }
        public string GetNextPlayer()
        {
            string output = playersNames[playerIndex];
            playerIndex++;
            playerIndex = playerIndex >= playersNames.Count ? 0 : playerIndex;
            _gameLogData.PrintToLog($"Director: {output} is up, {playersNames[playerIndex]} is next");
            return output;
        }
    }
}