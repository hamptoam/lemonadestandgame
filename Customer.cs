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
        public List<string> prices = new List<string>();
        public List<string> customerrecipes = new List<string>();
        public List<string> ages = new List<string>();
        public List<Customer> customers = new List<Customer>();
        public int age;
        public int price;
        public int id;
        public Recipe recipe;
        public List<int> preferences = new List<int>();
        public Weather weather;
        public int weatherpref;
        public Player player1;
        public Random r = new Random();
        public int ice;
        public int lemons;
        public int sugar;

        public Customer(Weather weather)
        {
            GetAge();
            GetPrice();
            GetPreferences();
        }

        public static int GetAge()
        {
            int[] ages = new int[] { 6, 12, 18, 30, 50 };
            Random ran = new Random();
            int customerages = ages[ran.Next(0, ages.Length)];
            int age = customerages;
            return age;
        }
        public int GetPrice()
        {
            int[] prices = new int[] { 10, 25, 50, 75, 100 };
            Random r = new Random();
            price = r.Next(0, prices.Length);
            int priceMax = price;

            return priceMax;
        }

        public int weatherPref(Weather weather, int weatherpref)
        {
            return weatherpref;
        }

        public void GetPreferences()
        {
            int ice = r.Next(1, 4);
            int lemons = r.Next(1, 4);
            int sugar = r.Next(1, 4);

            preferences.Add(ice);
            preferences.Add(lemons);
            preferences.Add(sugar);
        }
    }
}

    
   
    

    



   
