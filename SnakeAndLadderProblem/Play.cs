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
        int playerPosition = 0;
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
            
            while (playerPosition<Winning_Position)
            {
                int option = random.Next(0, 3);
                switch (option)
                {
                    case No_Play:
                        Console.WriteLine("Player position = Same Position");
                        break;
                    case Ladder:
                        playerPosition += RollingDie();
                        Console.WriteLine("Player Position = " + playerPosition);
                        break;
                    case Snake:
                        int roll = RollingDie();
                        if(playerPosition - roll >0)
                        {
                            playerPosition -= roll;
                        }
                        else
                        {
                            playerPosition = 0;
                        }
                        Console.WriteLine("Player Position = " + playerPosition);
                        break;
                }
                if(playerPosition == Winning_Position)
                {
                    Console.WriteLine("Player Winning Position ----> " + playerPosition);
                    Console.WriteLine("Die Count = "+ count);
                }
            }           
        }
    }
}