using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV: IVehicle, ICompany
    {
        public int Cargo { get; set; }
        public int Height { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool Bluetooth { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void PrintSuv()
        {
            Console.WriteLine($"{Name} is borrowing the {Logo} company SUV. It is {Color} colored, have {Wheels} wheels and {Doors} doors.");
            Console.WriteLine($"The cargo size is {Cargo} inches and the height size is {Height} inches.");
            Console.WriteLine($"Got Bluetooth? {Bluetooth}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
