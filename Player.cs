using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    { //member variables (What does a player have?
        public Inventory inventory;
        public Recipe recipe;
        public string name;
        public int allowance { get; set; }
        public int storeInput;

        //add more as you can think 

        //constructor
        public Player()
        {
            inventory = new Inventory();
            allowance = 1000;
        }
    }
}
