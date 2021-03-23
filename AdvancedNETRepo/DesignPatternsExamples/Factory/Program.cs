using System;
using static Factory.Classes;

namespace Factory
{
  class Program
  {
    static void Main(string[] args)
    {
      Creator factoryCreator = new Creator();
      IVehicle carProduct = factoryCreator.GetVehicle("Car");
      Console.WriteLine("Created a new {0}, The mode of transportation is {1}", carProduct.GetType().Name, carProduct.ModeOfTransportation);
    }
  }
}
