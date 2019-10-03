using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public Player player1;
        public List<int> recipes = new List<int>();
        public Store store;
        public Inventory inventory;
        public int lemons { get; set; }
        public int sugar { get; set; }
        public int ice { get; set; }
        public int cups { get; set; }
        public int input;
        public int input1;
        public int input2;
        public int input3;
        public int input4;
        public int price;
        public int id;


        public Recipe(Player player1)
        {
            MakeRecipe(player1);
            DailyRecipe();
            SetPrice();
            int price;
            input1 = cups;
            input2 = ice;
            input3 = lemons;
            input4 = sugar;
            
            //MakeRecipe();
          //Making list to display each item in the recipe to use for in game use as well 
        }

        public void MakeRecipe(Player player1)
        {
            Console.WriteLine("Let's make today's recipe");
            Console.WriteLine("You need to choose how many lemons and cups of sugar to use for the jug, \n" +
                "You also need to choose how many ice cubes per cup as well as how many cups you would like in that day.");
            Console.WriteLine("Today's inventory is: ");
            Console.WriteLine("Sugar: " + player1.inventory.sugar);
            Console.WriteLine("Lemons: " + player1.inventory.lemons);
            Console.WriteLine("Cups: " + player1.inventory.cups);
            Console.WriteLine("Ice:" + player1.inventory.ice);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("How many cups would you like to make?");
            input1 = Convert.ToInt32(Console.ReadLine());
           
            if(input1 > player1.inventory.cups)
            {
                Console.WriteLine("Insufficient supplies, start over");
                MakeRecipe(player1);    
            }
            player1.inventory.cups = (player1.inventory.cups - input1);
           
            Console.WriteLine("How many ice cubes would you like to use per cup?");
            input2 = Convert.ToInt32(Console.ReadLine());
           
            if(input2 > player1.inventory.ice)
            {
                Console.WriteLine("Insufficient supplies, start over");
                MakeRecipe(player1);
            }
            player1.inventory.ice = (player1.inventory.ice - input2);

            Console.WriteLine("How many lemons would you like to use per jug?");
            input3 = Convert.ToInt32(Console.ReadLine());

            if (input3 > player1.inventory.lemons)
            {
                Console.WriteLine("Insufficient supplies, start over");
                MakeRecipe(player1);
            }
            player1.inventory.lemons = (player1.inventory.lemons - input3);

            Console.WriteLine("How many cups of sugar would you like to use per jug?");
            input4 = Convert.ToInt32(Console.ReadLine());
           
            if (input4 > player1.inventory.sugar)
            {
                Console.WriteLine("Insufficient supplies, start over");
                MakeRecipe(player1);
            }
            player1.inventory.sugar = (player1.inventory.sugar - input4);
            DailyRecipe();
        }

        public void SetPrice()
        {
            Console.WriteLine("How many cents would you like to charge per cup? 10, 25, 50, 75 or 100?");
            price = Convert.ToInt32(Console.ReadLine());
        }

        public void DailyRecipe()
        {
            Console.WriteLine(input1 + " cups total of lemonade for the day");
            Console.WriteLine(input2 + " ice cubes per cup");
            Console.WriteLine(input3 + " lemons per jug");
            Console.WriteLine(input4 + " cups of sugar per jug");

            recipes.Add(input2);
            recipes.Add(input3);
            recipes.Add(input4);
        }
    }
}
