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

    public override Expression Visit(Expression node)
    {
      return base.Visit(node);
    }

    protected override Expression VisitBinary(BinaryExpression node)
    {
      return base.VisitBinary(node);
    }

    protected override Expression VisitConstant(ConstantExpression node)
    {
      return base.VisitConstant(node);
    }
  }
}
