using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather

    {

        public int WeeklyForecast()
        {
             int GetWeather(int min, int max)
            {
                Random patterns = new Random();
                return patterns.Next(min, max);
            }
            List<string> WeatherPatterns = new List<string>();
            
                WeatherPatterns.Add("Sunny and hot, 80 degrees");
                WeatherPatterns.Add("Sunny and fair, 65 degrees");
                WeatherPatterns.Add("Cloudy and fair, 60 degrees");
                WeatherPatterns.Add("Scattered storms, 75 degrees");
                WeatherPatterns.Add("Cold and rainy, 50 degrees");
            
            for (int i = 0; i < 7; i++)
            {

            }

        }

        
    }
    //Figure out these errors as well over weekend 
}
        

    



