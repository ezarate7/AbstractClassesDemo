using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicles
    {
        public abstract int Year { get; set; }
        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving my vehicle virtually.");
        }
        
        
        public abstract void DriveAbstract();

    }
}
