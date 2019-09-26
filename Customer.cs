using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {

        public int pricemax;
        public int[] prices;
        public List<string> ages; //= new string>();
        public List<string> customers;
        public int age;
        public int price;
        public Recipe recipe;
        public int weatherpref;
        public int recipepref;

        public Customer()
        {
            age = GetAge();
            pricemax = GetPrice();
            recipepref = recipePref();

        }
        public static int GetAge()
        {
            int[] ages = new int[] { 6, 12, 18, 30, 50 };
            Random ran = new Random();
            int customerages = ages[ran.Next(0, ages.Length)];
            return customerages;
        }
        public int GetPrice()
        {
            int[] prices = new int[] { 10, 25, 50, 75, 100 };
            Random r = new Random();
            price = r.Next(0, prices.Length);
            return price;
        }
        public int WeatherPref(Weather weather)
        {
            weather.GetWeather();

            foreach (var Customer in customers)
            {
                if (weather.weather == 0)
                {
                    Console.WriteLine(" Sunny and hot, 80 degrees");
                }
                else if (weather.weather == 1)
                {
                    Console.WriteLine(" Sunny and fair, 65 degrees");
                    return weather.weather;
                }
                else if (weather.weather == 2)
                {
                    Console.WriteLine(" Cloudy and fair, 60 degrees");
                    return weather.weather;
                }
                else if (weather.weather == 3)
                {
                    Console.WriteLine(" Scattered storms, 75 degrees");
                    return weather.weather;
                }
                else if (weather.weather == 4)
                {
                    Console.WriteLine("Cold and rainy, 50 degrees");
                    return weather.weather;
                }
                else Console.WriteLine("");
                return weather.weather;
            }

            return weather.weather;
        }



        public void recipePref(Recipe recipe)
        {
            Random r = new Random();
            Player player1 = new Player();
             
        }
            public List<Recipe> recipeslist = new List<Recipe>()
            {
                 new Recipe(1, 2, 3, 6),
                 new Recipe(2, 3, 1, 4),
                 new Recipe(3, 4, 2, 3),
                 new Recipe(4, 2, 3, 1),
                 new Recipe(5, 3, 2, 4)
            };
    }
}
    
   
    

    



   
