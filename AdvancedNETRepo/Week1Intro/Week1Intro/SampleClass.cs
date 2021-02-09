using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Intro
{
  class SampleClass
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int AddTwoNumbers(int a, int b)
    {
      return a + b;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int MultiplyTwoNumbers(int a, int b)
    {
      return a * b;
    }

    /// <summary>
    /// Divisor cannot be zero.
    /// </summary>
    /// <param name="dividend"></param>
    /// <param name="divisor"></param>
    /// <returns></returns>
    public static decimal DivideTwoNumbers(int dividend, int divisor)
    {
      if(divisor == 0)
      {
        throw new ArgumentException("Cannot divide by zero!");
      } 
      
      return decimal.Divide(dividend, divisor);
    }
  }
}
