using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripToTheMoon
  {
  class AstronautTrip
    {
    public string Name { get; }
    public DateTime Depart { get; }
    public DateTime Arrive { get; }

    public AstronautTrip(string name, DateTime depart)
      {
      if (name != "")
        Name = name;
      else
        throw new Exception("Name cannot be left blank.");
      Depart = depart;
      Arrive = Depart.AddDays(3).AddHours(8).AddMinutes(30);
      }

    public override bool Equals(Object other)
      {
      if (other != null && GetType() == other.GetType())
        {
        AstronautTrip otherTrip = (AstronautTrip)other;
        if (Depart == otherTrip.Depart)
          return true;
        }
      return false;
      }

    public override string ToString()
      { return $"AstronautTrip => [Name = {Name}, Depart = {Depart}, Arrive = {Arrive}]"; }
    }
  }
