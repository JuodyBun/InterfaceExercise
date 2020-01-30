using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck: IVehicle, ICompany
    {
        public int BedSize { get; set; }
        public int WheelSize { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool Bluetooth { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void PrintTruck()
        {
            Console.WriteLine($"{Name} is borrowing the {Logo} company truck. It is {Color} colored, have {Wheels} wheels and {Doors} doors.");
            Console.WriteLine($"The size of the bed is {BedSize} inches and the wheels are {WheelSize} inches.");
            Console.WriteLine($"Got Bluetooth? {Bluetooth}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
