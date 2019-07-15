using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int poundsSugar;
        public int quantityLemons;
        public int quantityCups;
        public int iceCubes;
        public Store store;

        public Inventory()

        {   store = new Store();
            poundsSugar = 0;
            quantityLemons = 0;
            quantityCups = 0;
            iceCubes = 0;

        }

        public void AddSugar(int amount)
        {
            poundsSugar += amount; 
        }

        public void AddCups(int amount)
        {
            quantityCups += amount;
        }

        public void AddLemons(int amount)
        {
            quantityLemons += amount;
        }

        public void AddIce(int amount)
        {
            iceCubes += amount;
        }

    }
}
