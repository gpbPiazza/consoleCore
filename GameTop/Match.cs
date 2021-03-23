using System;
using GameTop.Interface;

namespace GameTop
{
    public class Match
    {
        private readonly IPlayer _player1;
				private readonly IPlayer _player2;
        public Match(IPlayer player1, IPlayer player2) 
        {
            _player1 = player1;
						_player2 = player2;
        }
        public void StartMatch()
        {
            Console.WriteLine(_player1.Kick());
            Console.WriteLine(_player1.Pass());
            Console.WriteLine(_player1.Run());

						Console.WriteLine("==========\n");

						Console.WriteLine(_player2.Kick());
            Console.WriteLine(_player2.Pass());
            Console.WriteLine(_player2.Run());
        }
    }
}