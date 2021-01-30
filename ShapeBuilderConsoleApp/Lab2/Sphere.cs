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
  ///   Subclass of Circle representing a 3-dimensional sphere with area and volume 
  ///   determined by two equal radii.
  /// </summary>
  class Sphere : Circle
    {
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
    /// <summary>
    ///   Constructor for an instance of <c>Sphere</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. 
    /// </summary>
    /// 
    /// <remarks>
    ///   Validation for user input in is done in the <c>Ellipse</c> base class, ensuring proper 
    ///   data provided. The <c>Type</c> property is accessed through override to be able 
    ///   to set it here.
    /// </remarks>
    /// 
    /// <typeparam name="majorRadius">double</typeparam>
    /// <param name="majorRadius">
    ///   <c>majorRadius</c> (equal to <c>Width</c> and <c>Height</c>) of 
    ///   type <typeparamref name="majorRadius"/>.
    /// </param>
    ///#########################################################################################///
    public Sphere(double majorRadius) : base(majorRadius) { Type = "Sphere"; }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Sphere</c> object instance using properties 
    ///   <c>MajorRadius</c> (equal to<c>MinorRadius</c>). 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Sphere</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => 4 * PI * MajorRadius * MajorRadius;

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Sphere</c> object instance using properties 
    ///   <c>MajorRadius</c> (equal to <c>MinorRadius</c>). 
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Sphere</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => 4/3 * PI * MajorRadius * MajorRadius * MajorRadius;
    }
  }
