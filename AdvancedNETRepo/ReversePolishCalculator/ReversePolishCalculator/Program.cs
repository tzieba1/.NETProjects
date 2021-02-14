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
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WindowWidth = 79;
      bool running = true;      // Flag used to remain in loop displaying options.
      string userInput;         // Declaring the user input to be read from console.

      // Loop until user enters 'exit' in expression prompt or chooses option 'n' to finish evaluating expressions.
      while (running)
      {
        try
        {
          Console.Clear();
          userInput = PromptForExpression();  // Get user input.

          // Stop running when user enters 'exit'.
          if (userInput.ToLower().Equals("exit"))   
            running = false;
          // Calculate and display result and check return - to continue running or not.
          else if (!displayResult(userInput))
          {
            running = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tEXITING REVERSE POLISH CALCULATOR... GOODBYE!\n");
          }
        }
        catch (FormatException ex)
        {
          Console.Clear();
          Console.Beep();
          Console.WriteLine($"\n\tError: {ex.Message}");
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
          Console.WriteLine($"\n\tError: {ex.Message}");
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
        "\n  ---------------------------------------------------------------------------\n" +
        "  |   PLEASE INPUT A VALID INTEGER EXPRESSION IN REVERSE POLISH NOTATION    |\n" +
        "  ---------------------------------------------------------------------------\n");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(
        "  |  NOTE: Whitespace ignored only around operators. Acceptable characters  |\n" +
        "  |        are in the set {+, -, *, /, ^, , 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}   |\n" +
        "  ---------------------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write("\n  Example:\t15 7 1 1 + - / 3*2 1 1 ++ -\n");
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
      validateCharacters(userInput);  // Validate characters in expression from user input.
      ReversePolishExpressionBuilder expressionBuilder = new ReversePolishExpressionBuilder(userInput);

      //TODO: Calculate result of expression tree using current RootExpression from expression builder.
      double result = calculateExpression(expressionBuilder.RootExpression);

      // Display result and prompt for user to continue calculating other expressions or exiting.
      bool first = true;
      while (true)
      {
        if (first) { Console.WriteLine($"  Result: {result}"); }                // Only show result once.
        Console.Write("\n  Evaluate another reverse polish expression? (y/n)"); // Can repeatedly display.
        Console.CursorLeft = 53;                                                // Adjust cursor position.
        string userDecision = Console.ReadKey().KeyChar.ToString();             // Detect user keystroke.

        switch (userDecision.ToLower()) // Ensuring userDecision filtered to detect capital letters.
        {
          case "y":         // Return to prompt user for another expression (main prompt).
            return true;
          case "n":
            return false;   // Return to exit the program.
          default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\n  INVALID KEYSTROKE; TRY AGAIN.\n");
            Console.ForegroundColor = ConsoleColor.White;
            first = false;  // Prompt user for another decision when keystroke is invalid.
            break;
        }
      }

    }

    /// <summary>
    /// Method that validates user input as an expression in reverse polish notation and has integers within acceptable limits.
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns></returns>
    private static void validateCharacters(string userInput)
    {
      string validPattern = @"[\s\+\-\*\/\^0123456789]";      // Valid operators, numbers, and whitespace in positive character group.
      string invalidPattern = @"[^\s\+\-\*\/\^0123456789]";   // Negation of valid character group (all other chars).

      // Validate characters (whitespace, numbers, operators).
      if (Regex.IsMatch(userInput, validPattern) && !Regex.IsMatch(userInput, invalidPattern))  
      {
        // Validate first non-whitespace character of user input is a number.
        if (!Regex.IsMatch(userInput, @"^\s*[\d]"))
          throw new FormatException("Expression must start with number.");

        // Validate last non-whitespace character of user input is an operator.
        if (!Regex.IsMatch(userInput, @"[\+\-\*\/\^]\s*$"))
          throw new FormatException("Expression must end with an operator.");
      }
      else
        throw new FormatException("Invalid characters present.");
    }

   

    /// <summary>
    /// Method that accepts an expression
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns></returns>
    private static double calculateExpression(Expression expressionTree)
    {
      return 0.0;
    }
  }
}
