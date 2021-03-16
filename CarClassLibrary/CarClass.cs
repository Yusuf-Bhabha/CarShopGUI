using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class CarClass
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Mileage { get; set; }

        public decimal Price { get; set; }

        public CarClass()
        {
            Make = "empty";
            Model = "empty";
            Mileage = 0;
            Price = 0.00m;
        }

        public CarClass(string a, string b, int c, decimal d)
        {
            Make = a;
            Model = b;
            Mileage = c;
            Price = d;
        }

        override public string ToString()
        {
            return "Make: " + Make + " Model: " + Model + " Mileage: " + Mileage + " Price: " + Price;
        }
    }
}
