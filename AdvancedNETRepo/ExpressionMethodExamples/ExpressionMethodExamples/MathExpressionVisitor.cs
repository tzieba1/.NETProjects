using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExpressionMethodExamples
{
  /// <summary>
  /// Represents an expression visitor that rewrites math expressions.
  /// Replaces all math operators to multiplication.
  /// </summary>
  public class MathExpressionVisitor : ExpressionVisitor
  {
    public override Expression Visit(Expression node)
    {
      // Set up a switch case that handles some binary math expressions and returns their visitor.
      switch(node.NodeType)
      {
        case ExpressionType.Add:
        case ExpressionType.Subtract:
        case ExpressionType.Multiply:
        case ExpressionType.Divide:
        case ExpressionType.Modulo:
          return this.VisitBinary((BinaryExpression)node);
        default:
          return base.Visit(node);
      }
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
      switch(node.NodeType)
      {
        case ExpressionType.Add:
        case ExpressionType.Subtract:
        case ExpressionType.Multiply:
        case ExpressionType.Divide:
        case ExpressionType.Modulo:
          var right = this.Visit(node.Right);
          var left = this.Visit(node.Left);
          return Expression.MakeBinary(ExpressionType.Multiply, left, right);
        default:
          return base.VisitBinary(node);
      }
    }
  }
}
