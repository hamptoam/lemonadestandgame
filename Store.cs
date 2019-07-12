using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        public Player player1;
        public int cost;
        public int input;
        public int total;
        public int newTotal;
        //public string groceries;
        public int sugar;
        public int cups;
        public int lemons;



        public Store()
        {
            Console.WriteLine("Welcome to the store!");
            Console.WriteLine("Here you will buy your sugar, lemons, and cups.");
            Console.WriteLine("Feel free to stop in as often as you would like.");
        }

        public void groceryStore()
        {
            GetSugar();
            GetCups();
            GetLemons();
        }
        public int GetSugar()
        {
            int sugar = player1.storeInput;
            int cost = 50 * sugar;
            //"sugarrrrrr.... in... watrrr..... (Men in Black Reference)
            Console.WriteLine("Sugar is 50 cents a pound.");
            Console.WriteLine("Hint: One pound of sugar is about 2 cups");
            Console.WriteLine("How many cups of sugar would you like?");
            Console.ReadLine();
            Console.WriteLine(cost);
            cost = total;
            return GetSugar();
        }
        public int GetCups()
        {
            int cups = player1.storeInput;
            int cupCost = 10 * cups;
            Console.WriteLine("Cups are 10 cents each.");
            Console.WriteLine("Hint: A jug of lemonade fills about 8 cups");
            Console.WriteLine("How many cups would you like?");
            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine(cupCost);
            total = (cost + cupCost);
            return GetCups();

        }



        public int GetLemons()
        {
            int lemons = player1.storeInput;
            int lemonCost = 10 * lemons;
            Console.WriteLine("Lemons are 5 cents each.");
            Console.WriteLine("Hint: A jug of lemonade has about 3 - 5 lemons");
            Console.WriteLine("How many lemons would you like?");
            Console.ReadLine();

            Console.WriteLine(lemonCost);
            newTotal = (total + lemonCost);
            Console.WriteLine(newTotal);
            return GetLemons();

        }
    }
}