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
        
        public Customer(Weather weather)
        {
            //new List<string> { "Child", "Teenager", "Adult", "Old" };
            age = GetAge(); //age groups 
            pricemax = GetPrice(); //pricemax
            WeatherPref(weather);
            //(keep) prices = GetPrice();
         //   recipe = DailyRecipe();
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
        


    public void WeatherPref(Weather weather)
        {
            // days++;
            // GetWeather();
            int dayWeather = weather.GetWeather();

        List<string> customerPref = new List<string>();

            Console.WriteLine("The customer prefers");

            if (dayWeather == 0)
            {
                Console.WriteLine(" Sunny and hot, 80 degrees");
            }

            else if (dayWeather == 1)
            {
                Console.WriteLine(" Sunny and fair, 65 degrees");
            }

            else if (dayWeather == 2)
            {
                Console.WriteLine(" Cloudy and fair, 60 degrees");
            }
            else if (dayWeather == 3)
            {
                Console.WriteLine(" Scattered storms, 75 degrees");
            }
            else if (dayWeather == 4)
            {
                Console.WriteLine(" Cold and rainy, 50 degrees");
            }
            else Console.WriteLine("");
        }
    }
    /*public void recipePref()
    {
        DailyRecipe()
    }
    Get everything else done then worry about recipe 
    */
}
    



   
