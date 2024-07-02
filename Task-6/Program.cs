using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test myCar = new Test("Toyota", 2022, "Sedan", 30000m, "Camry", "123ABC", "Red");
            myCar.StartEngine();
            Console.WriteLine(myCar.GetCarInfo());
            myCar.StopEngine();
            Console.WriteLine(myCar.GetCarInfo());

            Console.ReadKey();
        }
    }
}
