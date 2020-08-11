using KV.E.DesignPattern.Creational.FactoryMethod.Abstract;
using KV.E.DesignPattern.Creational.FactoryMethod.Implement;
using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.FactoryMethod
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine($"App: Launched with the Concretor1");
            ClientCode(new ConcreteCreator1());
            Console.WriteLine($"");
            Console.WriteLine($"App: Launched with the Concretor2");
            ClientCode(new ConcreteCreator2());
        }

        public void ClientCode(Creator creator)
        {
            Console.WriteLine($"Client: I'm not aware of the creator's class, but it still work.\n {creator.SomeOperation()}");
        }
    }
}
