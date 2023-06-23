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
            int playerPosition = 0;
            int diceRoll;
            bool gameCompleted = false;

            while (!gameCompleted)
            {
                Console.WriteLine("Please Press Enter to Start the Game");
                Console.ReadLine();
                Random random = new Random();
                diceRoll = random.Next(1, 7);

                Console.WriteLine("The Dice Rolls is : " + diceRoll);
                playerPosition += diceRoll;

                int ladderPosition;

                if (playerPosition == 100)
                {
                    Console.WriteLine("The Player's Position is : " + playerPosition);
                    Console.WriteLine("Haaleluya.......Player Wins The Game");
                }
                else if (playerPosition > 100)
                {
                    Console.WriteLine("You have Exceeded the Maximum Position, You need to Restart the Game");
                    playerPosition = 0;
                }
                else if (playerPosition < 0)
                {
                    Console.WriteLine("The Player is at Position Zero");
                    playerPosition = 0;
                }
                else
                {
                    Console.WriteLine("Player Position is: " + playerPosition);
                }

                switch (playerPosition)
                {
                    case 1:
                        ladderPosition = 15;
                        Console.WriteLine("OOPS,The player has been Eaten by a Giant Snake");
                        playerPosition -= ladderPosition;
                        Console.WriteLine("Player Position is : " + playerPosition);
                        break;

                    case 2:
                        ladderPosition = 65;
                        Console.WriteLine("YAY, The Player just reached to a ladder");
                        playerPosition += ladderPosition;
                        Console.WriteLine("Player Position is : " + playerPosition);
                        break;
                    case 3:
                        Console.WriteLine("There will be NoPlay in the Game, Player Stays at Same Position");
                        Console.WriteLine("Player Position is : " + playerPosition);
                        break;

                }
            }


        }
    }
}
