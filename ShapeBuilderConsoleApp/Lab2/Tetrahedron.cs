﻿//*** I, Tommy Zieba, 000797152 certify that this material is my original work. 
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
  ///   Subclass of Triangle representing a 3-dimensional equilateral triangular prism with area
  ///   and volume determined by three equal side length.
  /// </summary>
  class Tetrahedron : Triangle
    {
    ///#########################################################################################///
    /// <summary>
    ///   Overriding <c>Type</c> property from <c>Triangle</c> base class.
    /// </summary>
    /// <remarks>
    ///   To be accessed by overridden <c>ToString()</c> method in <c>Shape</c> class.
    /// </remarks>
    ///#########################################################################################///
    public override string Type { get; }

    ///#########################################################################################///
    /// <summary>
    ///   Constructor for an instance of <c>Tetrahedron</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. 
    /// </summary>
    /// 
    /// <remarks>
    ///   Validation for user input in is done in the <c>Triangle</c> base class, ensuring proper 
    ///   data provided. The <c>Type</c> property is accessed through override to be able 
    ///   to set it here.
    /// </remarks>
    /// 
    /// <typeparam name="length">double</typeparam>
    /// <param name="length">
    ///   <c>length</c> of type <typeparamref name="length"/>.
    /// </param>
    ///#########################################################################################///
    public Tetrahedron(double length) : base(length) { Type = "Tetrahedron"; }

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates area of a <c>Tetrahedron</c> object instance using <c>Length</c>
    ///   property representing side length of an inherited <c>Triangle</c> that is equilateral
    ///   and defines the faces of the <c>Tetrahedron</c>. 
    /// </summary>
    /// 
    /// <returns>Area for an instance of <c>Tetrahedron</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateArea() => 4 * ((Math.Sqrt(3) / 4) * Length * Length);

    ///#########################################################################################///
    ///
    /// <summary>
    ///   Method calculates volume of a <c>Tetrahedron</c> object instance using <c>Length</c>
    ///   property inherited by <c>Triangle</c>.
    /// </summary>
    /// 
    /// <returns>Volume for an instance of <c>Tetrahedron</c> of type <c>double</c>.</returns>
    ///#########################################################################################///
    public override double CalculateVolume() => (Length * Length * Length) / (6 * Math.Sqrt(2));
    }
  }
