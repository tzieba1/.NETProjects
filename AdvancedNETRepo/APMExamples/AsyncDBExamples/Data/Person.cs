using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AsyncDBExamples.Data
{
  /// <summary>
  /// Class to be used for demonstrating an asynchronous database representing a Person.
  /// </summary>
  class Person
  {
    [Key]
    public Guid Id { get; set; }
    [Required]
    [StringLength(120)]
    public string FirstName { get; set; }
    [Required]
    [StringLength(120)]
    public string LastName { get; set; }
    [Required]
    public DateTimeOffset CreationTime { get; set; }
  }
}
