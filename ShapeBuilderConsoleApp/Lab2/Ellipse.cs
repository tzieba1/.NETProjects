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
  ///   Subclass of Shape representing a 2-dimensional ellipse with area determined by horizontal
  ///   and vertical radii. Volume is zero.
  /// </summary>
  class Ellipse : Shape
    {
    ///#########################################################################################///
    /// <summary>
    ///   Privately setroperty representing <c>MajorRadius</c> for an instance of <c>Ellipse</c>. 
    /// </summary>
    ///#########################################################################################///
    public double MajorRadius { get; }

    ///#########################################################################################///
    /// <summary>
    ///   Privately set property representing <c>MinorRadius</c> for an instance of <c>Ellipse</c>. 
    /// </summary>
    ///#########################################################################################///
    public double MinorRadius { get; }

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
    ///   Constructor for instance of <c>Ellipse</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. Validation for 
    ///   user input in "view" is done here - in "model" - ensuring proper data provided.
    /// </summary>
    /// 
    /// <typeparam name="majorRadius">double</typeparam>
    /// <param name="majorRadius">
    ///   <c>majorRadius</c> of type <typeparamref name="majorRadius"/> for an instance 
    ///   of <c>Ellipse</c>.
    /// </param>
    /// 
    /// <typeparam name="minorRadius">double</typeparam>
    /// <param name="minorRadius">
    ///   <c>minorRadius</c> of type <typeparamref name="minorRadius"/> for an instance
    ///   of <c>Ellipse</c>.
    /// </param>
    ///
    /// <exception cref="System.ArgumentOutOfRangeException">
    ///   Thrown when major or minor radii are zero or negative.
    /// </exception>
    ///#########################################################################################///
    public Ellipse(double majorRadius, double minorRadius): base()
      {
      /* Validation condition for setting major and minor radii. Throwing excpetion otherwise. */
      if (majorRadius > 0 && minorRadius > 0)
        {
        MajorRadius = majorRadius;
        MinorRadius = minorRadius;
        }
      else
        {
        throw new ArgumentOutOfRangeException("", "    Dimensions must be non-\n" +
                                                  "    negative and non-zero.");
        }
      Type = "Ellipse";
      }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Ellipse</c> object instance using properties 
    ///   <c>MajorRadius</c> and <c>MinorRadius</c>. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Ellipse</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => PI * MinorRadius * MajorRadius;

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of an <c>Ellipse</c> object which is always zero. 
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Ellipse</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => 0.0;
    }
  }
