using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "2000";
        public string Make { get; set; } = "Fictional";
        public string Model { get; set; } = "Fictional";
        public bool IsCar { get; set; } //Included, but not part of mandatory assignment
        public abstract void DriveAbstract();
        public virtual void DriveVirtual() 
        {
            Console.WriteLine($"You should take the {Year} {Make} {Model} for a drive!");
        }
    }
}
