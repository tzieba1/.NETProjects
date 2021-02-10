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
  public class ReversePolishExpressionVisitor : ExpressionVisitor
  {
    /// <summary>
    /// Prooperty representing the root expression for this reverse polish expression tree visitor.
    /// </summary>
    public Expression rootExpression { get; set; }

    public ReversePolishExpressionVisitor() { }

    public ReversePolishExpressionVisitor(Expression root) { rootExpression = root; }

    /// <summary>
    /// Visiting an expression node returns it in case it has a valid ExpressionType.
    /// Valid expression types are for operators +, -, *, /, and ^.
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public override Expression Visit(Expression node)
    {
      // Set up a switch case that handles some binary math expressions and returns their visitor.
      switch (node.NodeType)
      {
        case ExpressionType.Add:
        case ExpressionType.Subtract:
        case ExpressionType.Multiply:
        case ExpressionType.Divide:
        case ExpressionType.Power:
          return this.VisitBinary((BinaryExpression)node);
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
