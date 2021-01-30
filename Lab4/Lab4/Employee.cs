//*** I, Tommy Zieba, 000797152 certify that this material is my original work. 
//    No other person's work has been used without due acknowledgement.
//    
//    Date: September 22, 2019.
//    Revised: November 11, 2019.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4a
  {
  /// <summary>
  ///   This class represents an employee with corresponding name, number, pay rate, 
  ///   hours, and gross pay. These attriutes are passed in as parameters when constructing
  ///   an <c>Employee</c> object.
  /// </summary>
  public class Employee 
    {
    /* The name Property for an instance of Employee. */
    public string Name { get; set; }
    /* The number Property for an instance of Employee. */
    public int Number { get; set; }
    /* The hours Property for an instance of Employee. */
    public decimal Rate { get; set; }
    /* The pay rate Property for an instance of Employee. */
    public double Hours { get; set; }
    /* The gross pay Property for an instance of Employee. */
    public decimal Gross { get; set; }


    /// <summary>
    ///   Class constructor for an instance of <c>Employee</c>.
    /// </summary>
    /// 
    /// <param name="name"><c>Employee</c> name of type <typeparamref name="name"/></param>
    /// <typeparam name="name">string</typeparam>
    /// 
    /// <param name="number"><c>Employee</c> number of type <typeparamref name="number"/></param>
    /// <typeparam name="number">int</typeparam>
    /// 
    /// <param name="rate"><c>Employee</c> pay rate of type <typeparamref name="rate"/></param>
    /// <typeparam name="rate">decimal</typeparam>
    /// 
    /// <param name="hours"><c>Employee</c> hours of type <typeparamref name="hours"/></param>
    /// <typeparam name="hours">double</typeparam>
    public Employee(string name, int number, decimal rate, double hours)
      {
      Name = name;
      Number = number;
      Rate = rate;
      Hours = hours;
      if (hours <= 40)    //Gross calculated differently (x1.5) for hours worked over 40 hours.
        Gross = rate * (decimal)hours;
      else
        Gross = 40 * rate + ((decimal)hours - 40) * rate * (decimal)1.5;
      }
    
    /// <summary>
    ///   Overridden to return a string representation of this Employee.
    /// </summary>
    /// <returns>String representation of Employee.</returns>
    public override string ToString() =>
      $"Employee[ Name = {Name}, Number = {Number}, " +
      $"Rate = {Rate:F2}, Hours = {Hours:F2}, Gross = {Gross:F2} ]";
    }
  }
