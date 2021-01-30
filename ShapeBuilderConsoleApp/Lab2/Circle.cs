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
  ///   Subclass of Ellipse representing a 2-dimensional circle with area
  ///   determined by equal vertical and horizontal radii. Volume is zero.
  /// </summary>
  class Circle : Ellipse
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
    ///   Constructor for an instance of <c>Circle</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments <c>Count</c> base property by one. 
    /// </summary>
    /// 
    /// <remarks>
    ///   <para>
    ///     The methods <c>CalculateArea()</c> and <c>CalculateVolume()</c> are inherited by the 
    ///     <c>Ellipse</c> class.
    ///   </para>
    ///   <para>
    ///     Validation for user input in is done in the <c>Ellipse</c> base class, ensuring 
    ///     proper data provided.
    ///   </para>
    ///   <para>
    ///     The <c>Type</c> property is accessed through override to be able to set it here.
    ///   </para>
    /// </remarks>
    /// 
    /// <typeparam name="majorRadius">double</typeparam>
    /// <param name="majorRadius">
    ///   <c>majorRadius</c> (equal to <c>minorRadius</c>) of type <typeparamref name="majorRadius"/>
    /// </param>
    ///#########################################################################################///
    public Circle(double majorRadius) : base(majorRadius, majorRadius) { Type = "Circle"; }
    }
  }
