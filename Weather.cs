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
        public string forecast;
        Random patterns;

        public Weather(Player player1)
        {
            patterns = new Random();
            this.player1 = player1;
            weather = GetWeather();
            // forecast = WeeklyForecast();

        }

        public int GetWeather()
        {

            return patterns.Next(0, 5);
        }

        public void WeeklyForecast()
        {
            List<string> Forecasts = new List<string>();

            for (int i = 0; i < 7; i++)
            {

                Day day = new Day(player1);

                List<string> WeatherPatterns = new List<string>();

                WeatherPatterns.Add("Sunny and hot, 80 degrees");
                WeatherPatterns.Add("Sunny and fair, 65 degrees");
                WeatherPatterns.Add("Cloudy and fair, 60 degrees");
                WeatherPatterns.Add("Scattered storms, 75 degrees");
                WeatherPatterns.Add("Cold and rainy, 50 degrees");
                int selectedPattern = patterns.Next(0, 5);

                Forecasts.Add(WeatherPatterns[selectedPattern]);

                Console.WriteLine("Day " + (i + 1) + " ; " + Forecasts[i]);

            }

        }

    }

}



