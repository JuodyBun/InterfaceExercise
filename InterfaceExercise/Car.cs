using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public int Age { get; set; }
        public bool PreOwned { get; set; }
        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool Bluetooth { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void PrintCar()
        {
            Console.WriteLine($"{Name} is borrowing the {Logo} company car. It is {Color} colored, have {Wheels} wheels, {Doors} doors and is {Age} years old.");
            Console.WriteLine($"Preowned? {PreOwned}");
            Console.WriteLine($"Got Bluetooth? {Bluetooth}");
            Console.WriteLine("-----------------------------------------------");
        }
    }

}
