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
            int playerPosition = 0;
            Random random = new Random();
            int die=random.Next(1,7);
            Console.WriteLine("Player Position: {0}",die);
        }
    }
}