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
  ///   Subclass of Rectangle representing a 3-dimensional rectangular prism with area
  ///   determined by width, length, and height. Volume is zero.
  /// </summary>
  class Box : Rectangle
    {
    ///#########################################################################################///
    /// <summary>
    ///   Overriding <c>Type</c> property from <c>Rectangle</c> base class.
    /// </summary>
    /// <remarks>
    ///   To be accessed by overridden <c>ToString()</c> method in <c>Shape</c> class.
    /// </remarks>
    ///#########################################################################################///
    public override string Type { get; }

    ///#########################################################################################///
    /// <summary>
    ///   Privately set property representing <c>Height</c> for an instance of <c>Box</c>. 
    /// </summary>
    ///#########################################################################################///
    public double Height { get; }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Constructor for instance of <c>Rectangle</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. Validation for 
    ///   user input in "view" is done here - in "model" - ensuring proper data provided.
    /// </summary>
    /// 
    /// <typeparam name="height">double</typeparam>
    /// <param name="height"><c>height</c> of type <typeparamref name="height"/> for an 
    ///   instance of <c>Box</c>.
    /// </param>
    ///
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///   Thrown when height is zero or negative.
    /// </exception>
    ///#########################################################################################///
    public Box(double length, double width, double height) : base(length, width)
      {
      Type = "Box";
      /* Validation condition for setting height in range. Throwing excpetion otherwise. */
      if (height > 0)
        Height = height;
      else
        {
        throw new ArgumentOutOfRangeException("", "    Dimensions must be non-\n" +
                                                  "    negative and non-zero.");
        }
      }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Box</c> object instance using properties 
    ///   <c>Length</c>, <c>Width</c>, and <c>Height</c>. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Box</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => 2 * (Length * Width + Length * Height + Width * Height);

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Box</c> object instance using properties 
    ///   <c>Length</c>, <c>Width</c>, and <c>Height</c>. 
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Box</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => Length * Width * Height;
    }
  }
