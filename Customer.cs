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
        public int age;

        public Customer()
        {
             //new List<string> { "Child", "Teenager", "Adult", "Old" };
           age = GetAge();
           weatherPrefs = new List<string> { "Sunny and hot, 80 degrees", "Sunny and fair, 65 degrees", "Cloudy and fair, 60 degrees", "Scattered storms, 75 degrees", "Cold and rainy, 50 degrees" };
           weatherPref = GetWeather();
           priceMax = GetPrice(); //find and fix issue 
                                   //(keep) prices = GetPrice();
        }


        public static int GetAge()
        {
            int[] ages = new int[] { 6, 12, 18, 30, 50 };
            Random ran = new Random();
            int customerages = ages[ran.Next(0, ages.Length)];
            return customerages;
        }

        public string GetWeather()
        {
            Random r = new Random();
            int num = r.Next(0, weatherPrefs.Count);
            return weatherPrefs[num];
        }

        public static int GetPrice()
        {
            int[] prices = new int[] { 25, 50, 75, 100, 125 };
            Random ran = new Random();
            int supplyPrices = prices[ran.Next(0, prices.Length)];
            return supplyPrices;
        }
     
    }
}

   
