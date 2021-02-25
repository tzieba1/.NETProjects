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
  /// <summary>
  /// A class inherited from ExpressionVisitor is modified to build and evaluate reverse polish expressions. It 
  /// has addtional properties and methods to accomplish this with overridden Visit and VisitBinary methods. In
  /// other words, the Visit method is used to build up an expression using terms expression passed into a property
  /// and the VisitBinary method is used to rescursively visit nodes from the built root expression and calculate
  /// a result obtainable via property. Built root expressions are also obtainable via property to write the infix
  /// notation version of the expression which uses brackets.
  /// 
  /// Main method for this Program runs the console to accept user input iteratively and calls on helper methods
  /// to generate/display prompts and results to users attempting to input valid reverse polish expressions.
  /// </summary>
  public class Program
  {
    /// <summary>
    /// Main method for this console program allows users to input mathematical expressions in reverse polish
    /// (postfix) notation with integer constants, acceptable operators {+, -, *, /, ^}, and whitespace. This program
    /// has a feature using some additional logic here, which allows user inputs with whitespace ignored around operators.
    /// </summary>
    /// <param name="args">Not used.</param>
    public static void Main(string[] args)
    {
      // Create a expression visitor/builder to be passed by reference.
      ReversePolishExpressionBuilder expressionBuilder = new ReversePolishExpressionBuilder();

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

          // Condition to either exit program or DisplayResult with prompt - following PromptForExpression.
          if (userInput.ToLower().Equals("exit") || !DisplayResult(ref expressionBuilder, userInput))
          {
            running = false;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n\tEXITING REVERSE POLISH CALCULATOR... GOODBYE!\n");
            Console.ResetColor();
          }
        }
        catch (FormatException ex)  // Thrown when attempted expression build has invalid characters or formatting.
        {
          Console.Clear();
          Console.Beep();
          Console.WriteLine($"\n\tError: {ex.Message}");

          expressionBuilder.Reset();  // Resets the builder after an error to accept other user input.
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\t" +
            "\n\n\tMUST INPUT VALID EXPRESSION IN REVERSE POLISH NOTATION!" +
            "\n\n\tPRESS ANY KEY TO CONTINUE...");
          Console.ResetColor();
          Console.ReadKey();
        }
        catch (ArgumentOutOfRangeException ex)  // Thrown whenever provided an integer too large.
        {
          Console.Clear();
          Console.Beep();
          Console.WriteLine($"\n\tError: {ex.Message}");

          expressionBuilder.Reset();  // Resets the builder after an error to accept other user input.
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine("\n\t" +
            "\n\n\tMUST INPUT VALID EXPRESSION WITH INTEGERS FROM -2,147,438,648 TO 2,147,483,647" +
            "\n\n\tPRESS ANY KEY TO CONTINUE...");
          Console.ResetColor();
          Console.ReadKey();
        }
      }
    }

    /// <summary>
    /// Method that prompts a user to input an expression in reverse polish notation or 'exit' to quit.
    /// </summary>
    /// <returns>Expected expression from user input into console.</returns>
    public static string PromptForExpression()
    {
      Console.WriteLine(
        "\n  ---------------------------------------------------------------------------\n" +
        "  |                                                                         |\n" +
        "  |   PLEASE INPUT A VALID INTEGER EXPRESSION IN REVERSE POLISH NOTATION    |\n" +
        "  |                                                                         |\n" +
        "  ---------------------------------------------------------------------------");
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine(
        "  |  NOTE: Whitespace ignored only around operators. Acceptable characters  |\n" +
        "  |        are in the set {+, -, *, /, ^, , 0, 1, 2, 3, 4, 5, 6, 7, 8, 9}.  |\n" +
        "  |  NOTE: Enter 'exit' to quit.                                            |\n" +
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
    /// <param name="userInput">To be evaluated as a boolean decision.</param>
    /// <returns>Boolean representing user's decision to continue or exit the program.</returns>
    public static bool DisplayResult(ref ReversePolishExpressionBuilder expressionBuilder, string userInput)
    {
      // Validate, build, and evaluate an expression from user input to be stored in the expressionBuilder.
      expressionBuilder.ExpressionString = userInput;

      // Display result and prompt for user to continue calculating other expressions or exiting.
      bool first = true;
      while (true)
      {
        if (first) { Console.WriteLine($"  Result: {expressionBuilder.Result}"); }  // Only show result once.
        Console.Write("\n  Evaluate another reverse polish expression? (y/n)");     // Can repeatedly display.
        Console.CursorLeft = 53;                                                    // Adjust cursor position.
        string userDecision = Console.ReadKey().KeyChar.ToString();                 // Detect user keystroke.

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
  }
}
