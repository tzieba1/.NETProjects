using System;
using System.Linq.Expressions;

namespace ExpressionsExample
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an expression using System.Linq.Expressions that are constant and take objects.
      var constantStringExp = Expression.Constant("Constant Expression");
      Console.WriteLine(constantStringExp);
      var constantIntExp = Expression.Constant(10);
      Console.WriteLine(constantIntExp);


      // Build a function (essentially an expression) that can immediately take input 
      //  parameters of specified Type and returns the result of the lambda expression.
      Func<int, bool> myFunc = x => x == 5;
      Console.WriteLine(myFunc(5));

      // "Description" of an expression that must be compiled before supplying paramters.
      Expression<Func<int, bool>> myExpressionFunc = x => x == 5;
      var myCompiledExpFunc = myExpressionFunc.Compile();
      Console.WriteLine(myCompiledExpFunc(1));


      // BINARY EXPRESSIONS
      //  (x,y) => x*y;
      Expression<Func<int, int, int>> multiplyExp = (x, y) => x * y;

      // Create lambda expression more modularly by instantiating ANY parameters 
      //  and instantiating an expression for another total lambda expression
      var leftParamExp = Expression.Parameter(typeof(int), "x");
      var rightParamExp = Expression.Parameter(typeof(int), "y");
      var binaryExp = Expression.Multiply(leftParamExp, rightParamExp);
      //var otherBinary = Expression.MakeBinary(ExpressionType.Multiply, leftParamExp, leftParamExp);   //Equivalent outcome as line above.
      var lambdaExp = Expression.Lambda<Func<int, int, int>>(binaryExp, leftParamExp, rightParamExp);

      // Testing a compiled result for the lambda expression modularly created above using System.Linq.Expressions:
      //  DynamicInvoke() not needed here because types are provided in lambdaExp with Func<int, int, int>
      //  Otherwise, can use the non-generic Lambda(), but MUST use DynamicInvoke() without known types.
      //var dynamicallyTypedResult = lambdaExp.Compile().DynamicInvoke(2, 4);   
      var result = lambdaExp.Compile()(2, 4);
      Console.WriteLine(result);


      //====================================================================================================================================//

      //Testing the ExpressionVisit to change an expression tree.
      Expression<Func<string, bool>> andAlsoExp = e => e.Length > 10 && e.StartsWith("T");
      Console.WriteLine($"Original Expression: {andAlsoExp}");


      var andAlsoVisitor = new AndAlsoExpressionRewriter();
      var updatedExp = andAlsoVisitor.Visit(andAlsoExp);
      Console.WriteLine($"Updated Expression: {updatedExp}");
    }

    /// <summary>
    /// How to Use Expression Visitors to Change Expression Trees
    /// </summary>
    public class AndAlsoExpressionRewriter : ExpressionVisitor
    {
      // Must ovverride because already exists.
      public override Expression Visit(Expression node)
      {
        if (node == null)
        {
          return null;
        }

        switch (node.NodeType)
        {
          case ExpressionType.AndAlso:
            return this.VisitBinary((BinaryExpression)node);
          default:
            return base.Visit(node);
        }
      }

      // Must override this because is already exists.
      protected override Expression VisitBinary(BinaryExpression node)
      {
        if (node.NodeType != ExpressionType.AndAlso)
        {
          return base.VisitBinary(node);
        }

        // Building the binary expression
        var left = this.Visit(node.Left);
        var right = this.Visit(node.Right);

        // Checking for valid rhs and lhs and throw excpetion if invalid.
        if (left == null || right == null)
        {
          throw new InvalidOperationException("Unable to build binary expression");
        }

        // Change the expression tree at ths node and return modified expression for it
        return Expression.MakeBinary(ExpressionType.OrElse, left, right);
      }
    }
  }
}
