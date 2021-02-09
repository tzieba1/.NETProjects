using System;
using System.Linq;
using System.Reflection;

namespace AttributeExamples
{

  class Program
  {
  
    static void Main(string[] args)
    {
      Console.WriteLine("Print attributes on the program class...");

      var values = typeof(Program).GetCustomAttributes<MyCustomAttribute>().Select(c => c.MyValue);

      foreach (var item in values)
      {
        Console.WriteLine($"Value of custom attribute: {item}");
      }

      Console.WriteLine("\nEnter a command to run:");
      var input = Console.ReadLine();

      var methods = typeof(Program).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);

      var method = methods.SelectMany(c => c.GetCustomAttributes<CommandAttribute>().Where(args => args.Name == input).Select(b => c)).FirstOrDefault();

      method.Invoke(null, null);

      Console.ReadLine();
    }

    [Command("c")]
    [Command("cls")]
    [Command("clear")]
    [Help("A command to clear the screen")]
    private static void Clear()
    {
      Console.Clear();
    }
  }
}
