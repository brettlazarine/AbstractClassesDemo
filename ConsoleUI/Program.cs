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

            /* -- DONE
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* -- DONE
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles -- DONE
            var vehicles = new List<Vehicle>();
            /* -- DONE
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car = new Car() { Year = "1997", Make = "Ford", Model = "F350" };
            var bike = new Motorcycle() { Year = "2000", Make = "Honda", Model = "Firestorm" };
            Vehicle v1 = new Car() { HasTrunk = false, Year = "1959", Make = "Chevrolet", Model = "Corvette" };
            Vehicle v2 = new Motorcycle() { HasSideCart= false, Year = "2023", Make = "Kawasaki", Model = "Ninja" };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car); vehicles.Add(bike); vehicles.Add(v1); vehicles.Add(v2);
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
            }
            // Call each of the drive methods for one car and one motorcycle
            car.DriveAbstract();
            v1.DriveVirtual();
            bike.DriveAbstract();
            v2.DriveVirtual();
            #endregion            
            Console.ReadLine();
        }
    }
}
