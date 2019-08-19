using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temp);
    }
}
