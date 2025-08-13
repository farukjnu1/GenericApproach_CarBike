using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    public class FourWheeler<T> : Vehicle, IFourWheeler<T>
    {
        public string InteriorDesign(T data)
        {
            return "This is InteriorDesign";
        }
    }
}
