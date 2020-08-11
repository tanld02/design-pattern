using KV.E.DesignPattern.Creational.FactoryMethod.Abstract;
using KV.E.DesignPattern.Creational.FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.FactoryMethod.Implement
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
