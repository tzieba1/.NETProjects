/// Author:           Tommy Zieba
/// Student Number:   000797152
/// 
/// I, Tommy Zieba, 000797152 certify that this material is my original work. 
/// No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ReversePolishCalculator
{
  class Program
  {
    // Create stacks for expressions and re-evaluated expressions used to build an expression tree.
    Stack<Expression> expressionStack = new Stack<Expression>();
    Stack<Expression> updatedExpressionStack = new Stack<Expression>();

    public static void Main(string[] args)
    {
      bool running = true;                // Flag used to remain in loop displaying options.
      string userInput = string.Empty;    // Declaring the user input to be read from console.

      while(running)
      {
        try
        {
          Console.Clear();
          userInput = PromptForExpression();
          displayResult(userInput);
        }
        catch (FormatException ex)
        {
          Console.Clear();
          Console.Beep();
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\t" + 
            "\n\n\tMUST INPUT VALID EXPRESSION IN REVERSE POLISH NOTATION!" +
            "\n\n\tPRESS ANY KEY TO CONTINUE...");
          Console.ForegroundColor = ConsoleColor.White;
          Console.ReadKey();
        }
        catch(ArgumentOutOfRangeException ex)
        {
          Console.Clear();
          Console.Beep();
          Console.WriteLine("\n\t" +
            "");
        }
      }
    }

    /// <summary>
    /// Method that prompts a user to input an expression in reverse polish notation.
    /// </summary>
    /// <returns>Expected expression from user input into console.</returns>
    public static string PromptForExpression()
    {
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine(
        " -----------------------------------------------------------------------------\n" +
        " |  PLEASE INPUT A VALID MATHEMATICAL EXPRESSION IN REVERSE POLISH NOTATION  |\n" +
        " -----------------------------------------------------------------------------\n" +
        " |  NOTE: All whitespace around operators ignored and acceptable characters  |\n" +
        " |        are in the set {+, -, *, /, ^, , 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}     |\n" +
        " -----------------------------------------------------------------------------");
      Console.Write("\n  Example: ");
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.Write("15 7 1 1 + - / 3*2 1 1 ++ -\n\n");
      Console.ForegroundColor = ConsoleColor.White;
      return Console.ReadLine();
    }

    /// <summary>
    /// Method used to display the result of a valid mathematical expression in reverse polish notaion.
    /// </summary>
    /// <param name="userInput"></param>
    public static void displayResult(string userInput)
    {
      Console.ReadKey();
    }
  }
}
