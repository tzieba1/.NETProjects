using System;
using System.Reflection;
using System.Threading;

namespace MultiThreadingExample
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine($"Inside the method {MethodBase.GetCurrentMethod().Name}");
      Console.WriteLine($"Managed Thread  Id: {Thread.CurrentThread.ManagedThreadId}");

      Console.WriteLine("\nInvoking 'UseThreads' method");
      UseThreads();
    }

    // Method called to use a new thread for other private methods being in this Program.
    private static void UseThreads()
    {
      Console.WriteLine($"\nInside the method {MethodBase.GetCurrentMethod().Name}");

      // Assigning a method to a thread.
      Thread thread = new Thread(DoWork);

      // Display the new thread's state before starting it.
      Console.WriteLine($"Thread State BEFORE start: {thread.ThreadState}");

      thread.Start(); // Run thread.

      // Display the new thread's state after starting it.
      Console.WriteLine($"Thread State AFTER start: {thread.ThreadState}");

      // Same thing but with a method that has parameters.
      Thread parametrizedThread = new Thread(DoWorkWithParameter);
      Console.WriteLine($"Parametrized thread State BEFORE start: {parametrizedThread.ThreadState}");
      parametrizedThread.Start("3");
      Console.WriteLine($"Parametrized thread State AFTER start: {parametrizedThread.ThreadState}");
    }

    // Method called to displkay its name and the current thread it is working on by id, then does some work.
    private static void DoWork()
    {
      // Display the methodname for this method using reflection.
      Console.WriteLine($"\nInside the method {MethodBase.GetCurrentMethod().Name}");

      // Display the managed thread id for current thread of thius method.
      Console.WriteLine($"Managed Thread  Id: {Thread.CurrentThread.ManagedThreadId}");

      Console.WriteLine("Doing some work in DoWork() ...");
    }

    // Method called to displkay its name and the current thread it is working on by id, then displays a computation result.
    private static void DoWorkWithParameter(object paramValue)
    {
      Console.WriteLine($"\nInside the method {MethodBase.GetCurrentMethod().Name}");
      Console.WriteLine($"Managed Thread  Id: {Thread.CurrentThread.ManagedThreadId}");

      Console.WriteLine($"Computation Result: {Convert.ToInt32(paramValue) * Convert.ToInt32(paramValue)} ...");
    }
  }
}
