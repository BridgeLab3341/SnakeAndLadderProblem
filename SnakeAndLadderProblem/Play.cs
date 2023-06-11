using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Play
    {
        const int No_Play = 0, Ladder = 1, Snake = 2, Winning_Position = 100;
        int player1Position = 0;
        int player2Position = 0;
        int currentPlayer = 1;
        int count = 0;
        Random random = new Random();

        public int RollingDie()
        {
            int dieNum = random.Next(1, 7);
            count++;
            return dieNum;
        }

        public void GamePlay()
        {
            while (player1Position < Winning_Position && player2Position < Winning_Position)
            {
                int option = random.Next(0, 3);
                int roll = RollingDie();

                switch (option)
                {
                    case No_Play:
                        Console.WriteLine($"Player {currentPlayer} position = Same Position");
                        break;
                    case Ladder:
                        Console.WriteLine($"Player {currentPlayer} got a ladder and rolls again");
                        if (currentPlayer == 1)
                        {
                            player1Position += roll;
                            Console.WriteLine($"Player 1 Position = {player1Position}");
                        }
                        else
                        {
                            player2Position += roll;
                            Console.WriteLine($"Player 2 Position = {player2Position}");
                        }
                        break;
                    case Snake:
                        if (currentPlayer == 1)
                        {
                            if (player1Position - roll > 0)
                                player1Position -= roll;
                            else
                                player1Position = 0;
                            Console.WriteLine($"Player 1 Position = {player1Position}");
                        }
                        else
                        {
                            if (player2Position - roll > 0)
                                player2Position -= roll;
                            else
                                player2Position = 0;
                            Console.WriteLine($"Player 2 Position = {player2Position}");
                        }
                        break;
                }

                if (currentPlayer == 1)
                {
                    if (player1Position == Winning_Position)
                    {
                        Console.WriteLine("Player 1 won the game");
                        Console.WriteLine($"Die Count = {count}");
                        break;
                    }
                    currentPlayer = 2;
                }
                else
                {
                    if (player2Position == Winning_Position)
                    {
                        Console.WriteLine("Player 2 won the game!");
                        Console.WriteLine($"Die Count = {count}");
                        break;
                    }
                    currentPlayer = 1;
                }
            }
        }
    }
}