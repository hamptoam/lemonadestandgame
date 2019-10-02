using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LemonadeStand
{
    public class Customer
    {

        public int pricemax;
        public List<string> prices;
        public List<string> customerrecipes;
        public List<string> ages;
        public List<string> customers;
        public int age;
        public int price;
        public int id;
        public Recipe recipe;
        public int[] customerrecipe;
        public Weather weather;
        public int weatherpref;
        public Player player1;
        public Random r;
        public int ice;
        public int lemons;
        public int sugar;

        public Customer()
        {
            age = GetAge();
            pricemax = GetPrice();
            getPreferences();
            weatherPref(weather, weatherpref);
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

        public int weatherPref(Weather weather, int weatherpref)
        {
            return weatherpref;
        }

        public (int ice, int lemons, int sugar) getPreferences()
        {
            int ice = r.Next(1, 4);
            int lemons = r.Next(1, 4);
            int sugar = r.Next(1, 4);

            return (ice, lemons, sugar);
        }

    }
}

    
   
    

    



   
