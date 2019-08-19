using FactoryMethodDP;
using SimpleFactoryDP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDP;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("--------------------------**Factory Method Pattern**--------------------------------");

                var coolingObj = new AirConditioner().ExecuteCreation(TempEnum.Cooling, 22);
                coolingObj.Operate();
                var warmObj = new AirConditioner().ExecuteCreation(TempEnum.Warming, 45);
                warmObj.Operate();

                Console.WriteLine("--------------------------------");
                //factory method
                var coolingObj1 = AirConditioner.InitializeFactories().ExecuteCreation(TempEnum.Cooling, 10);
                coolingObj1.Operate();
                var warmingObj1 = AirConditioner.InitializeFactories().ExecuteCreation(TempEnum.Warming, 50);
                warmingObj1.Operate();

                Console.WriteLine("------------------------------------------------------------------------");

                Console.WriteLine("---------------------------**Simple Factory Pattern**-------------------------------");

                IFanFactory fanFactory = new FanFactory();
                IFan tableFan = fanFactory.CreateFan(FanType.TableFan);
                tableFan.SwitchOn();
                tableFan.SwitchOff();
                IFan ceilingFan = fanFactory.CreateFan(FanType.CeilingFan);
                ceilingFan.SwitchOn();
                ceilingFan.SwitchOff();
                Console.WriteLine("------------------------------------------------------------------------");

                Console.WriteLine("---------------------------**Abstract Factory Pattern**-------------------------------");

                IMobilePhone_AbstarctFactory mobilePhone = new Nokia_ConcreteFactory();
                MobileClient mc = new MobileClient(mobilePhone);

                Console.WriteLine("**NOKIA**");
                Console.WriteLine(mc.GetNormalPhoneDetails());
                Console.WriteLine(mc.GetSmartPhoneDetails());

                IMobilePhone_AbstarctFactory mobilePhone1 = new Samsung_ConcreteFactory();
                MobileClient mc1 = new MobileClient(mobilePhone);

                Console.WriteLine("**Samsung**");
                Console.WriteLine(mc1.GetNormalPhoneDetails());
                Console.WriteLine(mc1.GetSmartPhoneDetails());


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
