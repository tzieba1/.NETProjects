//*** I, Tommy Zieba, 000797152 certify that this material is my original work. 
//    No other person's work has been used without due acknowledgement.
//    
//    Date: October 4, 2019.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
  {
  class AcmeShapeBuilder
    {
    /* Counts the exceptions affecting the privately set static Count property for any shape
     * being constructed in a try-catch.The Count is incremented whenever constructing the 
     * base class of any shape which occurs before any exception is thrown.
     * Used when retreiving shapes from a List with indices determined by the Count property.
     */
    private static int exceptionCount = 0;
    /* A flag indicating if exceptions occur in the main menu or in the dimension menu. */
    private static bool menuException = false;
    /* List of shapes for this console program building and stores shapes, areas, and volumes. */
    private static List<Shape> shapes = new List<Shape>();
    /* Flag for loop prompting shapes menu instead of dimensions. */
    private static bool menuPrompt = true;
    /* Static dimensions to be used for temporary storage before construction. */
    private static double length, width, height, majorRadius, minorRadius;

    //Static main-menu to be re-used and not modified.
    private static string menu =  "   {========================}\n" +
                                  "   |   ACME SHAPE BUILDER   |\n" +
                                  "   {========================}\n" +
                                  "   |      Option Menu       |\n" +
                                  "  \\------------------------/\n" +
                                  "   |  1.   Rectangle        |\n" +
                                  "   |  2.   Square           |\n" +
                                  "   |  3.   Box              |\n" +
                                  "   |  4.   Cube             |\n" +
                                  "   |  5.   Ellipse          |\n" +
                                  "   |  6.   Circle           |\n" +
                                  "   |  7.   Cylinder         |\n" +
                                  "   |  8.   Sphere           |\n" +
                                  "   |  9.   Triangle         |\n" +
                                  "   | 10.   Tetrahedron      |\n" +
                                  "   | 11.   List Shapes      |\n" +
                                  "   | 12.   Exit             |\n" +
                                  "  \\------------------------/\n";

    //Static dimension menu banner to be re-used and not modified.
    private static string dimensionsBanner = "   {========================}\n" +
                                             "   |   ACME SHAPE BUILDER   |\n" +
                                             "   {========================}\n" +
                                             "   |       Dimensions       |\n" +
                                             "  \\------------------------/\n";


    /* Increasing exception count ONLY from dimension menu since attempted construction
           * occurs there and interferes with the static Count property for Shape base class.
           */
    /// <summary>
    ///    Method used for increasing exception count ONLY from dimension menu since attempted 
    ///    construction occurs there and interferes with the static <c>Count</c> property
    ///    for <c>Shape</c> base class. The difference between <c>exceptionCount</c> and 
    ///    <c>Shape.Count</c> is equal to the number of actually constructed shapes.
    /// </summary>
    private static void exceptionCountIncrement()
      {
      if (!menuException)
        exceptionCount++; 
      menuException = false; //Resetting menuException flag.
      Console.Clear();  //Clears console before displaying eror message.
      }
    /// <summary>
    ///   Static method used each time a shape is successfully constructed and added to 
    ///   <c>shapes</c>. Displays a message with <c>ToString()</c> of the shape instance
    ///   being constructed.
    /// </summary>
    private static void WriteSuccessMessage()
      {
      Console.Clear();  //Clears console before displaying message.
      Console.WriteLine($"\n  ACME BUILD SUCCESS!\n\n" +
      $"  ADDED TO LIST:\n" +
      $"  \t{shapes[shapes.Count - 1].ToString()}\n\n" +
      $"  PRESS RETURN KEY TO CONTINUE BUILDING SHAPES!");
      Console.ReadLine(); //'ReadLine' from user remains until return entered - displays message.
      menuPrompt = true;  //Set flag for menu prompt to loop until another option is selected.
      }

    /// <summary>
    ///   Static method used to prompt the user for a length and store valid input. 
    /// </summary>
    /// <remarks>
    ///   Modularizes prompts to user for shape dimensions since shapes abstraction occurs
    ///   as restrictions are added to the shape dimensions - which determine area and volume.
    /// </remarks>
    private static void PromptLength()
      {
      Console.WriteLine("   | Provide a positive     |\n" +
                        "   | non-zero length:       |\n");
      length = double.Parse(Console.ReadLine());  //Catches format and out of range exception.
      }

    /// <summary>
    ///   Static method used to prompt the user for a width and store valid input. 
    /// </summary>
    /// <remarks>
    ///   Modularizes prompts to user for shape dimensions since shapes abstraction occurs
    ///   as restrictions are added to the shape dimensions - which determine area and volume.
    /// </remarks>
    private static void PromptWidth()
      {
      Console.WriteLine("   | Provide a positive     |\n" +
                        "   | non-zero width:        |\n");
      width = double.Parse(Console.ReadLine()); //Catches format and out of range exception.
      }

    /// <summary>
    ///   Static method used to prompt the user for a height and store valid input. 
    /// </summary>
    /// <remarks>
    ///   Modularizes prompts to user for shape dimensions since shapes abstraction occurs
    ///   as restrictions are added to the shape dimensions - which determine area and volume.
    /// </remarks>
    private static void PromptHeight()
      {
      Console.WriteLine("   | Provide a positive     |\n" +
                        "   | non-zero height:       |\n");
      height = double.Parse(Console.ReadLine());  //Catches format and out of range exception.
      }

    /// <summary>
    ///   Static method used to prompt the user for a major radius and store valid input. 
    /// </summary>
    /// <remarks>
    ///   Modularizes prompts to user for shape dimensions since shapes abstraction occurs
    ///   as restrictions are added to the shape dimensions - which determine area and volume.
    /// </remarks>
    private static void PromptMajorRadius()
      {
      Console.WriteLine("   | Provide a positive     |\n" +
                        "   | non-zero major radius: |\n");
      majorRadius = double.Parse(Console.ReadLine()); //Catches format and out of range exception.
      }




    /*********************************************************************************************/
    /******************************            MAIN              *********************************/
    /*********************************************************************************************/

    /// <summary>
    ///   Static method used to prompt the user for a minor radius and store valid input. 
    /// </summary>
    /// <remarks>
    ///   Modularizes prompts to user for shape dimensions since shapes abstraction occurs
    ///   as restrictions are added to the shape dimensions - which determine area and volume.
    /// </remarks>
    private static void PromptMinorRadius()
      {
      Console.WriteLine("   | Provide a positive     |\n" +
                        "   | non-zero minor radius: |\n");
      minorRadius = double.Parse(Console.ReadLine()); //Catches format and out of range exception.
      }

    /// <summary>
    ///   Main static method used for this AcmeShapeBuilder console program to execute.
    /// </summary>
    /// <param name="args">Unused.</param>
    static void Main(string[] args)
      {
      int option = 0; //Must initialize the option to zero.
      bool running = true;  //The boolean flag maintaining prompt of menu to user.

     
      while (running)
        {
        /* Exception handling is done by wrapping all prompting with this try-catch. */
        try
          {
          while (menuPrompt)
            {
            Console.Clear();          //Clear before re-prompting main menu.
            Console.WriteLine(menu);  //Display static main menu.
            //Validate the option to be in [1,12] or throw an exception otherwise.
            option = int.Parse(Console.ReadLine());
            if (option > 12 || option < 0)
              {
              menuException = true;
              throw new ArgumentOutOfRangeException("","  Option must be in range [1,12].");
              }
            menuPrompt = false;       //Turn off main menu prompt to display dimension menu.
            }

          Console.Clear();  //Clear Console to display dimensions menu.
          Console.WriteLine(dimensionsBanner);  //Display static dimension banner.

          /* Switching through various dimension menu prompts based on shape option.
           * Different prompts are static methods that write to console. In each case
           * a description of the dimension restrictions for inoput is displayed.
           */
          switch (option)
            {
            case 0: // Case for initialized option when starting program (takes place of default).
              Console.Clear();
              menuPrompt = true;
              break;
            case 1:
              Console.WriteLine("   |************************|\n" +
                                "   |        Rectangle       |\n" +
                                "   |************************|\n" +
                                "   |    length and width    |\n" +
                                "   |________________________|\n");
              PromptLength(); 
              PromptWidth();
              shapes.Add(new Rectangle(length, width));
              WriteSuccessMessage();
              break;
            case 2:
              Console.WriteLine("   |************************|\n" +
                                "   |         Square         |\n" + 
                                "   |************************|\n" +
                                "   |     length = width     |\n" +
                                "   |________________________|\n");
              PromptLength();
              shapes.Add(new Square(length));
              WriteSuccessMessage();
              break;
            case 3:
              Console.WriteLine("   |************************|\n" +
                                "   |          Box           |\n" + 
                                "   |************************|\n" +
                                "   | length, width, height  |\n" +
                                "   |________________________|\n");
              PromptLength();
              PromptWidth();
              PromptHeight();
              shapes.Add(new Box(length, width, height));
              WriteSuccessMessage();
              break;
            case 4:
              Console.WriteLine("   |************************|\n" +
                                "   |          Cube          |\n" + 
                                "   |************************|\n" +
                                "   |length = wdith = height |\n" +
                                "   |________________________|\n");
              PromptLength();
              shapes.Add(new Cube(length));
              WriteSuccessMessage();
              break;
            case 5:
              Console.WriteLine("   |************************|\n" +
                                "   |         Ellipse        |\n" + 
                                "   |************************|\n" +
                                "   | major and minor radius |\n" +
                                "   |________________________|\n");
              PromptMajorRadius();
              PromptMinorRadius();
              shapes.Add(new Ellipse(majorRadius, minorRadius));
              WriteSuccessMessage();
              break;
            case 6:
              Console.WriteLine("   |************************|\n" +
                                "   |         Circle         |\n" + 
                                "   |************************|\n" +
                                "   |      major radius      |\n" +
                                "   |           =            |\n" +
                                "   |      minor radius      |\n" +
                                "   |________________________|\n");
              PromptMajorRadius();
              shapes.Add(new Circle(majorRadius));
              WriteSuccessMessage();
              break;
            case 7:
              Console.WriteLine("   |************************|\n" +
                                "   |        Cylinder        |\n" + 
                                "   |************************|\n" +
                                "   |       length and       |\n" +
                                "   |      major radius      |\n" +
                                "   |           =            |\n" +
                                "   |      minor radius      |\n" +
                                "   |________________________|\n");
              PromptMajorRadius();
              PromptLength();
              shapes.Add(new Cylinder(majorRadius, length));
              WriteSuccessMessage();
              break;
            case 8:
              Console.WriteLine("   |************************|\n" +
                                "   |         Sphere         |\n" + 
                                "   |************************|\n" +
                                "   |      major radius      |\n" +
                                "   |           =            |\n" +
                                "   |      minor radius      |\n" +
                                "   |           =            |\n" +
                                "   |     tertiary radius    |\n" +
                                "   |________________________|\n");
              PromptMajorRadius();
              shapes.Add(new Sphere(majorRadius));
              WriteSuccessMessage();
              break;
            case 9:
              Console.WriteLine("   |************************|\n" +
                                "   |        Triangle        |\n" + 
                                "   |************************|\n" +
                                "   |equilateral side length |\n" +
                                "   |________________________|\n");
              PromptLength();
              shapes.Add(new Triangle(length));
              WriteSuccessMessage();
              break;
            case 10:
              Console.WriteLine("   |************************|\n" +
                                "   |       Tetrahedron      |\n" + 
                                "   |************************|\n" +
                                "   |equilateral side length |\n" +
                                "   |________________________|\n");
              PromptLength();
              shapes.Add(new Tetrahedron(length));
              WriteSuccessMessage();
              break;
            case 11:    //Case for listing constructed shapes in a table.
              Console.Clear();  
              //Table headings.
              Console.WriteLine($"\n {"|  Shape Type  ",16} |{" Surface Area ",16}|" +
                                $"{"    Volume    |",16}\n" +
                                $"  {"================",16} {"================",16} " +
                                $"{"================",16}");
              //Looping to tabulate shapes in formatted string by using accessors and properties.
              foreach (Shape shape in shapes)
                {
                Console.WriteLine($"  |{shape.Type,-14} | {shape.CalculateArea(),14:F4} " +
                                  $"|{shape.CalculateVolume(),14:F4} |\n" +
                                  $"  --------------------------------------------------");
                }
              Console.WriteLine("\n\n  [PRESS ENTER TO CONTINUE BUILDING SHAPES!]");
              Console.ReadLine();
              menuPrompt = true;
              break;
            case 12:
              running = false;  //Ending the enclosing prompting loop.
              break;
            }
          }
        //Catches exception thrown with message if user inputs non-negative numbers or zero.
        catch (ArgumentOutOfRangeException e)
          {
          /* Increasing exception count ONLY from dimension menu since attempted construction
          * occurs there and interferes with the static Count property for Shape base class.
          */
          if (!menuException)
            exceptionCount++;
          menuException = false; //Resetting menuException flag.
          Console.Clear();
          Console.WriteLine("   |************************|\n" +
                            "   |      Out of range!     |\n" +
                            "   |________________________|\n" +
                            "   |                        |\n" +
                            "   | PRESS RETURN TO RETRY  |\n" +
                            "   |________________________|\n\n" +
                            e.Message);
          Console.ReadLine();
          continue;
          }
        //Catches exception thrown with message if user provides a non-numeric input.
        catch (FormatException e)
          {
          
          Console.WriteLine("   |************************|\n" +
                            "   |   Not a valid number!  |\n" +
                            "   |________________________|\n" +
                            "   |                        |\n" +
                            "   | PRESS RETURN TO RETRY  |\n" +
                            "   |________________________|\n\n" +
                            e.Message);
          Console.ReadLine();
          continue;
          }
        }
      }
    }
  }
