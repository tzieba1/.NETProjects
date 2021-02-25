/// Author:           Tommy Zieba
/// Student Number:   000797152
/// 
/// I, Tommy Zieba, 000797152 certify that this material is my original work. 
/// No other person's work has been used without due acknowledgement.

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversePolishCalculator;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

/// <summary>
/// Unit testing for this solutions ReversPolishCalculator project. Specifically, these tests
/// are basic demonstrations of the custom ExpressionVisitor called ReversPolishExpressionBuilder
/// and used for validating, building, and evaluating strings expected in postfix notation.
/// </summary>
namespace UnitTestReversePolishCalculator
{
  /// <summary>
  /// Testing ReversePolishExpressionBuilder with invalid input whhere format exceptions are expected.
  /// </summary>
  [TestClass]
  public class TestExpressionBuilder_InvalidExpressions
  {
    /// <summary>
    /// Arrange an invalid user input to act on an instance of a ReversPolishExpressionBuilder
    /// with an expected format  exception thrown and caught by the ExpectedExceptionAttribute whenever 
    /// the expression startes with an operator.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void BuildExpression_ReversePolishExpressionBuilder_StartsWithOperator()
    {
      // Arrange
      ReversePolishExpressionBuilder builder = new ReversePolishExpressionBuilder();
      string input = "^ 3 3 + 5 7-*";

      // Act
      builder.ExpressionString = input;
    }

    /// <summary>
    /// Arrange an invalid user input to act on an instance of a ReversPolishExpressionBuilder
    /// with an expected format exception thrown and caught by the ExpectedExceptionAttribute whenever
    /// the expression ends with a number.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void BuildExpression_ReversePolishExpressionBuilder_EndsWithNumber()
    {
      // Arrange
      ReversePolishExpressionBuilder builder = new ReversePolishExpressionBuilder();
      string input = "^ 3 3 + 5 7-*";

      // Act
      builder.ExpressionString = input;
    }

    /// <summary>
    /// Arrange an invalid user input to act on an instance of a ReversPolishExpressionBuilder
    /// with an expected format exception thrown and caught by the ExpectedExceptionAttribute whenever
    /// the expression has invalid characters present.
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void BuildExpression_ReversePolishExpressionBuilder_InvalidCharactersPresent()
    {
      // Arrange
      ReversePolishExpressionBuilder builder = new ReversePolishExpressionBuilder();
      string input = "3 a + 5 7-*";

      // Act
      builder.ExpressionString = input;
    }

    /// <summary>
    /// Arrange an invalid user input to act on an instance of a ReversPolishExpressionBuilder
    /// with an expected format exception thrown and caught by the ExpectedExceptionAttribute whenever
    /// the expression has an imbalance of operators and numbers (must be exaclty one fewer operators).
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void BuildExpression_ReversePolishExpressionBuilder_OperatorAndNumberImbalance()
    {
      // Arrange
      ReversePolishExpressionBuilder builder = new ReversePolishExpressionBuilder();
      string input = "3 3 + 5 7-*^";

      // Act
      builder.ExpressionString = input;
    }
  }

  /// <summary>
  /// Testing ReversePolishExpressionBuilder built expression result using valid input.
  /// Also testing the resetting of the expression builder.
  /// </summary>
  [TestClass]
  public class TestExpressionBuilder_ValidExpressions
  {
    /// <summary>
    /// Arrange a valid expression as input to act on an instance of ReversePolishExpressionBuilder
    /// and assert that result is equal to known result.
    /// </summary>
    [TestMethod]
    public void EvaluateExpression_ReversePolishExpressionBuilder_VerifyResult()
    {
      // Arrange 
      ReversePolishExpressionBuilder builder = new ReversePolishExpressionBuilder();
      string input = "15 7 1 1 + - / 3*2 1 1 ++ -";

      // Act
      builder.ExpressionString = input;

      // Assert 
      Assert.AreEqual(builder.Result, 5);
    }

    /// <summary>
    /// Arrange a valid expression as input to act on an instance of ReversePolishExpressionBuilder.
    /// Then act on the builder by applying the Reset method and assert that public fields are reset.
    /// </summary>
    [TestMethod]
    public void Reset_ReversePolishExpressionBuilder_VerifyInstanceFields()
    {
      // Arrange 
      ReversePolishExpressionBuilder builder = new ReversePolishExpressionBuilder();
      string input = "15 7 1 1 + - / 3*2 1 1 ++ -";

      // Act
      builder.ExpressionString = input;
      builder.Reset();

      // Assert
      Assert.AreEqual(builder.ExpressionString, "");
      Assert.AreEqual(builder.ExpressionTerms.Count, 0);
      Assert.AreEqual(builder.RootExpression, null);
    }
  }
}
