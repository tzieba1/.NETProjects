using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeExamples
{
  /// <summary>
  /// 
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = false)]
  class MyCustomAttribute : Attribute
  {
    public MyCustomAttribute(string myValue)
    {
      this.MyValue = myValue;
    }
    public string MyValue { get; set; }
  }
}
