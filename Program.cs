using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    class Program
    {
        static void Main(string[] args)
        {
            Car<string> a = new Car<string>("Car", "2019", 6, 450, Vehicle_Type.Car, 4, 4);
            Console.WriteLine("Model\t\t:" + a.Model);
            Console.WriteLine("YearMake\t:" + a.YearMake);
            Console.WriteLine("Vehicle_Type\t:" + a.VehicleType);
            Console.WriteLine("NumberOfGear\t:" + a.NumberOfGear);
            Console.WriteLine("EngineCapacity\t:" + a.EngineCapacity);
            Console.WriteLine("NumberOfSeat\t:" + a.NumberOfSeat);
            Console.WriteLine("NumberOfDoor\t:" + a.NumberOfDoor);
            Console.WriteLine("=============================");

            MotorCycle<string> b = new MotorCycle<string>("Motor-FZ100", "2011", 5, 250, Vehicle_Type.MotorCycle, 250, 25, 280);
            Console.WriteLine("Model\t\t:" + b.Model);
            Console.WriteLine("Made\t\t:" + b.YearMake);
            Console.WriteLine("Vehicle Type\t:" + b.VehicleType);
            Console.WriteLine("Gear\t\t:" + b.NumberOfGear);

            Console.WriteLine("=============================");
            Console.WriteLine(b.Start());
            Console.WriteLine(b.FrontBrake());
            Console.WriteLine(b.RearBrake());
            Console.WriteLine(b.Cooling());

            Console.ReadKey();
        }
    }
}
