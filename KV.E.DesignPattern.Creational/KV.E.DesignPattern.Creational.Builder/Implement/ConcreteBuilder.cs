using KV.E.DesignPattern.Creational.Builder.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace KV.E.DesignPattern.Creational.Builder.Implement
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this._product = new Product();
        }
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }
        public Product GetProduct()
        {
            Product resutl = this._product;
            this.Reset();
            return resutl;
        }
    }
}
