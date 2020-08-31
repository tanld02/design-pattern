﻿using KV.E.DesignPattern.Structural.Bridge.Implement;
using System;

namespace KV.E.DesignPattern.Structural.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Abstraction abstraction;

            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);
            Console.WriteLine();
            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
