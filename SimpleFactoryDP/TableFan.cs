using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactoryDP
{
    public class TableFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("Switch off table fan");
        }

        public void SwitchOn()
        {
            Console.WriteLine("switch on table fan");
        }
    }
}
