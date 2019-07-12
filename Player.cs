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
           //startingAllowance = 500;
           //startingAllowance = playerAllowance();
        }
      /* public int playerAllowance()
        {
            int newAllowance = startingAllowance - expenses;
            Console.WriteLine("Your allowance is " + newAllowance);
            return newAllowance;
        }
        *trying something brb** 
        */


        //member methods 

       // abstract public string chooseOption();


    }
}
