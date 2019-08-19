using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDP
{
    public class MobileClient
    {
        ISmartPhone_AbstractProduct smartPhone;
        INormalPhone_AbstractProduct normalPhone;

        public MobileClient(IMobilePhone_AbstarctFactory factory)
        {
            smartPhone = factory.GetSmartPhone();
            normalPhone = factory.GetNormalPhone();
        }

        public string GetSmartPhoneDetails()
        {
            return smartPhone.GetModelDetails();
        }

        public string GetNormalPhoneDetails()
        {
            return normalPhone.GetModelDetails();
        }
    }
}
