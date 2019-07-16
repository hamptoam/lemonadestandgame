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
        public Weather weather;
        public Day day;
        public Recipe recipe;
        public string playerchoice;
        public string forecast;
        public int daysCounter;
        public List<Customer> customers;
        public List<Day> days;
        //public Customer pricemax; 
        public int allowance;
        public int expenses;
        // and dayLimit or seperate function?

        //member construct

        public Game()
        {
            player1 = new Player();
            customers = new List<Customer>();
        }

        //member methods

        public void RunGame()
        {
            SetUp();
            for (int i = 0; i < daysCounter; i++)
            {
                playerAllowance(); //print player allowance 
                GameMenu(); // menu - store, recipes

                // sell lemonade: set prices
            }


        }

        public void SetUp()
        {
            ChooseName();
            Console.WriteLine("Hi " + player1.name + " welcome to your lemonade stand!");
            readRules();
            NumberOfDays();
            GetDays(); //
            GetCustomers();
        }

        public void ChooseName()
        {
            Console.WriteLine("Please enter your name");
            player1.name = Console.ReadLine();

        }

        public void GameMenu()
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Your allowance is ");
            Console.WriteLine(playerAllowance());
            Console.WriteLine("1 - Go to Store");
            // when you get back tie the store to this, and 
            //tie everything together to form the days 
            Console.WriteLine("2 -Change Recipe");
            recipe.MakeRecipe();
            Console.WriteLine("3 - Check Forecast");
            Console.WriteLine("4 - Go to Game");



            var result = Console.ReadLine();
            /*return*/
            Convert.ToInt32(result);

            if (result == "1")
            {

                Store store = new Store(player1);
                store.groceryStore();
            }
            else if (result == "2")
            {
                Recipe recipe = new Recipe(player1);
                // create recipe method and plant here 
            }
            else if (result == "3")
            {
                Weather weather = new Weather(player1);
                weather.WeeklyForecast();

            }
            else if (result == "4")
            {
                // run game 

            }

            Console.WriteLine("Are you ready? Type 'boop' to continue.");
            string readyToPlay = Console.ReadLine();
            Console.Clear();
        }
        public int playerAllowance()
        {
            allowance = 1000;

            int newAllowance = allowance - expenses;
            return newAllowance;
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
                    //  GameMenu()
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
                input = daysCounter;
                GameMenu();
            }
        }

        /* public List<string> ListDays()
         {
             for (int i = 0; i < 100; i++)
             {
                 Day day = new Day();

             }
         } Finish list of strings */

        public void GetCustomers()
        {

            for (int i = 0; i < 50; i++)
            {
                //  Customer customer = new Customer();

                customers.Add(new Customer(weather));
                //  makeCustomers.Add(WeatherPref);
                // Already gave it a value customer.pricemax.Add(); //dont know why this isnt 
           //     if (weatherPref.selectedPattern = ("Sunny and hot, 80 degrees")
            }
        }             //Hi Nevin, biggest thing I have to finish is putting together the customer preferences ^^ and setting up adding and subtracting from
        //the allowance and tying everything together

        public void GetDays()
        {

            for (int i = 0; i < daysCounter; i++)
            {
                Day day = new Day(player1);
                days.Add(day);


                //daysCounter++;


            }

        }

    }

}
   
