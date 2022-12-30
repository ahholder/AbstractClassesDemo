using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car()
        {
            IsCar = true;
        }
        public bool HasTrunk { get; set; } = false;
        public override void DriveAbstract()
        {
            int count = DateTime.Now.Year - int.Parse(Year);
            string message = $"The public has been driving the {Make} {Model} for {count} year";
            if (count != 1 && count != -1) message += "s";
            message += "!";
            if (HasTrunk == true) message += " It even has a trunk!";
            Console.WriteLine(message);
        }
    }
}
