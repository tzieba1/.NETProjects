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
  ///   Subclass of Shape representing a 2-dimensional rectangle with area. 
  ///   determined by length and width. Volume is zero.
  /// </summary>
  class Rectangle : Shape
    {
    ///#########################################################################################///
    /// <summary>
    ///   Privately set property representing <c>Length</c> for an instance of <c>Rectangle</c>. 
    /// </summary>
    ///#########################################################################################///
    public double Length { get; }

    ///#########################################################################################///
    /// <summary>
    ///   Privately set property representing <c>Width</c> for an instance of <c>Rectangle</c>. 
    /// </summary>
    ///#########################################################################################///
    public double Width { get; }

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
    ///   Constructor for instance of <c>Rectangle</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. Validation for 
    ///   user input in "view" is done here - in "model" - ensuring proper data provided.
    /// </summary>
    /// 
    /// <typeparam name="length">double</typeparam>
    /// <param name="length"><c>length</c> of type <typeparamref name="length"/> for an 
    ///   instance of <c>Rectangle</c>.
    /// </param>
    /// 
    /// <typeparam name="width">double</typeparam>
    /// <param name="width"><c>width</c> of type <typeparamref name="width"/> for an 
    ///   instance of <c>Rectangle</c>.
    /// </param>
    ///
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///   Thrown when length or width are zero or negative.
    /// </exception>
    ///#########################################################################################///
    public Rectangle(double length, double width) : base()
      {
      Type = "Rectangle";  //Abstract property for base class - Shape.

      /* Validation condition for setting length and width. Throwing excpetion otherwise. */
      if (length > 0 && width > 0)
        {
        Length = length;
        Width = width;
        }
      else
        { 
        throw new ArgumentOutOfRangeException("", "    Dimensions must be non-\n" +
                                                  "    negative and non-zero.");
        }
      }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Rectangle</c> object instance using properties 
    ///   <c>Length</c> and <c>Width</c>. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Rectangle</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => Length * Width;

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Rectangle</c> object which is always zero. 
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Rectangle</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => 0;
    }
  }
