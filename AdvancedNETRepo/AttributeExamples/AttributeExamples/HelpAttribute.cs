using System;
using System.Collections.Generic;
using System.Text;

namespace AttributeExamples
{
  /// <summary>
  /// Provides help text to a method
  /// </summary>
  
  [AttributeUsage(AttributeTargets.Method)]
  class HelpAttribute : Attribute
  {
    public HelpAttribute(string content)
    {
      this.Content = content;
    }
    public string Content { get; }
  }
}
