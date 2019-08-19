using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDP
{
    public interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}
