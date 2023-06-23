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

            
            int ladderPosition;

            int option = random.Next(1,3);

            switch(option)
            {
                case 1: 
                    Console.WriteLine("There will be NoPlay in the Game, Player Stays at Same Position");
                    
                   break;
                case 2:
                    ladderPosition = 65;
                    Console.WriteLine("YAY, The Player just reached to a ladder");
                    playerPosition += ladderPosition;
                    break;
                case 3:
                    ladderPosition = 15;
                    Console.WriteLine("OOPS,The player has been Eaten by a Giant Snake");
                    playerPosition -= ladderPosition;
                    break;
            }
            Console.WriteLine("The Player's Position is : " + playerPosition);
        }
    }
}
