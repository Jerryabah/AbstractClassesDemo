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
            // Done -Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var ferari = new Car() { HasTrunk = true, Make = "Ferari", Model = "458 Spider", Year = 2015 };
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley", Model = "Street Rod", Year = 2020 };

            Vehicle suv = new Car() { HasTrunk = true, Make = "Lexus", Model = "RX350", Year = 2020 };
            Vehicle sedan = new Car() { Make = "Mercedes", Model = "AMG C43", Year = 2019 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(ferari);
            vehicles.Add(motorcycle);
            vehicles.Add(suv);
            vehicles.Add(sedan);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Make: {veh.Make}, Model: {veh.Model}, Year: {veh.Year} -");
                veh.DriveVirtual();
                Console.WriteLine("------------------------------");
            }
            // Call each of the drive methods for one car and one motorcycle
            sedan.DriveAbstract();
            sedan.DriveVirtual();
            motorcycle.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
