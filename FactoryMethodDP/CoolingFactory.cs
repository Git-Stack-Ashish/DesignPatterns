using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public class CoolingFactory : AirConditionerFactory
    {
        public override IAirConditioner Create(double temp) => new Cooling(temp);
    }
}
