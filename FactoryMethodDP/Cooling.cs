using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public class Cooling : IAirConditioner
    {
        public readonly double _temp;

        public Cooling(double temp)
        {
            _temp = temp;
        }

        public void Operate()
        {
            Console.WriteLine($"Cooling the room to {_temp}");
        }
    }
}
