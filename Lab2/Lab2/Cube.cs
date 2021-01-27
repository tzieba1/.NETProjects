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
  ///   Subclass of Square representing a 3-dimensional cube with area and volume 
  ///   determined by 3 equal side lengths.
  /// </summary>
  class Cube : Square
    {
    ///#########################################################################################///
    /// <summary>
    ///   Overriding <c>Type</c> property from <c>Square</c> base class.
    /// </summary>
    /// <remarks>
    ///   To be accessed by overridden <c>ToString()</c> method in <c>Shape</c> class.
    /// </remarks>
    ///#########################################################################################///
    public override string Type { get; }

    ///#########################################################################################///
    /// <summary>
    ///   Constructor for an instance of <c>Cube</c>. Inherits base constuctor -
    ///   <c>Square</c> - that incriments base property <c>Count</c> by one. 
    /// </summary>
    /// 
    /// <remarks>
    ///   Validation for user input in is done in the <c>Rectangle</c> base class, ensuring proper 
    ///   data provided. The <c>Type</c> property is accessed through override to be able 
    ///   to set it here.
    /// </remarks>
    /// 
    /// <typeparam name="length">double</typeparam>
    /// <param name="length">
    ///   <c>length</c> (equal to <c>Width</c> and <c>Height</c>) of 
    ///   type <typeparamref name="length"/>.
    /// </param>
    ///#########################################################################################///
    public Cube(double length) : base(length) { Type = "Cube"; }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Cube</c> object instance using the <c>Length</c>
    ///   property. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Cube</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => 6 * Length * Length;

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Cube</c> object instance using the <c>Length</c>
    ///   property.
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Cube</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => Length * Length * Length;
    }
  }
