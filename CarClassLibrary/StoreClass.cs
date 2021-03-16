using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class StoreClass
    {
        public List<CarClass> CarList { get; set; }
        public List<CarClass> ShoppingList { get; set; }

        public StoreClass()
        {
            CarList = new List<CarClass>();
            ShoppingList = new List<CarClass>();
        }

        public decimal Checkout()
        {
            //initialise the total cost at checkout
            decimal totalCost = 0;

            //get the cost of shopping list
            foreach(var c in ShoppingList)
            {
                totalCost += c.Price;
            }
            //empty the shopping list
            ShoppingList.Clear();

            //return the total
            return totalCost;
        }
    }
}
