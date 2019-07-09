using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {

        public int priceMax;
        public int prices;
        List<string> weatherPrefs;
        public string weatherPref;
        List<string> ages; //= new string>();
        public string age;

        public Customer()
        {
            ages = new List<string> { "Child", "Teenager", "Adult", "Old" };
            age = GetAge();
            weatherPrefs = new List<string> { "Sunny and hot, 80 degrees", "Sunny and fair, 65 degrees", "Cloudy and fair, 60 degrees", "Scattered storms, 75 degrees", "Cold and rainy, 50 degrees" };
            weatherPref = GetWeather();
            priceMax = GetPrice(); //find and fix issue 
           //(keep) prices = GetPrice();
        }


        public string GetAge()
        {
            Random r = new Random();
            int num = r.Next(0, ages.Count);
            return ages[num];
            ;
        }

        public string GetWeather()
        {
            Random r = new Random();
            int num = r.Next(0, weatherPrefs.Count);
            return weatherPrefs[num];
        }

       /* public int GetPrice()
        {
            Random r = new Random();
            int num = Random
        } (keep) */

        private static double RandomNumberBetween(double minValue, double maxValue)
        {
            var next = Random.NextDouble();
            return minValue + (next * (maxValue - minValue));
        }


    }
}
