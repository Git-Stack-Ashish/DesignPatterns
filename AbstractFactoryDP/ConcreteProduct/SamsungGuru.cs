using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class SamsungGuru : INormalPhone_AbstractProduct
    {
        public string GetModelDetails()
        {
            return "this is samsung normal phone - samsung guru";
        }
    }
}
