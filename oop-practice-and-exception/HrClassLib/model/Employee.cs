using HrClassLib;

namespace model.HrClassLib
{
    public class Employee : Person
    {

        public decimal BasicSalary { get; set; }
        public int TaxPercentage { get; set; }
    }
}