/// Author:           Tommy Zieba
/// Student Number:   000797152
/// 
/// I, Tommy Zieba, 000797152 certify that this material is my original work. 
/// No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReversePolishCalculator
{
  /// <summary>
  /// Expression visitor used to build reverse polish expressions by accepting string input from console.
  /// </summary>
  public class ReversePolishExpressionVisitor : ExpressionVisitor
  {
    /// <summary>
    /// Prooperty representing the root expression for this reverse polish expression tree visitor.
    /// Note that this must be reset after partial expressions are parsed and appended to the 
    /// expression tree being built.
    /// </summary>
    public Expression rootExpression { get; set; }

    /// <summary>
    /// Current expression tree representing 
    /// </summary>
    public Stack<Expression> fullExpressionTree = new Stack<Expression>();
    
    /// <summary>
    /// Constants to be formulated into an expression top be appended to current expression tree.
    /// </summary>
    private Stack<ConstantExpression> partialExpressionTree = new Stack<ConstantExpression>();

    /// <summary>
    /// Default constructor.
    /// </summary>
    public ReversePolishExpressionVisitor() { }

    /// <summary>
    /// Constructor that accepts a root node (constant expression) to begin building a reverse
    /// polish expression. Root assigned to partialExpressionStack until first operator reached.
    /// </summary>
    /// <param name="root"></param>
    public ReversePolishExpressionVisitor(ConstantExpression root) 
    { 
      rootExpression = root; 
      partialExpressionTree.Push(root); 
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
      switch (node.NodeType)  // Handle cases for supported constant and binary expression types.
      {
        case ExpressionType.Add:
        case ExpressionType.Subtract:
        case ExpressionType.Multiply:
        case ExpressionType.Divide:
        case ExpressionType.Power:
          return this.VisitBinary((BinaryExpression)node);  // Passes node to binary visitor.
        case ExpressionType.Constant:
          return this.VisitConstant((ConstantExpression)node);  // Passes node to constant visitor.
        default:
          return base.Visit(node);
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
