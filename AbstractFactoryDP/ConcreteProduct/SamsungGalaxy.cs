using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class SamsungGalaxy : ISmartPhone_AbstractProduct
    {
        public string GetModelDetails()
        {
            return "This is samsung smart phone - samsung galaxy";
        }
    }
}
