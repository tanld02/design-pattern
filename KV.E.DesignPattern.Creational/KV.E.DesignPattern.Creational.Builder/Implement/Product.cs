using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.Builder.Implement
{
    public class Product
    {
        private List<object> _part = new List<object>();
        public void Add(string part)
        {
            this._part.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            for(int i = 0;i < this._part.Count; i++)
            {
                str += this._part[i] + ", ";
            }
            str = str.Remove(str.Length - 2);

            return $"Product parts: {str} \n";
        }
    }
}
