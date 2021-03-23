using GameTop.Lib;

namespace GameTop
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Player("Barnizinho");
						var player2 = new Player("Chuaum");
            var soccerMatch = new Match(player1, player2);
            soccerMatch.StartMatch(); 
        }
    }
}
