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
  ///   Subclass of Rectangle representing a 2-dimensional rectangle with area determined by 
  ///   EQUAL length and width. Volume is zero.
  /// </summary>
  class Square : Rectangle
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
    ///   Constructor for an instance of <c>Square</c>. Inherits base constuctor -
    ///   <c>Shape</c> - that incriments base property <c>Count</c> by one. 
    /// </summary>
    /// 
    /// <remarks>
    ///   <para>
    ///     The methods <c>CalculateArea()</c> and <c>CalculateVolume()</c> are inherited by the 
    ///     <c>Rectangle</c> class.
    ///   </para>
    ///    <para>
    ///     Validation for user input in is done in the <c>Rectangle</c> base class, ensuring 
    ///     proper data provided.
    ///   </para>
    ///    <para>
    ///     The <c>Type</c> property is accessed through override to be to set it here.
    ///   </para>
    /// </remarks>
    /// 
    /// <typeparam name="length">double</typeparam>
    /// <param name="length">
    ///   <c>length</c> (equal to width) of type <typeparamref name="length"/>
    /// </param>
    ///#########################################################################################///
    public Square(double length) : base(length, length) { Type = "Square"; }
    }
  }
