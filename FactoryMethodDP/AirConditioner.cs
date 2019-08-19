using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDP
{
    public class AirConditioner
    {
        public readonly Dictionary<TempEnum, AirConditionerFactory> _factories;

        public AirConditioner()
        {
            _factories = new Dictionary<TempEnum, AirConditionerFactory>
            {
                { TempEnum.Cooling, new CoolingFactory()},
                { TempEnum.Warming, new WarmingFactory()}
            };
        }

        public static AirConditioner InitializeFactories() => new AirConditioner(); 

        public IAirConditioner ExecuteCreation(TempEnum action, double temp) => _factories[action].Create(temp);
    }
}
