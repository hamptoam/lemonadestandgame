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
        public List<Day> days;
        //public Customer pricemax; 
        public int allowance;
        public int expenses;
        // and dayLimit or seperate function?

        //member construct

        public Game()
        {
            player1 = new Player();
            RunGame();
        }

        //member methods

        public void RunGame()
        {
            SetUp();
            for (int i = 0; i < daysCounter; i++)
            {
                Day day = new Day(player1);
                days.Add(day);
               
            }
            if (days.Count == daysCounter)
            {
                EndGame();
            }
        }

        public void SetUp()
        {
            ChooseName();
            Console.WriteLine("Hi " + player1.name + " welcome to your lemonade stand!");
            readRules();
            NumberOfDays();
        }
        public void ChooseName()
        {
            Console.WriteLine("Please enter your name");
            player1.name = Console.ReadLine();

        }

        public void GameMenu(Player player1)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Your allowance is ");
            Console.WriteLine(player1.allowance);
            Console.WriteLine("1 - Go to Store");
            Console.WriteLine("2 -Change Recipe");
            Console.WriteLine("3 - Check Forecast");
            Console.WriteLine("4 - Go to Game");
            Console.WriteLine("5- End Game");

            var result = Console.ReadLine();
            /*return*/
            Convert.ToInt32(result);

            if (result == "1")
            {

                Store store = new Store(player1);
                store.GroceryStore(player1);
            }
            else if (result == "2")
            {
                Recipe recipe = new Recipe(player1);
                recipe.MakeRecipe(player1);
            }
            else if (result == "3")
            {
                Weather weather = new Weather(player1);
                weather.WeeklyForecast();

            }
            else if (result == "4")
            {
                RunGame();

            }
            else if(result == "5")
            {
                EndGame();
            }

            Console.WriteLine("Are you ready? Type 'boop' to continue.");
            string readyToPlay = Console.ReadLine();
            Console.Clear();
        }
        public int playerAllowance()
        {
            int allowance = player1.allowance - expenses;
            return allowance;
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
                    GameMenu(player1);
                }



                if (reviewRules == "n")
                {
                    Console.WriteLine("Cool" + player1.name + " Lets squeeze some damn lemons!");
                    Console.Clear();
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
                Store store = new Store(player1);
            }

            else if (yesorNo == "n")
            {
                GameMenu(player1);
            }
        }
        public int NumberOfDays()
        {

            Console.WriteLine("How many days would you like to play? Min. 7, Max 28.");
            string input = Console.ReadLine();
            daysCounter = Convert.ToInt32(input);

            if (daysCounter < 7)
            {
                Console.WriteLine("You have to play for at least 7 days per game.");
                NumberOfDays();
            }

            else if (daysCounter > 28)
            {
                Console.WriteLine("You can only play for 28 days per game.");
                NumberOfDays();
            }

            Console.WriteLine("Okay! You are playing for " + daysCounter + " days. Goodluck!");
 
            return daysCounter;
        }

        public void EndGame()
        {
            Console.WriteLine("Game is over, thanks for playing!");
            Console.WriteLine("Play again? yes or no");
            string input = Console.ReadLine().ToLower();
            {
                if (input == "yes")
                {
                    RunGame();
                }

                if (input == "no")
                {
                   Console.WriteLine("Thanks for playing, please close window");
                }
            }
        }
    }
}
   
