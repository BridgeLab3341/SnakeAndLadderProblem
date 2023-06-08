using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Play
    {
        public void GamePlay()
        {
           const int No_Play = 0, Ladder = 1, Snake = 2;
            int playerPosition = 0;
            Random random = new Random();
            int die=random.Next(1,7);
            //Console.WriteLine("Player Position: {0}",die);
            int option=random.Next(0,3);
            switch(option)
            {
                case No_Play:
                    Console.WriteLine("Player position = Same Position");
                    break;
                case Ladder:
                    playerPosition += die;
                    Console.WriteLine("Player Position = " + playerPosition);
                    break;
                case Snake:
                    playerPosition -= die;
                    Console.WriteLine("Player Position = " + playerPosition);
                    break;
            }
        }
    }
}