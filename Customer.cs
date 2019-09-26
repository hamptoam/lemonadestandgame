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
        public enum recipePreferences
        {






        }
        public Random recipePref(Recipe recipe)
        {
            Random r = new Random();




            int selectedprefference = r.Next(0, 5);


            return r; 


        }
    }
}
    

    



   
