using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class Nokia1600 : INormalPhone_AbstractProduct
    {
        public string GetModelDetails()
        {
            return "this is nokia normal phone - nokia 1600";
        }
    }
}
