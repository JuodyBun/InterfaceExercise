using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car honda = new Car
            {
                Age = 5,
                PreOwned = true,
                Wheels = 4,
                Color = "green",
                Doors = 4,
                Bluetooth = true,
                Logo = "Turkey Baster's",
                Name = "Sally",
            };

            honda.PrintCar();

            Truck ford = new Truck
            {
                BedSize = 50,
                WheelSize = 28,
                Wheels = 4,
                Color = "orange",
                Doors = 4,
                Bluetooth = true,
                Logo = "Snuggle Puff's",
                Name = "Julio",
            };

            ford.PrintTruck();

            SUV lincoln = new SUV
            {
                Cargo = 25,
                Height = 50,
                Wheels = 4,
                Color = "red",
                Doors = 4,
                Bluetooth = false,
                Logo = "Meow Cafe's",
                Name = "Koneko",
            };

            lincoln.PrintSuv();
        }
    }
}
