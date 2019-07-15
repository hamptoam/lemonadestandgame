using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather

    {
        public Player player1;
        public int weather;
        public string forecast;

        public Weather(Player player1)
        {

            this.player1 = player1;
            weather = GetWeather();
            forecast = WeeklyForecast();

        }

        public int GetWeather()
        {
            Random patterns = new Random();
            return patterns.Next(0, 4);
        }

        public string WeeklyForecast()
        {

            for (int i = 0; i < 7; i++)
            {

                Day day = new Day();

                List<string> WeatherPatterns = new List<string>();

                WeatherPatterns.Add("Sunny and hot, 80 degrees");
                WeatherPatterns.Add("Sunny and fair, 65 degrees");
                WeatherPatterns.Add("Cloudy and fair, 60 degrees");
                WeatherPatterns.Add("Scattered storms, 75 degrees");
                WeatherPatterns.Add("Cold and rainy, 50 degrees");


            }

            return forecast;
        }

        public string GetWeatherPref()
        {
            // days++;
            int dayWeather = GetWeather();

            Console.WriteLine("The customer prefers");

            if (dayWeather == 0)
            {
                return (" Sunny and hot, 80 degrees");
            }

            else if (dayWeather == 1)
            {
                return (" Sunny and fair, 65 degrees");
            }

            else if (dayWeather == 2)
            {
                return (" Cloudy and fair, 60 degrees");
            }
            else if (dayWeather == 3)
            {
                return (" Scattered storms, 75 degrees");
            }
            else if (dayWeather == 4)
            {
                return (" Cold and rainy, 50 degrees");
            }
            else return "";
        }
    }
}



   

        

    



