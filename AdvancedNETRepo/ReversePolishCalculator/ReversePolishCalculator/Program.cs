/// Author:           Tommy Zieba
/// Student Number:   000797152
/// 
/// I, Tommy Zieba, 000797152 certify that this material is my original work. 
/// No other person's work has been used without due acknowledgement.

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

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

      while (running)  // Loop until user enters 'exit'.
      {
        try
        {
          Console.Clear();
          userInput = PromptForExpression();  // Get user input expected to be a valid expression.
          if (!displayResult(userInput))      // Calculate and display result, then check return - to continue or not.
          {
            running = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tEXITING REVERSE POLISH CALCULATOR... GOODBYE!\n");
            Console.ForegroundColor = ConsoleColor.White;
          }
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
        catch (ArgumentOutOfRangeException ex)  // Thrown whenever provided an integer too large.
        {
          Console.Clear();
          Console.Beep();
          Console.WriteLine("\n\t" +
            "\n\n\tMUST INPUT VALID EXPRESSION WITH INTEGERS FROM -2,147,438,648 TO 2,147,483,647" +
            "\n\n\tPRESS ANY KEY TO CONTINUE...");
          Console.ReadKey();
        }
      }
    }

    /// <summary>
    /// Method that prompts a user to input an expression in reverse polish notation.
    /// </summary>
    /// <returns>Expected expression from user input into console.</returns>
    public static string PromptForExpression()
    {
      Console.WriteLine(
        " ---------------------------------------------------------------------------\n" +
        " |   PLEASE INPUT A VALID INTEGER EXPRESSION IN REVERSE POLISH NOTATION    |\n" +
        " ---------------------------------------------------------------------------\n");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(
        " |  NOTE: Whitespace ignored only around operators. Acceptable characters  |\n" +
        " |        are in the set {+, -, *, /, ^, , 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}   |\n" +
        " ---------------------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("\n  Example: ");
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.Write("15 7 1 1 + - / 3*2 1 1 ++ -\n\n");
      Console.ForegroundColor = ConsoleColor.White;
      Console.Write("\n  Enter Expression: ");
      return Console.ReadLine();
    }

    /// <summary>
    /// Method used to display the result of a valid mathematical expression in reverse polish notaion.
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns>Boolean representing user's decision to continue or exit the program.</returns>
    public static bool displayResult(string userInput)
    {
      Console.ReadKey();
      //TODO: Validate the expression input from the user.
      Expression validExpression = validateExpression(userInput);
      //TODO: Calculate result of he expression tree.
      double result = calculateExpression(userInput);

      // Display result and prompt for user to continue calculating other expressions or exiting.
      bool first = true;
      while (true)
      {
        if (first) { Console.WriteLine($"  Result: {result}"); }              // Only show result once.
        Console.Write("  Evaluate another reverse polish expression? (y/n)"); // Can repeatedly display.
        string userDecision = Console.ReadKey().KeyChar.ToString();         // Detect user keystroke.

        switch (userDecision.ToLower()) // Ensuring userDecision filtered to detect capital letters.
        {
          case "y":         // Return to prompt user for another expression (main prompt).
            return true;
          case "n":
            return false;   // Return to exit the program.
          default:
            Console.Write("  INVALID KEYSTROKE; TRY AGAIN.\n");
            first = false;  // Prompt user for another decision when keystroke is invalid.
            break;
        }
      }

    }

    /// <summary>
    /// Method that validates user input to be a proper expression in reverse polish notation and
    /// has integers within acceptable limits for the data type int.
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns></returns>
    private static Expression validateExpression(string userInput)
    {
      string validPattern = @"[\s\+\-\*\/\^0123456789]";      // Valid operators and digits in positive character group.
      string invalidPattern = @"[^\s\+\-\*\/\^0123456789]";   // Negation of valid character group (all other chars).

      if (Regex.IsMatch(userInput, validPattern) && !Regex.IsMatch(userInput, invalidPattern))  // Validate characters.
      {
        if (Regex.IsMatch(userInput[0].ToString(), @"[\d]"))  // Validate first character is integer.
        {
          Expression builtExpression = buildExpressionTree(userInput);
        }
        else
          throw new FormatException("Expression must start with number.");
      }
      else
        throw new FormatException("Invalid characters present.");

      return null;
    }

    /// <summary>
    /// Builds an expression tree from validated user input and returns it.
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns>Expression representing userInput.</returns>
    private static Expression buildExpressionTree(string userInput)
    {
      //int startIndex = 0;
      //while(currentIndex < userInput.Length && )

      //ReversePolishExpressionVisitor visitor = new ReversePolishExpressionVisitor(Expression.Constant((int)userInput[0]));
      //Expression builtExpression = Expression.Constant()

      //foreach (char character in userInput)  // Create and stack valid expressions by scanning userInput characters.
      //{

      //}

      return null;
    }

    /// <summary>
    /// Method that accepts an expression re
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns></returns>
    private static double calculateExpression(string userInput)
    {
      throw new NotImplementedException();
    }
  }
}
