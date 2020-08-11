﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.AbstractFactory.Interface
{
    public interface IAbstractProductB
    {
        // Product B is able to do its own thing...
        string UsefulFunctionB();

        // ...but it also can collaborate with the ProductA.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}
