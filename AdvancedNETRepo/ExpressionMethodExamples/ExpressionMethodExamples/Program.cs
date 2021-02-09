using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ExpressionMethodExamples
{
  class Program
  {
    static void Main(string[] args)
    {
      // Building a method call expression from another method by getting the method ToLower().
      var parameterExpression = Expression.Parameter(typeof(string), "s");
      var methodCallExpression = Expression.Call(parameterExpression, typeof(string).GetMethod("ToLower", Type.EmptyTypes));

      // Note that dynamic types are not being used here.
      // var lambdaExpression = Expression.Lambda<Func<string, string>>(methodCallExpression, parameterExpression);
      var instanceLambdaExpression = Expression.Lambda(methodCallExpression, parameterExpression);

      // Invoking dynamically when a type is not specified in the lamdba exp[ression
      //var compiledLambdaExpression = lambdaExpression.Compile()("Test");
      var compiledInstanceLambdaExpression = instanceLambdaExpression.Compile().DynamicInvoke("Test");

      Console.WriteLine($"The result of invoking the lambda expression witrh the value 'Test': {compiledInstanceLambdaExpression}");

      // The next method call expression will be built with the method IsNullOrEmpty
      //string.IsNullOrEmpty("Test String");
      //string.IsNullOrEmpty("This is not empty");
      //string.IsNullOrEmpty(null);


      var staticMethodCallExpression = Expression.Call(typeof(string)
        .GetMethod("IsNullOrEmpty", new Type[] {typeof(string)}), new List<ParameterExpression> { parameterExpression});
      var staticLambdaExpression = Expression.Lambda(staticMethodCallExpression, parameterExpression);


      // Now the static compiled expression's invoked result can be returned.
      var compiledStaticLambdaExpression1 = staticLambdaExpression.Compile().DynamicInvoke("This is not empty");
      Console.WriteLine($"The result of invoking with 'This is not empty': {compiledStaticLambdaExpression1}");

      var compiledStaticLambdaExpression2 = staticLambdaExpression.Compile().DynamicInvoke(string.Empty);
      Console.WriteLine($"The result of invoking with string.Empty: {compiledStaticLambdaExpression2}");

      // Returns an error since cannot pass null arguments to invoke.
      //var compiledStaticLambdaExpression3 = staticLambdaExpression.Compile().DynamicInvoke(null);

      var compiledStaticLambdaExpression3 = staticLambdaExpression.Compile().DynamicInvoke(Expression.Constant(null).Value);
      Console.WriteLine($"The result of invoking with null string object: {compiledStaticLambdaExpression3}");


      //------------------------------------------------------------------------------------------------------------------------------//
      Console.WriteLine("\n \n \n  MATH EXPRESSION BUILDER");

      Expression<Func<double, double, double, double>> mathExpression = (a, b, c) => a * a + b * b - c * c;
      Console.WriteLine($"Original math expression: {mathExpression}");

      MathExpressionVisitor mathVisitor = new MathExpressionVisitor();
      var updatedMathExpression = mathVisitor.Visit(mathExpression);
      Console.WriteLine($"Updated math expression: {updatedMathExpression}");


    }
  }
}
