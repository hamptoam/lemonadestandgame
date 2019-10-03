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
        public Inventory inventory;
        public int cost { get; set; }
        public int icecost { get; set; }
        public int lemoncost { get; set; }
        public int sugarcost { get; set; }
        public int cupscost { get; set; }
        public int allowance { get; set; }
        public int input;
        public int total;
        public int sugar { get; set; }
        public int cups { get; set; }
        public int lemons { get; set; }
        public int ice { get; set; }
        public Store(Player player1)
        {
            GroceryStore(player1);
            GetSugar(player1);
            GetCups(player1);  
            GetLemons(player1);        
            GetIce(player1);
            CheckOut(player1);
         
        }

        public void GroceryStore(Player player1)
        {
            Console.WriteLine("Welcome to the store!");
            Console.WriteLine("Here you will buy your sugar, lemons, and cups.");
            Console.WriteLine("Feel free to stop in as often as you would like.");
            Console.WriteLine("Your allowance is " + player1.allowance);


            Console.WriteLine("Now let's buy some stuff. Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public int GetSugar(Player player1)
        {
            Console.WriteLine("Sugar is 50 cents a pound.");
            Console.WriteLine("Hint: One pound of sugar is about 2 cups");
            Console.WriteLine("How many pounds of sugar would you like?");

            input = Convert.ToInt32(Console.ReadLine());
            int sugarcount = input;
            int sugarcost = (50 * sugarcount);
            total += sugarcost;
            Console.WriteLine("sugarrrrrr.... in... watrrr..... (Men in Black Reference)");
            Console.WriteLine(sugarcost);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            player1.inventory.sugar += sugarcount;
            return sugarcost;
        }
        public int GetCups(Player player1)
        {
            Console.WriteLine("Cups are 10 cents each.");
            Console.WriteLine("Hint: A jug of lemonade fills about 8 cups");
            Console.WriteLine("How many cups would you like?");

            input = Convert.ToInt32(Console.ReadLine());
            int cupscount = input;
            int cupscost = (10 * cupscount);
            total += cupscost;
            Console.WriteLine(cupscost);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            player1.inventory.cups += cupscount;
            return cupscost;
        }

        public int GetLemons(Player player1)
        {
            Console.WriteLine("Lemons are 5 cents each.");
            Console.WriteLine("Hint: A jug of lemonade has about 3 - 5 lemons");
            Console.WriteLine("How many lemons would you like?");

            input = Convert.ToInt32(Console.ReadLine());

            int lemoncount = input;
            int lemoncost = (5 * lemoncount);
            total += lemoncost;
            Console.WriteLine(lemoncost);  
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            player1.inventory.lemons += lemoncount;
            return lemoncost;
        }

        public int GetIce(Player player1)
        {
            Console.WriteLine("Ice cubes are 1 cent each.");
            Console.WriteLine("Hint: A cup of lemonade has about 3 ice cubes");
            Console.WriteLine("How many ice cubes would you like?");


            input = Convert.ToInt32(Console.ReadLine());
            int icecount = input;
            int icecost = 1 * icecount;
            total += icecost;
            Console.WriteLine(icecost);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            player1.inventory.ice += icecount;

            return icecost;
        }
        public int CheckOut(Player player1)
        {
        
            Console.WriteLine("Thanks for shopping with us!");
            if (total > player1.allowance)
            {
                Console.WriteLine("Insufficient Funds");
                new Store(player1);
            }
            player1.allowance = (player1.allowance - total);
            Console.WriteLine("Your total is " + total);
            Console.WriteLine("Your new allowance is " + player1.allowance);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
            return allowance;

        }
    }
}