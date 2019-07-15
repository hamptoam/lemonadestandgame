using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public Recipe recipe;
        public Day day;
        /*public int supply;
        public string demand;*/

        public Day(Player player)
        {
            weather = new Weather(player);
            recipe = new Recipe(player);

            weather.GetWeather(); 

        } 


    }
}

