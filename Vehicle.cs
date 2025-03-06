using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkingSystem3
{
    public class Vehicle
    {
        public string RegistrationNo { get; }
        public string Color { get; }
        public string Type { get; }

        public Vehicle(string registrationNo, string color, string type)
        {
            RegistrationNo = registrationNo;
            Color = color;
            Type = type;
        }
    }
}