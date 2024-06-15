using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Motorcycle : Vehicle
    {

        public bool HasFork { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a MOTORCYCLE from an ABSTRACT METHOD");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Driving a MOTORCYCLE with a VIRTUAL METHOD");
        }



    }






}
