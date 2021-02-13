using System;
using System.Collections.Generic;
using System.Text;

namespace AsyncDBExamples.Data
{
  /// <summary>
  /// Class to be used for demonstrating an asynchronous database representing a Person.
  /// </summary>
  class Person
  {
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTimeOffset CreationTime { get; set; }
  }
}
