/// Author:           Tommy Zieba
/// Student Number:   000797152
/// 
/// I, Tommy Zieba, 000797152 certify that this material is my original work. 
/// No other person's work has been used without due acknowledgement.

using System;

namespace ReversePolishCalculator
{
  class Program
  {
    public static void Main(string[] args)
    {
      bool running = true;                // Flag used to remain in loop displaying options.
      bool menu = true;                   // Flag indicating menu visited.
      string userInput = string.Empty;    // Declaring the user input to be read from console.

      while(running)
      {
        try
        {
          Console.Clear();
          //TODO: displayMenu();


        }
        catch (FormatException ex)
        {
          Console.Clear();
          Console.WriteLine("\n\t" + 
            "\n\n\tMUST INPUT VALID EXPRESSION IN REVERSE POLISH NOTATION!" +
            "\n\n\tPRESS ANY KEY TO CONTINUE...");
          menu = true;
          Console.ReadKey();
        }
        catch(ArgumentOutOfRangeException ex)
        {
          Console.Clear();
          Console.WriteLine("\n\t" +
            "");
        }
      }
    }
  }
}
