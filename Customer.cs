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
        public int[] recipepref;
        public Weather weatherpref;
        public int WeatherPref;
        public Player player1;
        public Random r;
        string customerrecipe;

        public Customer()
        {
            age = GetAge();
            pricemax = GetPrice();
            recipepref = recipePref();
            WeatherPref = weatherPref(weatherpref);
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

        public int weatherPref(Weather weather)
        {
            return weather.GetWeather();
        }

        public void getPreferences()
        {
            Recipe recipe = new Recipe(player1);

            for (int i = 0; i < customers.Count; i++)
            {
                customerrecipes.Add("3 ice, 2 lemons, 2 sugars");
                customerrecipes.Add("2 ice, 3 lemons, 6 sugars");
                customerrecipes.Add("1 ice, 1 lemon, 3 sugars");
                customerrecipes.Add("0 ice, 2 lemons, 4 sugars");
                customerrecipes.Add("4 ice, 4 lemons, 8 sugars");

                customerrecipe = customerrecipes.ElementAt(r.Next(0, customerrecipes.Count));

                string[] recipes = Regex.Split(customerrecipe, @"\D+");

                foreach (string value in recipes)
                {
                    int number;
                    if (int.TryParse(value, out number))
                    {
                        Console.WriteLine(value);
                    }
                }

                recipes[0] = recipe.ice.ToString();
                recipes[1] = recipe.lemons.ToString();
                recipes[2] = recipe.sugar.ToString();

                return recipes[];
            }

        }

        //public int recipePref(Customer customer)
        //{
        //    customer = recipeslist.random(id)

        //    Random r = new Random(customer.id);
        //    customer.recipe = recipes
        //    return recipe;
        //}
        //public List<Customer> recipeslist = new List<Customer>()
        //    {
        //         new Customer( 1, 2, 3, 6),
        //         new Customer( 2, 3, 1, 4),
        //         new Customer( 3, 4, 2, 3),
        //         new Customer( 4, 2, 3, 1),
        //         new Customer( 5, 3, 2, 4)

        //    int selectedCustomer = recipeslist.Next()
        //    };
    }
}

    
   
    

    



   
