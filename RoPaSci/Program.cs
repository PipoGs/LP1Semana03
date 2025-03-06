using System;

namespace RoPaSci
{
    class Program
    {
        private static void Main(string[] args)
        {
            Items player1 = Enum.Parse<Items>(args[0], true);
            Items player2 = Enum.Parse<Items>(args[1], true);

            States result = RockPaperScissors(player1, player2);

            switch (result)
            {
                case States.draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case States.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case States.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static States RockPaperScissors(Items player1, Items player2)
        {
            if (player1 == player2)
            {
                return States.draw; // Draw
            }
            if ((player1 == Items.Rock && player2 == Items.Scissors) ||
                (player1 == Items.Scissors && player2 == Items.Paper) ||
                (player1 == Items.Paper && player2 == Items.Rock))
            {
                return States.Player1Wins; // Player 1 wins
            }
            else
            {
                return States.Player2Wins; // Player 2 wins
            }
        }
    }
}
