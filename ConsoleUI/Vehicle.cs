using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Make { get; set; } = "toyota";
        public string Model { get; set; } = "camry";
        public int Year { get; set; } = 2018;
        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving a VEHICLE with a VIRTUAL METHOD");
        }




    }





}
