//*** I, Tommy Zieba, 000797152 certify that this material is my original work. 
//    No other person's work has been used without due acknowledgement.
//    
//    Date: October 4, 2019.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///   This is the namespace which holds projects and associated items with respect to
///   Lab 2A in COMP 10204 - Fall 2019.
/// </summary>
namespace Lab2A
  {
  /// <summary>
  ///   Subclass of Shape representing a 2-dimensional equilateral triangle with area 
  ///   determined by three equal side lengths. Volume is zero.
  /// </summary>
  class Triangle : Shape
    {
    ///#########################################################################################///
    /// <summary>
    ///   Privately set property representing <c>Length</c> of any side for an instance 
    ///   of <c>Triangle</c> that is equilateral. 
    /// </summary>
    ///#########################################################################################///
    public double Length { get; }
    ///#########################################################################################///
    /// <summary>
    ///   Overriding <c>Type</c> property from <c>Shape</c> base class.
    /// </summary>
    /// <remarks>
    ///   To be accessed by overridden <c>ToString()</c> method in <c>Shape</c> class.
    /// </remarks>
    ///#########################################################################################///
    public override string Type { get; }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Constructor for instance of <c>Triangle</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. Validation for 
    ///   user input in "view" is done here - in "model" - ensuring proper data provided.
    /// </summary>
    /// 
    /// <typeparam name="length">double</typeparam>
    /// <param name="length"><c>length</c> of type <typeparamref name="length"/> for an 
    ///   instance of <c>Triangle</c>.
    /// </param>
    ///
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///   Thrown when length is zero or negative.
    /// </exception>
    ///#########################################################################################///
    public Triangle(double length) : base()
      {
      Type = "Triangle";
      /* Validation condition for setting length and width. Throwing excpetion otherwise. */
      if (length > 0)
        Length = length;
      else
        {
        throw new ArgumentOutOfRangeException("", "    Dimensions must be non-\n" +
                                                  "    negative and non-zero.");
        }
      }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Triangle</c> object instance using <c>Length</c>
    ///   property representing side length of an instance of <c>Triangle</c> that is equilateral. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Triangle</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => (Math.Sqrt(3)/4) * Length * Length;

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Triangle</c> object which is always zero. 
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Triangle</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => 0.0;
    }
  }
