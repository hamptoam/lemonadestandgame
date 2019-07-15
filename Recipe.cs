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
        public List<string> recipe;
        public int lemons;
        public int sugar;
        public int ice;
        public int input;
        public int price;


        public Recipe(Player player)
        {
            player1 = player;
          //  recipe = MakeRecipe();
          //Making list to display each item in the recipe to use for in game use as well 
        }

        public void MakeRecipe()
        { 
            Console.WriteLine("Let's make today's recipe");
            Console.WriteLine("You need to choose how many lemons and cups of sugar to use for the jug, \n" +
                "You also need to choose how many ice cubes per cup as well as how many cups you would like in that day.");
            Console.WriteLine("Today's inventory is: ");
            Console.WriteLine(player1.inventory.poundsSugar);
            Console.WriteLine(player1.inventory.quantityLemons);
            Console.WriteLine(player1.inventory.quantityCups);
            Console.WriteLine(player1.inventory.iceCubes);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("How many cups would you like to make?");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many ice cubes would you like to use per cup?");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many lemons would you like to use per jug?");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cups of sugar would you like to use per jug?");
            input = Convert.ToInt32(Console.ReadLine());

        }
    }
}
