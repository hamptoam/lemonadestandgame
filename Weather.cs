using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace LemonadeStand
{
    public class Weather
    {
        public Player player1;
        public Random rand = new Random();
        public Dictionary<int, string> WeatherPatterns = new Dictionary<int, string>();
        public List<Customer> customers;
        public int weather;
        public int daysCounter;
        public string forecast;
        public int pattern;

        public int weatherpref { get; set; }
        public string weatherPattern { get; set; }




        public Weather(Player player1)
        {
            this.player1 = player1;
            GetWeather();
            WeeklyForecast();
        }

        public void WeeklyForecast()
        {
            for (int i = 0; i < daysCounter; i++)
            {
                weatherPattern = WeatherPatterns.ElementAt(rand.Next(0, WeatherPatterns.Count)).Value;
               
                Console.WriteLine("Day " + (i + 1) + " ; " + weatherPattern);
            }
        }

        public int CustomerWeather()
        {
           string weatherpref = WeatherPatterns.ElementAt(rand.Next(0, WeatherPatterns.Count)).Value;

           string[] key = Regex.Split(weatherpref, @"\D+");

           int customerpref = Convert.ToInt32(key);

           return customerpref;
        }


        public void GetWeather()
        {
            WeatherPatterns.Add(1, "Sunny and hot, 80 degrees");
            WeatherPatterns.Add(2, "Sunny and fair, 65 degrees");
            WeatherPatterns.Add(3, "Cloudy and fair, 60 degrees");
            WeatherPatterns.Add(4, "Scattered storms, 75 degrees");
            WeatherPatterns.Add(5, "Cold and rainy, 50 degrees");

            weatherPattern = WeatherPatterns.ElementAt(rand.Next(0, WeatherPatterns.Count)).Value;

            Console.WriteLine(weatherPattern);
        }
    }
}




