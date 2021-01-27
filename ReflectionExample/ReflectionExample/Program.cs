using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ReflectionExample
{
  class Program
  {
    public List<string> Names { get; set; }
    static void Main(string[] args)
    {
      //ConstructorInfoExample();
      //MethodInfoExample();

      GetRequiredProperties();
    }

    private static void GetRequiredProperties()
    {
      var newName = new Name(NameType.LastName, "Zieba");
      var allProperties = typeof(Name).GetProperties();

      var requiredProperties = typeof(Name).GetProperties().Where(p => p.GetCustomAttributes<RequiredAttribute>().Any());

      Console.WriteLine("All Properties");
      foreach (var property in allProperties)
      {
        Console.WriteLine(property.Name);
      }

      Console.WriteLine("Required Properties");
      foreach (var property in requiredProperties)
      {
        Console.WriteLine(property.Name);
      }
    }

    private static void ConstructorInfoExample()
    {
      Type type = typeof(Person);
      var x = 100;
      var type2 = x.GetType();
      // Cannot use 'var type2 = typeof(x)' nor 'var type2 = typeof(x.GetClass())' nor 'Type type2 = typeof(x)' nor 'Type type2 = typeof(x.GetClass())'
      // This is because of static types.


      //var constructors = typeof(Person).GetConstructors();
      ConstructorInfo[] constructors = typeof(Person).GetConstructors();
      foreach (var constructor in constructors)
      {
        Console.WriteLine(constructor.Name);
      }

      // BindingFlags here are only taking public construsctors and instance constructors
      constructors = typeof(Person).GetConstructors(BindingFlags.Instance | BindingFlags.Public);

      // Further filtering the constructors and ignoring those (invoking null) where no parameters are provided (when they exist).
      foreach (var constructor in constructors.Where(c => !c.GetParameters().Any()))
      {
        // Console.WriteLine(constructor.Name);
        var instance = constructor.Invoke(null);
        Console.WriteLine(instance.GetType());
      }
    }

    private static void MethodInfoExample()
    {
      var person = new Person();
      var type = person.GetType();

      MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
      foreach (MethodInfo method in methods)
      {
        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Method name: {method.Name}");
        Console.WriteLine($"Method return type: {method.ReturnType}");
        Console.WriteLine($"Generic method: {method.IsGenericMethod}");
        Console.WriteLine($"Static method: {method.IsStatic}");
      }
    }
  }
}
