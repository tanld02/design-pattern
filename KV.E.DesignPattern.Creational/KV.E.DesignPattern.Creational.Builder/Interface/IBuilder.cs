using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.Builder.Interface
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
