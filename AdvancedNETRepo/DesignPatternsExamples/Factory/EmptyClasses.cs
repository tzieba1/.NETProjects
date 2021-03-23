using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
  class EmptyClasses
  {
    public abstract class IProduct
    {

    }

    public class ConcreteProductA : IProduct
    {

    }

    public class ConcreteProductB : IProduct
    {

    }

    // Create concrete products in the factory.
    public class Creator
    {
      public IProduct GetProduct(string type)
      {

        // Determine what specific type of concrete product to return and on default throw an exception for unsupported products. 
        switch (type)
        {
          case "Product":
            return new ConcreteProductA();
          case "ProductB":
            return new ConcreteProductB();
          default:
            throw new NotSupportedException();
        }
      }
    }
  }
}
