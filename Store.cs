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
        public int ice;



        public Store(Player player1)
        {
            this.player1 = player1;
            sugar = GetSugar();
            lemons = GetLemons();
            cups = GetCups();
            ice = GetIce();


        }

       

        public void groceryStore()
        { int newTotal = 0;

            Console.WriteLine("Welcome to the store!");
            Console.WriteLine("Here you will buy your sugar, lemons, and cups.");
            Console.WriteLine("Feel free to stop in as often as you would like.");
            Console.WriteLine("Now let's buy some stuff");
            newTotal += GetSugar();
            Console.WriteLine(newTotal);
            newTotal += GetCups();
            Console.WriteLine(newTotal);
            newTotal += GetLemons();
            Console.WriteLine(newTotal);
            Console.WriteLine(cost);
            Console.WriteLine(player1.allowance - cost);
        }
        public int GetSugar()
        {
            Console.WriteLine("Sugar is 50 cents a pound.");
            Console.WriteLine("Hint: One pound of sugar is about 2 cups");
            Console.WriteLine("How many cups of sugar would you like?");

            input = Convert.ToInt32(Console.ReadLine());
            int sugar = input;
            int cost = 50 * sugar;
            //"sugarrrrrr.... in... watrrr..... (Men in Black Reference)
            
         
            Console.WriteLine(cost);
            cost = total;
            player1.inventory.AddSugar(sugar);
            return sugar;
            
            
        }
        public int GetCups()
        {
            Console.WriteLine("Cups are 10 cents each.");
            Console.WriteLine("Hint: A jug of lemonade fills about 8 cups");
            Console.WriteLine("How many cups would you like?");

            input = Convert.ToInt32(Console.ReadLine());
            int cups = input;
            int cupCost = 10 * cups;
          
           
            Console.WriteLine(cupCost);
            player1.inventory.AddCups(cups);
            return cups;
        }

        public int GetLemons()
        {
            Console.WriteLine("Lemons are 5 cents each.");
            Console.WriteLine("Hint: A jug of lemonade has about 3 - 5 lemons");
            Console.WriteLine("How many lemons would you like?");

            input = Convert.ToInt32(Console.ReadLine());
            int lemons = input;
            int lemonCost = 5 * lemons;


            Console.WriteLine(lemonCost);
            player1.inventory.AddLemons(lemons);
            return lemons;
        }

        public int GetIce()
        {
            Console.WriteLine("Ice cubes are 1 cent each.");
            Console.WriteLine("Hint: A cup of lemonade has about 3 ice cubes");
            Console.WriteLine("How many ice cubes would you like?");


            input = Convert.ToInt32(Console.ReadLine());
            int icecube = input;
            int iceCost = 1 * icecube;

            Console.WriteLine(iceCost);
            player1.inventory.AddIce(icecube);
            return ice;
        }
    }
}