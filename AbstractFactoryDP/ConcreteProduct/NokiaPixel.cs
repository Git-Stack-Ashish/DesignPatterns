using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class NokiaPixel : ISmartPhone_AbstractProduct
    {
        public string GetModelDetails()
        {
            return "This is nokia smart phone - Nokia Pixel";
        }
    }
}
