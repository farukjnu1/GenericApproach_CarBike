using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApproach_CarBike
{
    interface ITwoWheeler<T>
    {
        string ExteriorDesign(T data);
    }
}
