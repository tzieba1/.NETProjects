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
  ///   Subclass of Circle representing a 3-dimensional cylindrical prism with area 
  ///   and volume determined by equal horizontal and vertical radii and a height.
  /// </summary>S
  class Cylinder : Circle
    {
    ///#########################################################################################///
    /// <summary>
    ///   Privately set property representing <c>Length</c> for an instance of <c>Cylinder</c>. 
    /// </summary>
    ///#########################################################################################///
    public double Length { get; }

    ///#########################################################################################///
    /// <summary>
    ///   Overriding <c>Type</c> property from <c>Circle</c> base class.
    /// </summary>
    /// <remarks>
    ///   To be accessed by overridden <c>ToString()</c> method in <c>Shape</c> class.
    /// </remarks>
    ///#########################################################################################///
    public override string Type { get; }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Constructor for instance of <c>Cylinder</c>. Inherits abstract base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. Validation for 
    ///   user input in "view" is done here - in "model" - ensuring proper data provided.
    /// </summary>
    /// 
    /// <typeparam name="length">double</typeparam>
    /// <param name="length">
    ///   <c>length</c> of type <typeparamref name="length"/> for an instance 
    ///   of <c>Cylinder</c>.
    /// </param>
    ///
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///   Thrown whenever length is zero or negative.
    /// </exception>
    ///#########################################################################################///
    public Cylinder(double majorRadius, double length) : base(majorRadius)
      {
      Type = "Cylinder";
      /* Validation condition for setting length in range. Throwing excpetion otherwise. */
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
    ///   Method calculates area of a <c>Cylinder</c> object instance using properties 
    ///   <c>MajorRadius</c> (equal to<c>MinorRadius</c>) and <c>Length</c>. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Cylinder</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() 
      => PI * (MajorRadius + MinorRadius) * Length + 2 * PI * MinorRadius * MajorRadius;

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Cylinder</c> object instance using properties 
    ///   <c>MajorRadius</c> (equal to <c>MinorRadius</c>) and <c>Length</c>. 
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Cylinder</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => PI * MajorRadius * MinorRadius * Length;
    }
  }
