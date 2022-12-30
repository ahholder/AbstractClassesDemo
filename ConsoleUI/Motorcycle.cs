using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            IsCar = false;
        }
        public bool HasSideCar { get; set; } = false;
        public override void DriveAbstract()
        {
            int count = DateTime.Now.Year - int.Parse(Year);
            string message = $"This {Make} {Model} has been on the road for {count} year";
            if (count != 1 && count != -1) message += "s";
            message += "!";
            Console.WriteLine(message);
        }
        public override void DriveVirtual()
        {
            if (HasSideCar == true) Console.WriteLine($"The {Year} {Make} {Model} has a side car. You should take it for a drive!");
            if (HasSideCar == false) Console.WriteLine($"The {Year} {Make} {Model} has no side car. You should take it for a drive!");
        }
    }
}
