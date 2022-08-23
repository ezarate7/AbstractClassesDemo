using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicles
    {
        public override int Year { get; set; } = 2022;
        public override string Make { get; set; } = "Yamaha";
        public override string Model { get; set; } = "R1";

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle driving abstractly"); ;
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($" this {GetType().Name} is a {GetType().BaseType.Name}");
        }
        public int HowManyWheels { get; set; }
    }
}
