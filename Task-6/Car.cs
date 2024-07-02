using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Car
    {
        public Car(string make, int year, string type, decimal price)
        {
            Make = make;
            Year = year;
            Type = type;
            Price = price;
        }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
    }
}
