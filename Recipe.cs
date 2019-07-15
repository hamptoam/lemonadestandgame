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
        public int dailyCups;
        public int input1;
        public int input2;
        public int input3;
        public int input4;
        public int price;
        

        public Recipe(Player player)
        {
            player1 = player;
            input1 = dailyCups;
            input2 = ice;
            input3 = lemons;
            input4 = sugar;
            MakeRecipe();
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
            input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many ice cubes would you like to use per cup?");
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many lemons would you like to use per jug?");
            input3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many cups of sugar would you like to use per jug?");
            input4 = Convert.ToInt32(Console.ReadLine());
        }

        public void DailyRecipe()
        {

            Console.WriteLine(input1 + " cups total of lemonade for the day");
            Console.WriteLine(input2 + " ice cubes per cup");
            Console.WriteLine(input3 + " lemons per jug");
            Console.WriteLine(input4 + " cups of sugar per jug");
        }
        /*public string GameRecipe()
        {
            for (int i = 0; i < daysCounter; i++)
            {
                Day day = new Day();

                List<string> dailyRecipe = new List<string>();


        **I'm thinking maybe call DailyRecipe() for every day in the day or game class 
        * ask will
            }

        } */
    }
}
