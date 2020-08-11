using KV.E.DesignPattern.Creational.AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.AbstractFactory.Implement
{
    public class ConcreateFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
