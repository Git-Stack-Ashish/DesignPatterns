using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class Nokia_ConcreteFactory : IMobilePhone_AbstarctFactory
    {
        public INormalPhone_AbstractProduct GetNormalPhone()
        {
            return new Nokia1600();
        }

        public ISmartPhone_AbstractProduct GetSmartPhone()
        {
            return new NokiaPixel();
        }
    }
}
