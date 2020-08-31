using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Structural.Bridge.Implement
{
    public class Client
    {
        public void ClientCode(Abstraction abstraction)
        {
            Console.WriteLine(abstraction.Operation());
        }
    }
}
