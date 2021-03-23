using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples
{
  class Singleton
  {
    // The singleton is private so it cannot be instantiated anywhere else in the namespace except within the class itself.
    // This design pattern is not thread-safe unless the instance is readonly!
    // It is not a "lazy" instantiation when it is readonly.
    private static readonly Singleton _instance;
    private Singleton()
    {

    }

    public static Singleton GetInstance()
    {
      //// Check if another singleton has been instantiated first before being able to change the instance when Singleton is NOT readonly.
      //if(_instance == null)
      //{
      //  _instance = new Singleton();
      //}
      
      return _instance;
    }
  }
}
