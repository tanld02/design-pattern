using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Structural.Adapter
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request.";
        }
    }
}
