using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int Wheels { get; set; }
        public string Color { get; set; }
        public int Doors { get; set; }
        public bool Bluetooth { get; set; }
    }
}
