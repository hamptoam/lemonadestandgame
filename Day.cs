using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Player player1;
        public Weather weather;
        public Inventory inventory;
        public Recipe recipe;
        public Store store;
        public Game game;
        public Day day;
        public int daysCounter;
        public int dailyCups;
        public List<Customer> customers = new List<Customer>();

        public Day(Player player1)
        {
            Store store = new Store(player1);
            Recipe recipe = new Recipe(player1);
            Weather weather = new Weather(player1);
            List<Customer> customers;
            GetCustomers();
            willBuy(player1, recipe, weather, store);
            endDay(player1);

        }

        public void endDay(Player player1)
        {
            if (customers.Count == 50 || player1.inventory.cups == 0 || player1.inventory.ice == 0 || player1.inventory.sugar == 0 || player1.inventory.lemons == 0)
            {
                Console.WriteLine("The day is over");
                Console.WriteLine("Your new allowance is " + player1.allowance);
                Console.Clear();
                new Day(player1);
            }
            if(player1.allowance == 0)
            {

                game.EndGame();
            }
        }

        public void GetCustomers()
        {
            for (int i = 0; i < 50; i++)
            {
                Customer customer = new Customer(weather);
                customers.Add(customer);
            }
        }

        public bool willBuy(Player player1, Recipe recipe, Weather weather, Store store)
        {
            foreach (var customer in customers)
            {
                if (customer.pricemax == recipe.price || weather.weatherpref == weather.pattern || customer.preferences == recipe.recipes || customer.age < 30)
                {
                    player1.allowance += (player1.allowance + recipe.price);
                    return true;
                }

                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}

   



