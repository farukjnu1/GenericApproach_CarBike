using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    sealed class MotorCycle<T> : TwoWheeler<T>
    {
        public MotorCycle(string model, string yearMake, int numberOfGear, int engineCapacity,
            Vehicle_Type Vtype, int maximumPower, int maximumTorque, int milage)
        {
            this.Model = model;
            this.YearMake = yearMake;
            this.NumberOfGear = numberOfGear;
            this.EngineCapacity = engineCapacity;
            this.VehicleType = Vtype;
            this.MaximumPower = maximumPower;
            this.MaximumTorque = maximumTorque;
            this.Milage = milage;
        }
        public int MaximumPower { get; set; }
        public int MaximumTorque { get; set; }
        public int Milage { get; set; }
        public string Start()
        {
            return "This is First Method";
        }
        public string Cooling()
        {
            return "This is CoolingBreak";
        }
        public string FrontBrake()
        {
            return "This is FrontBreak";
        }
        public string RearBrake()
        {
            return "This is RearBreak";
        }
    }

}
