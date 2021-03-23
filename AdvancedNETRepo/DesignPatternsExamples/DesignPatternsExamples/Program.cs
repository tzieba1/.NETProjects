using System;

namespace DesignPatternsExamples
{
  class Program
  {
    static void Main(string[] args)
    {
      var singleton1 = Singleton.GetInstance();
      var singleton2 = Singleton.GetInstance();
    }
  }
}
