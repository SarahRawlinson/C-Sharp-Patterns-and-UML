using System.Threading.Tasks;

namespace singleton
{
    public class GameLogData
    {
        private string Log = "";

        private GameLogData()
        {
            
        }

        private static readonly GameLogData _instance = new GameLogData();

        public static Task<GameLogData> GetLogAsync(string s)
        {
            GameLogData game = _instance;
            _instance.PrintToLog($"{{Async}}: {s}");
            return Task.FromResult(game);
        }
        public void PrintToLog(string log)
        {
            Log += $"Log Print: {log}\n";
        }

        public string GetLog()
        {
            return Log;
        }
    }
}