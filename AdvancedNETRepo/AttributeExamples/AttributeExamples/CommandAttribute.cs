using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeExamples
{
  /// <summary>
  /// Represents a keyword to run a command.
  /// </summary>
  
  [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
  class CommandAttribute : Attribute
  {
    public CommandAttribute(string name)
    {
      this.Name = name;
    }

    public string Name { get; set; }

  }
}
