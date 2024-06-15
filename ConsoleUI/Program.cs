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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * 
             * The vehicle class shall have three string properties: Year, Make, and Model
             * 
             * Set the defaults of the properties to something generic in the Vehicle class  
             * 
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation. ?????
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle   ????
             * Provide the implementations for the abstract methods ???????
             * Only in the Motorcycle class will you override the virtual drive method  ????????
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();




            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            Motorcycle vehicle1 = new Motorcycle() { Make = "Ford", Model = "F150", Year = 2019, HasFork = true };
            Car vehicle2 = new Car() { Make = "BMW", HasSteeringWheel = true, Model = "X3" };
            Vehicle vehicle3 = new Motorcycle() { Make = "something cool", Model = "super dooper awesome", Year = 2025 };
            Vehicle vehicle4 = new Car() { Make = "Honda", Model = "Accord", Year = 2023, HasSteeringWheel = true };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(vehicle3);
            vehicles.Add(vehicle4);

            // Call each of the drive methods for one car and one motorcycle

            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine();
            }


            vehicle1.DriveAbstract();
            vehicle1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
