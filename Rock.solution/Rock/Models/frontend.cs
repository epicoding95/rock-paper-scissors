using System;
using System.Collections.Generic;
using RockPaper;


namespace frontend
{
    public class program
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            RockPaperScissors game = new RockPaperScissors();
            Console.WriteLine("Would you like to play rock-paper-scissors?");
            string userPlay = Console.ReadLine();

            if(userPlay == "yes")
            {
                game.Play();
            }
            else
            {
                Console.WriteLine("ok fuck off");
            }



          

          
        }
    }
}