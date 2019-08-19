using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public class Warming : IAirConditioner
    {
        public readonly double _temp;

        public Warming(double temp)
        {
            _temp = temp;
        }

        public void Operate()
        {
            Console.WriteLine($"Warming room to {_temp}");
        }
    }
}
