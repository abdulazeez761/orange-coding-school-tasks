using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Test : Car
    {
        public string Model { get; set; }
        public string PalletNo { get; set; }
        public string Color { get; set; }
        private bool engineRunning;
        public Test(string make, int year, string type, decimal price, string model, string palletNo, string color)
        : base(make, year, type, price)
        {
            Model = model;
            PalletNo = palletNo;
            Color = color;
            engineRunning = false;
        }

        public void StartEngine()
        {
            engineRunning = true;
            Console.WriteLine("Engine started.");
        }

        public void StopEngine()
        {
            engineRunning = false;
            Console.WriteLine("Engine stopped.");
        }

        public string GetCarInfo()
        {
            return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price:C}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}, Engine Running: {engineRunning}";
        }
    }
}
