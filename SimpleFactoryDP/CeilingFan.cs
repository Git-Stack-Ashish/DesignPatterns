using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDP
{
    public class CeilingFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("switch off ceiling fan");
        }

        public void SwitchOn()
        {
            Console.WriteLine("switch on ceiling fan");
        }
    }
}
