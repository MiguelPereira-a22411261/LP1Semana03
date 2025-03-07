using System;

namespace RoPaSci
{
    class Program
    {
        public enum GameItem
        {
            Rock,
            Paper,
            Scissors
        }

        public enum GameStatus
        {
            Draw,
            Player1Wins,
            Player2Wins
        }
        
        private static void Main(string[] args)
        {
            GameItem player1 = Enum.Parse<GameItem>(args[0]);
            GameItem player2 = Enum.Parse<GameItem>(args[1]);
            GameStatus result = RockPaperScissors(player1, player2);
            
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
            {
                return 0; // Draw
            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                return 1; // Player 1 wins
            }
            else
            {
                return 2; // Player 2 winsRoPa
            }
        }
    }
}
