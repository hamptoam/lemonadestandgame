using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables (What does this game have?)
        public Player player1;
        public string playerchoice;
        public string forecast;
        public string dayCounter;
        // and dayLimit or seperate function?

        //member construct

        public Game()
        {
            player1 = new Player();
        }

        //member methods

        public void RunGame()
        {
            ChooseName();
            Console.WriteLine("Hi " + player1.name + " welcome to your lemonade stand!");
            readRules();
        }

        public void ChooseName()
        {
            Console.WriteLine("Please enter your name");
            player1.name = Console.ReadLine();


        }

        public void readRules()
        {
            Console.WriteLine("Would you like to review the rules? y or n.");
            string reviewRules = Console.ReadLine();

            if (reviewRules == "y")
            {
                Console.WriteLine("Alright " + player1.name + " your prime directive is to use your knowledge of supply and demand and economics" +
                    " to run your own lemonade stand.");
                
                  
            }

            if (reviewRules == "n")
            {
                Console.WriteLine("Cool" + player1.name + " Lets squeeze some damn lemons!");
            }
        }
    }
}