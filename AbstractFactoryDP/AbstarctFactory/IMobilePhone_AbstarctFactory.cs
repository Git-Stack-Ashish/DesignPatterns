using System;

namespace AbstractFactoryDP
{
    public interface IMobilePhone_AbstarctFactory
    {
        ISmartPhone_AbstractProduct GetSmartPhone();
        INormalPhone_AbstractProduct GetNormalPhone();
    }
}
