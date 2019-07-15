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
        public string name;
        public int allowance;
        public int newAllowance;
        public int expenses;
        public int storeInput;

        //add more as you can think 

        //constructor
        public Player()
        {
            inventory = new Inventory();

        }
    }
}
