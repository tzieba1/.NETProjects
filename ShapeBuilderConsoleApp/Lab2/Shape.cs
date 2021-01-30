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
  ///#########################################################################################///
  ///
  /// <summary>
  ///   This class is the base class for subclasses of shapes to be created. Subclasses define
  ///   the abstract methods from this Shapes class. Note that class absraction is structured
  ///   by rescriction. Dimension is less abstract since shapes do not typically exceed 3-
  ///   dimensions. Here shapes are being refined by the amount of restrictions placed
  ///   on ANY dimensions of each shape. In other words, more abstract shapes have MORE 
  ///   restrictions on their dimensions. 
  /// </summary>
  /// <remarks>
  ///   This base class was copied from Nicholas Corkigian and modified by Mark Yendt and 
  ///   myself for appropriate encapsulation and model/view as per instructions for Lab2.
  ///   The <c>Count</c> property has not been modified further, but interferes with exceptions.
  ///   The consequences and solution are explained in the <c>AcmeShapeBuilder</c> class, but
  ///   the <c>Count</c> property is not required in <c>AcmeShapeBuilder</c>
  /// </remarks>
  ///#########################################################################################/// 
  public abstract class Shape
    {
    public abstract string Type { get; }         //The type of shape
    public static int Count { get; private set; }  //Number of instantiated shapes
    protected const double PI = 3.141592653589793;     //Constant value for pi

    //All this constructor does is increment the number of Shape instances
    public Shape()
      {
      Shape.Count++;
      }

    public abstract double CalculateArea();            //Calculate the Shape's area (surface area if 3-d)
    public abstract double CalculateVolume();          //Calculate the Shape's volume (if 3-d)
    public override string ToString() => $"Shape Type: {Type, -12} Surface Area: {CalculateArea(), -15:F4} Volume: {CalculateVolume(), -15:F4}";           //Used for printing Shape data
   }
  }
