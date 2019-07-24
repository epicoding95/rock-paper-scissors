using System;
using System.Collections.Generic;


namespace RockPaper
{
    public class RockPaperScissors
    {
      
        Random number = new Random();

        public void Play()
        {
            string userInput = correctInput();
            string comInput = computerChoice();

            Console.WriteLine("You chose {0}", userInput);
            Console.WriteLine("The computer chose  {0}", comInput);


           Winner(userInput, comInput);
           Console.ReadLine();
            

        }
        public string correctInput()
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("choose an option rock/paper/scissors----choose with R/P/S:");
                string choice = Console.ReadLine();
               

                if (choice == "R" || choice == "r")
                {
                    return "R";
                }
                else if (choice == "P" || choice == "p")
                {
                    return "P";
                }
                else if (choice == "S" || choice == "s")
                {
                    return "S";
                }
                else
                {
                     return "check your spelling and try again";

                }
            }

        public string computerChoice()
        {
       
       int random = number.Next(1,4);

        if (random == 1)
        {
            return "R";
        }
        else if (random == 2)
        {
            return "P";
        }
        else 
        {
            return "S";
        }

        }

        public string letterToWord(string choice)
        {
            if (choice == "P")
            {
                return "Paper";
            }
            else if (choice == "R")
            {
                return "Rock";

            }
            else 
            {
                return "Scissors";
            }
        }

        public void Winner(string humanInput, string computerInput)
        {
            if((humanInput == "R" && computerInput == "S")|| (humanInput == "S" && computerInput == "P") || (humanInput == "P" && computerInput == "R"))
            {
              string newVariable = ("yes");

                Console.SetCursorPosition((Console.WindowWidth - newVariable.Length) / 2, Console.CursorTop);
                Console.WriteLine(newVariable);
              
            }
            else if((computerInput == "R" && humanInput == "S") || (computerInput == "S" && humanInput == "P") || (computerInput== "P" && humanInput == "R"))
            {

                Console.WriteLine(@"_____.___.              .____                        
\__  |   | ____  __ __  |    |    ____  ______ ____  
 /   |   |/  _ \|  |  \ |    |   /  _ \/  ___// __ \ 
 \____   (  <_> )  |  / |    |__(  <_> )___ \\  ___/ 
 / ______|\____/|____/  |_______ \____/____  >\___  >
 \/                             \/         \/     \/ ");
                
            }
            else
            {
                
                Console.WriteLine(@"                        __  .__        
 ___.__. ____  __ __  _/  |_|__| ____  
<   |  |/  _ \|  |  \ \   __\  |/ __ \ 
 \___  (  <_> )  |  /  |  | |  \  ___/ 
 / ____|\____/|____/   |__| |__|\___  >
 \/                                 \/ ");
               
            }
               Console.WriteLine("would you like to play again?");
               string playAgain = Console.ReadLine();

               if(playAgain == "yes")
               {
                   Play();
               }
               else
               {
                   Console.WriteLine("----------------");
                   Console.WriteLine("GoodBye");
               }
        }
       
    }
    
}