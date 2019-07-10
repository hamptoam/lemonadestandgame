using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        //member variables (What does this game have?)
        public Player player1;
        public Store store;
        public string playerchoice;
        public string forecast;
        public int dayCounter;
        public List<Customer> customers;
        public List<Day> days;
        // and dayLimit or seperate function?

        //member construct

        public Game()
        {
            player1 = new Player();
        }

        //member methods

        public void RunGame()
        {
            SetUp();
            for (int i = 0; i < days.Count; i++)
            {
                //print player allowance 
                                // menu - store, recipes

                // sell lemonade: set prices
            }

            player1 = new Player();
            int playerAllowance = player1.playerAllowance();

            Console.WriteLine(playerAllowance);
            Console.Clear();
        }

        public void SetUp()
        {
            ChooseName();
            Console.WriteLine("Hi " + player1.name + " welcome to your lemonade stand!");
            readRules();
            NumberOfDays();
            GetDays();
            GetCustomers();
        }

        public void ChooseName()
        {
            Console.WriteLine("Please enter your name");
            player1.name = Console.ReadLine();

        }

        public void GameMenu()
        {
            Console.WriteLine("Game Menu");
            Console.WriteLine("1 - Store");
            Console.WriteLine("2 - Recipe");
            Console.WriteLine("3 - Forecast");
            Console.WriteLine("4 - Close Menu");
            Console.WriteLine("5 - Close Game");

            var result = Console.ReadLine();
            /*return*/ Convert.ToInt32(result);

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
                    GameMenu();
                }



                if (reviewRules == "n")
                {
                    Console.WriteLine("Cool" + player1.name + " Lets squeeze some damn lemons!");
                    Console.Clear();
                    GameMenu();
                }
            }
        }



        public void GoToStore()
        {
            string yesorNo = Console.ReadLine();

            Console.WriteLine("Would you like to go to the store? y or n");
            Console.ReadLine();

            if (yesorNo == "y")
            {


            }

            else if (yesorNo == "n")
            {


            }
        }
        public void NumberOfDays()
        {
            Console.WriteLine("How many days would you like to play? Min. 7, Max 28.");
            int input = int.Parse(Console.ReadLine());


            if (input < 7)
            {
                Console.WriteLine("You have to play for at least 7 days per game.");
                NumberOfDays();
            }

            else if (input > 28)
            {
                Console.WriteLine("You can only play for 28 days per game.");
                NumberOfDays();
            }

            else
            {
                dayCounter = input;
            }
        }


        public void GetCustomers()
        {
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }

        }

        public void GetDays()
        {
            for (int i = 0; i < dayCounter; i++)
            {
                Day day = new Day();

                days.Add(day);
            }
        }
       
    }
}
    
