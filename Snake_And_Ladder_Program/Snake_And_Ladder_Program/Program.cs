using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_Ladder_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Program");

            //**************************Day-4 Assignment***********************

            Console.WriteLine("Second Usecase for Player at Position One to Six");

            Snake_and_Ladder_Game snake_And_Ladder_Game = new Snake_and_Ladder_Game();
            
            snake_And_Ladder_Game.Game();

            Console.ReadLine();
        }
    }
}
