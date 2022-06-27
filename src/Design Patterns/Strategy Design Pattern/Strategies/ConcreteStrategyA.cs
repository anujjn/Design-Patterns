using Strategy_Design_Pattern.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Design_Pattern.Strategies
{
    // Concrete Strategies implement the algorithm while following the base
    // Strategy interface. The interface makes them interchangeable in the
    // Context.
    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
