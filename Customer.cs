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
        public List<string> weather;
        public string weatherPref;
        public List<string> ages; //= new string>();
        public List<string> customers;
        public int age;
        public int price;

        public Customer()
        {
            //new List<string> { "Child", "Teenager", "Adult", "Old" };
            age = GetAge();
         //   weatherPref = GetWeatherPref(); // ask will 
            prices = new int[] { 25, 50, 75, 100, 125 };
            pricemax = GetPrice(); 
            //(keep) prices = GetPrice();
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
            price = pricemax;
            Random r = new Random();
            price = r.Next(0, prices.Length);
            return price;
        }
    }
}


   
