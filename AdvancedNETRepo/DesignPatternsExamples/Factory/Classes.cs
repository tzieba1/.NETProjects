using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
  class Classes
  {
    public abstract class IVehicle()
    {
      //public string ModeOfTransportation { get; set; }
    }

    public class Car : IVehicle
    {
      //ModeOfTransportation = "Land";
    }

    public class Boat : IVehicle
    {
      //ModeOfTransportation = "Water";
    }

    // Create concrete products in the factory.
    public abstract class VehicleCreator
    {
      public abstract IVehicle GetVehicle()
      {

        // Determine what specific type of concrete product to return and on default throw an exception for unsupported products. 
        switch (type)
        {
          case "Car":
            return new Car();
          case "Boat":
            return new Boat();
          default:
            throw new NotSupportedException();
        }
      }
    }
  }
}
