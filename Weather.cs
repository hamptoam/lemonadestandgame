using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    public class Weather

    {
        public Customer customer;
        public Player player1;
        public int weather;
        public int daysCounter;
        public string forecast;
        Random rand;
        public Dictionary<int, string> WeatherPatterns;
        public string weatherPattern { get; set; }
       
    
    
        public Weather(Player player1)
        {
            int selectedPattern;
            this.player1 = player1;
           // weather = GetWeather();
            // forecast = WeeklyForecast();
        }


        public void WeeklyForecast()
        {
           
            for (int i = 0; i < daysCounter; i++)
            {

                WeatherPatterns.Add(1, "Sunny and hot, 80 degrees");
                WeatherPatterns.Add(2, "Sunny and fair, 65 degrees");
                WeatherPatterns.Add(3, "Cloudy and fair, 60 degrees");
                WeatherPatterns.Add(4, "Scattered storms, 75 degrees");
                WeatherPatterns.Add(5, "Cold and rainy, 50 degrees");

                weatherPattern = WeatherPatterns.ElementAt(rand.Next(0, WeatherPatterns.Count)).Value;

                Console.WriteLine("Day " + (i + 1) + " ; " + weatherPattern);

            }

        }

        //public int GetWeather()
        //{
        //    Console.WriteLine(weatherPattern);

        //    return weatherPattern(key, value);
        //}

    }

}



