using KV.E.DesignPattern.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.AbstractFactory.Implement
{
    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
