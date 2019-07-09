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
        public int dayCounter;
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
            numberofDays();
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
                Console.WriteLine("Alright " + player1.name + ",");
                Console.WriteLine("Your prime directive is to use your knowledge of supply and demand and economics" +
                    " to run your own lemonade stand.");
                Console.WriteLine("You will be provided an initial allowance which you will use to purchase your supplies.");
                Console.WriteLine("Supply and Demand are effected by the weather, so be sure to check the forecast and plan ahead.");
                Console.WriteLine("You will begin to see the relationship between expenses and profits over several 'days'.");
                Console.WriteLine("Are you ready? Type 'boop' to continue.");
                string readyToPlay = Console.ReadLine();

                if (readyToPlay == "boop")
                {
                    Console.WriteLine("Cool " + player1.name + " Let's squeeze some damn lemons!");
                    Console.Clear();
                }



                if (reviewRules == "n")
                {
                    Console.WriteLine("Cool" + player1.name + " Lets squeeze some damn lemons!");
                    Console.Clear();
                }
            }
        }
        public void numberofDays()
        {
            Console.WriteLine("How many days would you like to play? Min. 7, Max 28.");
            int input = int.Parse(Console.ReadLine());


            if (input < 7)
            {
                Console.WriteLine("You have to play for at least 7 days per game.");
                numberofDays();
            }

            else if (input > 28)
            {
                Console.WriteLine("You can only play for 28 days per game.");
                numberofDays();
            }
            else
            {
                dayCounter = input; 
            }
        }
    }
}