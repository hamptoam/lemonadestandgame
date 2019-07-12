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
        public List<string> prices;
        public List<string> weather;
        public string weatherPref;
        public List<string> ages; //= new string>();
        public List<string> customers;
        public int age;

        public Customer()
        {
             //new List<string> { "Child", "Teenager", "Adult", "Old" };
           age = GetAge();
           weatherPref = GetWeather();
          // priceMax = GetPrice(); //find and fix issue 
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
            int num = r.Next(0, weather.Count);
            return weather[num];
        }

      //  public static int GetPrice()
        //{
          //  public int[] Prices = new int[] { 25, 50, 75, 100, 125 };
            //Random r = new Random();
            //int prices  = r.Next(0, Prices.count);
            
        // YOU WILL FIGURE OUT THE PRICES}
     
    }
}

   
