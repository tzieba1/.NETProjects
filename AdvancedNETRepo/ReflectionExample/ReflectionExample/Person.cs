using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReflectionExample
{
  class Person
  {
    /// <summary>
    /// List of names which are enumerated in this ReflectionExample namespace.
    /// </summary>
    public List<Name> Names { get; set; }

    /// <summary>
    /// Static constructor makes no difference here, but is being demonstrated that it exists.
    /// </summary>
    static Person()
    {

    }

    /// <summary>
    /// Default constructor for this Person.
    /// Can look at the ConstructorInforExample() in the Program class to test what happens when making this private.
    /// </summary>
    public Person()
    {
      Console.WriteLine("Default Constructor has been called...");
    }

    /// <summary>
    /// Parametrized constructor for this Person.
    /// </summary>
    /// <param name="name"></param>
    public Person(string name)
    {
      Console.WriteLine("Parametrized Constructor has been called...");
    }

    public void AddName(string name)
    {
      AddName(new Name(NameType.FirstName,name));
    }

    public void AddName(Name name)
    {
      Names.Add(name);
    }

    public void DoSomething()
    {
      Console.WriteLine("Do something...");
    }
  }

  public class Name
  {
    public Name()
    {

    }
    public Name(NameType type, string value)
    {
      Type = type;
      Value = value;
    }

    public NameType Type { get; set; }
    [Required]
    public string Value { get; set; }
  }

  public enum NameType
  {
    FirstName = 1,
    MiddleName = 3,
    LastName = 77
  }
}
