using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
            int tally = 0;
            string readout = "";
            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List <Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car car = new Car();
            car.Year = "2010";
            car.Make = "Ford";
            car.Model = "Focus";
            car.HasTrunk = true;
            Motorcycle bike = new Motorcycle();
            bike.Year = "2018";
            bike.Make = "Harley";
            bike.Model = "Noise-Machine";
            bike.HasSideCar = true;
            Vehicle v1 = new Car();
            Vehicle v2 = new Motorcycle();
            v2.Year = "2014";
            v2.Make = "Dirt";
            v2.Model = "Bike";

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(bike);
            vehicles.Add(v1);
            vehicles.Add(v2);
            foreach (var driver in vehicles)
            {
                tally += 1;
                if (driver.IsCar == true) readout = "Car,";
                if (driver.IsCar == false) readout = "Motorcycle,";
                readout = $"#{tally}: {readout} {driver.Year} {driver.Make} {driver.Model}";
                Console.WriteLine(readout);
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            car.DriveAbstract();
            car.DriveVirtual();
            v2.DriveAbstract();
            v2.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}

//Static Polymorphism = Many methods for the same form @ compile time
//Dynamic Polymorphism = Many classes can be treated as base class @ compile time ("one thing, many forms")