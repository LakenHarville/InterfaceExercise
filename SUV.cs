using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasCargoHold { get; set; }
        public string Logo { get; set; }
        public DateTime DateEstablished { get; set; }
        public int NumberOfWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} is driving the speed limit.");
        }
    }
}
