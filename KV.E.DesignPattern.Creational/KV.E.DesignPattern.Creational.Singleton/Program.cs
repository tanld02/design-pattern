using System;

namespace KV.E.DesignPattern.Creational.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal singleton
            Singleton singletonA = Singleton.GetInstance();
            Singleton singletonB = Singleton.GetInstance();
            // Thread safe
            SingletonThreadSafe singletonThreadSafeA = SingletonThreadSafe.GetInstance("A");
            SingletonThreadSafe singletonThreadSafeB = SingletonThreadSafe.GetInstance("B");
        }
    }
}
