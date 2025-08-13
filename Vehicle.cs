using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string YearMake { get; set; }

        public Vehicle_Type VehicleType { get; set; }
        public int NumberOfGear { get; set; }
        public double EngineCapacity { get; set; }
    }
}
