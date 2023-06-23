using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Program
{
    public class Snake_and_Ladder_Game
    {
        public void Game()
        {
            Console.WriteLine("Please Press Enter to Start the Game");
            Console.ReadLine();

            int playerPosition = 0;
            Random random = new Random();
            int diceRoll = random.Next(1, 7);
            if(diceRoll > 0)
            {
                Console.WriteLine("The Dice Rolls is : " + diceRoll);
                playerPosition += diceRoll;
            }
            else
            {
                Console.WriteLine("There is NoPlay, Please Roll the Dice Again");
            }

            Console.WriteLine("The Player's Position is : "+ playerPosition);
        }
    }
}
