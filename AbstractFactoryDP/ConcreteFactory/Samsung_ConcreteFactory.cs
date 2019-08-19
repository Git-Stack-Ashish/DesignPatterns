using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class Samsung_ConcreteFactory : IMobilePhone_AbstarctFactory
    {
        public INormalPhone_AbstractProduct GetNormalPhone()
        {
            return new SamsungGuru();
        }

        public ISmartPhone_AbstractProduct GetSmartPhone()
        {
            return new SamsungGalaxy();
        }
    }
}
