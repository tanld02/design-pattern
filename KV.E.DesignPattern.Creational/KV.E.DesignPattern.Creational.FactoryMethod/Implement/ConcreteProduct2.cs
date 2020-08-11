using KV.E.DesignPattern.Creational.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.FactoryMethod.Implement
{
    class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return $"Result of ConcreteProduct2";
        }
    }
}
