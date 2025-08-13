using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    public class TwoWheeler<T> : Vehicle, ITwoWheeler<T>
    {
        public string ExteriorDesign(T data)
        {
            return "This is ExteriorDesign";
        }
    }
}
