using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public class WarmingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temp) => new Warming(temp);
    }
}
