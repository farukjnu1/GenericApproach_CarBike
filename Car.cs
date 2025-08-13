using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    sealed class Car<T> : FourWheeler<T>
    {
        public Car(string model, string yearMake, int numberOfGear, int engineCapacity,
            Vehicle_Type Vtype, int numberOfSeat, int numberOfDoor)
        {
            this.Model = model;
            this.YearMake = yearMake;
            this.NumberOfGear = numberOfGear;
            this.EngineCapacity = engineCapacity;
            this.VehicleType = Vtype;
            this.NumberOfSeat = numberOfSeat;
            this.NumberOfDoor = numberOfDoor;
        }
        public int NumberOfSeat { get; set; }
        public int NumberOfDoor { get; set; }
    }
}
