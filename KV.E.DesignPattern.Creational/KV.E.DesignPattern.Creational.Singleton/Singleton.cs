using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.Singleton
{
    public class Singleton
    {
        private Singleton() {}
        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }
}
