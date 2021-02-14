/// Author:           Tommy Zieba
/// Student Number:   000797152
/// 
/// I, Tommy Zieba, 000797152 certify that this material is my original work. 
/// No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;

namespace ReversePolishCalculator
{
  /// <summary>
  /// Expression visitor used to build reverse polish expressions by accepting string input from console.
  /// </summary>
  public class ReversePolishExpressionBuilder : ExpressionVisitor
  {
    /// <summary>
    /// Prooperty representing the root expression for this reverse polish expression tree visitor.
    /// Note that this must be reset after partial expressions are parsed and appended to the 
    /// expression tree being built.
    /// </summary>
    public Expression RootExpression { get; set; }

    /// <summary>
    /// Property that gets ExpressionString, or custom sets it by also building an expression, and 
    /// setting it as this class' RootExpression to be evaluated.
    /// </summary>
    public string ExpressionString
    {
      get { return this.ExpressionString; }
      set
      {
        this.ExpressionString = value;
        BuildExpressionTree(value);
      }
    }

    /// <summary>
    /// Operators stacked for building expressions.
    /// </summary>
    private Stack<char> operatorStack = new Stack<char>();
    
    /// <summary>
    /// Constants to be formulated into an expression.
    /// </summary>
    private Stack<ConstantExpression> constantExpressionStack = new Stack<ConstantExpression>();

    /// <summary>
    /// Default constructor.
    /// </summary>
    public ReversePolishExpressionBuilder() { }

    /// <summary>
    /// Constructor that accepts a root node (constant expression) to begin building a reverse
    /// polish expression. Root assigned to partialExpressionStack until first operator reached.
    /// </summary>
    /// <param name="root"></param>
    public ReversePolishExpressionBuilder(string expressionString) { this.ExpressionString = expressionString; }

    /// <summary>
    /// Builds an expression tree from validated user input and returns it.
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns>Expression representing userInput.</returns>
    private void BuildExpressionTree(string expressionString)
    {
      Regex whiteSpaceRegex = new Regex(@"\s+", RegexOptions.Compiled); // Pattern used to split and extract numbers and/or operators.
      string[] sanitizedUserInput = whiteSpaceRegex.Split(expressionString);   // String array containing numbers and/or operators only.

      // Handle character sequences without whitespace and having both numbers and operators - where an expression is needed.
      for (int i = 0; i < sanitizedUserInput.Length; i++)
      {
        string nonWhiteSpaceSequence = sanitizedUserInput[i];
        // Check for operators present in a non-whitespace sequence, then build expression using custom reverse polish visitor.
        if (!Regex.IsMatch(nonWhiteSpaceSequence, @"[\+\-\*\/\^]"))
          constantExpressionStack.Push(Expression.Constant(int.Parse(nonWhiteSpaceSequence)));
        
        //When no operators present, stack the constant expression.
        else
        {
          Regex splitOperatorsRegex = new Regex(@"[0123456789]", RegexOptions.Compiled);  // Pattern used to split and extract operators.
          Regex splitNumbersRegex = new Regex(@"[\+\-\*\/\^]", RegexOptions.Compiled);    // Pattern used to split and extract numbers.

          string[] numbers = splitNumbersRegex.Split(nonWhiteSpaceSequence);          // Split sequence to extract numbers.
          //Array.ForEach(numbers, Console.WriteLine);
          string[] operators = splitOperatorsRegex.Split(nonWhiteSpaceSequence);      // Split sequence to extract operators.   
          foreach (char operation in operators[0]) { operatorStack.Push(operation); } // Stack operators.


          // Set reverse polish visitor root Expression node initially.
          if (i == 0)
          {
            this.RootExpression = Expression.Constant(int.Parse(numbers[0]));
          }
          // Reset root Expression node while an operator and constant expression remains to join to it.
          else
          {
            do  // Check that there is an operator remaining to join constant expression to root node and join expression.
            {
              if (this.constantExpressionStack.Count > 0 && this.operatorStack.Count == 0)    // Not enough operators.
                throw new FormatException("Operators missing to join LHS constant expression to root expression.");
              if (this.constantExpressionStack.Count == 0 && this.operatorStack.Count > 1)    // Not enough constants.
                throw new FormatException("Constants missing to join LHS constant expression to root expression.");

              this.RootExpression = this.Visit(this.RootExpression);  // Iteratively modifies this builder's RootExpression.
            } while (operatorStack.Count != 0 || constantExpressionStack.Count != 0);
          }

          // Finally, check case for 2 numbers attached to operator(s) to add second number to empty constantStack 
          //    e.g. 2 3 9*+9 7-- 2 1 +*3 4-- contains 9*+9 and 7-- and +*3
          if (numbers.Length == 2)
            this.constantExpressionStack.Push(Expression.Constant(int.Parse(numbers[1])));
        }     
      }
    }

    /// <summary>
    /// Method used to join constant expressions with existing rootExpression for this visitor/builder.
    /// </summary>
    /// <param name="constantExpression"></param>
    /// <param name="v"></param>
    /// <returns></returns>
    private Expression JoinExpression(ConstantExpression constantExpression, char operation)
    {
     

      return null;
    }

    /// <summary>
    /// Method passes control of an expression node to correct method for visiting binary or constant
    /// expression nodes according to supported expression types required for operations 
    ///  +, -, *, /, and ^.
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public override Expression Visit(Expression node)
    {
      // Build binary expression by visiting root to create a new root expression based 
      // on constantExpression and operation passed in.
      char operation = this.operatorStack.Pop();
      switch (operation)
      {
        case '+':
          return Expression.MakeBinary(ExpressionType.Add, this.RootExpression, constantExpressionStack.Pop());
        case '-':
          return Expression.MakeBinary(ExpressionType.Subtract, this.RootExpression, constantExpressionStack.Pop());
        case '*':
          return Expression.MakeBinary(ExpressionType.Multiply, this.RootExpression, constantExpressionStack.Pop());
        case '/':
          return Expression.MakeBinary(ExpressionType.Divide, this.RootExpression, constantExpressionStack.Pop());
        case '^':
          return Expression.MakeBinary(ExpressionType.Power, this.RootExpression, constantExpressionStack.Pop());
        default:
          throw new FormatException("Never reached.");
      }
    }

    /// <summary>
    /// Visiting a binary expression node returns it in case it has a valid ExpressionType.
    /// Valid binary expression types are for operators +, -, *, /, and ^.
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    protected override Expression VisitBinary(BinaryExpression node)
    {
      switch (node.NodeType)
      {
        case ExpressionType.Add:
        case ExpressionType.Subtract:
        case ExpressionType.Multiply:
        case ExpressionType.Divide:
        case ExpressionType.Power:
          var right = this.Visit(node.Right);
          var left = this.Visit(node.Left);
          return Expression.MakeBinary(ExpressionType.Multiply, left, right);
        default:
          return base.VisitBinary(node);
      }
    }

    /// <summary>
    /// Visiting a constant expression returns it.
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    protected override Expression VisitConstant(ConstantExpression node) { return this.Visit(node); }
  }
}
