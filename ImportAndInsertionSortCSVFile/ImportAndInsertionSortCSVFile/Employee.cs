using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportAndInsertionSortCSVFiles
  {
  /// <summary>
  ///   This class represents an employee with corresponding name, number, pay rate, 
  ///   hours, and gross pay. These attriutes are passed in as parameters when constructing
  ///   an <c>Employee</c> object.
  /// </summary>
  class Employee
    {
    /* The name attribute for an instance of Employee. */
    private string name;
    /* The number attribute for an instance of Employee. */
    private int number;
    /* The hours attribute for an instance of Employee. */
    private decimal rate;
    /* The pay rate attribute for an instance of Employee. */
    private double hours;
    /* The gross pay attribute for an instance of Employee. */
    private decimal gross;


    /// <summary>
    ///   Class constructor for an instance of <c>Employee</c>.
    /// </summary>
    /// 
    /// <param name="name"><c>Employee</c> name of type <typeparamref="name"/></param>
    /// <typeparam name="name">string</typeparam>
    /// 
    /// <param name="number"><c>Employee</c> number of type <typeparamref="number"/></param>
    /// <typeparam name="number">int</typeparam>
    /// 
    /// <param name="rate"><c>Employee</c> pay rate of type <typeparamref="rate"/></param>
    /// <typeparam name="rate">decimal</typeparam>
    /// 
    /// <param name="hours"><c>Employee</c> hours of type <typeparamref="hours"/></param>
    /// <typeparam name="hours">double</typeparam>
    public Employee(string name, int number, decimal rate, double hours)
      {
      this.name = name;
      this.number = number;
      this.rate = rate;
      this.hours = hours;
      if (hours <= 40)    //Gross calculated differently (x1.5) for hours worked over 40 hours.
        this.gross = rate * (decimal)hours;
      else
        this.gross = (decimal)40 * rate + ((decimal)hours - 40) * rate * (decimal)1.5;
      }

    /// <summary>
    ///   Method used to get the gross pay for this instance of <c>Employee</c>. 
    /// </summary>
    /// <returns>Gross pay for this instance of Employee of type decimal.</returns>
    public decimal GetGross()
      { return gross; }

    /// <summary>
    ///   Method used to get the hours worked for this instance of <c>Employee</c>. 
    /// </summary>
    /// <returns>Hours for this instance of <c>Employee</c> of type double.</returns>
    public double GetHours()
      { return hours; }

    /// <summary>
    ///   Method used to get the name for this instance of <c>Employee</c>. 
    /// </summary>
    /// <returns>Name for this instance of <c>Employee</c> of type string.</returns>
    public string GetName()
      { return name; }

    public int GetNumber()
      { return number; }

    /// <summary>
    ///   Method used to get the employee number for this instance of <c>Employee</c>. 
    /// </summary>
    /// <returns>Number for this instance of <c>Employee</c> of type int.</returns>
    public decimal GetRate()
      { return rate; }

    /// <summary>
    ///   Method overridden - used for returning string representation of <c>Employee</c> object.
    /// </summary>
    /// <returns>Representation for this instance of <c>Employee</c> of type string.</returns>
    public override string ToString()
      {
      return $"Employee[ Name = {name}, Number = {number}, " +
            $"Rate = {rate:F2}, Hours = {hours:F2}, Gross = {gross:F2} ]";
      }

    /// <summary>
    ///   Method used to set the hours worked for this instance of <c>Employee</c>. 
    /// </summary>
    /// <param>
    ///   Hours for this instance of <c>Employee</c> of type <typeparamref name="hours"/>.
    /// </param>
    /// <typeparam>double</typeparam>
    public void SetHours(double hours)
      { this.hours = hours; }

    /// <summary>
    ///   Method used to set the name for this instance of <c>Employee</c>. 
    /// </summary>
    /// <param>
    ///   Name for this instance of <c>Employee</c> of type <typeparamref name="name"/>.
    /// </param>
    /// <typeparam>string</typeparam>
    public void SetName(string name)
      { this.name = name; }

    /// <summary>
    ///   Method used to set the employee number for this instance of <c>Employee</c>. 
    /// </summary>
    /// <param>
    ///   nNumber for this instance of <c>Employee</c> of type <typeparamref name="number"/>.
    /// </param>
    /// <typeparam>int</typeparam>
    public void SetNumber(int number)
      { this.number = number; }

    /// <summary>
    ///   Method used to set the pay rate  for this instance of <c>Employee</c>. 
    /// </summary>
    /// <param>
    ///   Pay rate for this instance of <c>Employee</c> of type <typeparamref name="rate"/>.
    /// </param>
    /// <typeparam>decimal</typeparam>
    public void SetRate(decimal rate)
      { this.rate = rate; }
    }
  }