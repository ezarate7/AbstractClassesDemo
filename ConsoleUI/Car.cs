using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicles
    {
        public override int Year { get; set; } = 2020;
        public override string Make { get; set; } = "Toyota";
        public override string Model { get; set; } = "Rav4";

        public override void DriveAbstract()
        {
            Console.WriteLine("Drives in abstract");
        }
        public bool HasTrunk { get; set; }

    }
}
