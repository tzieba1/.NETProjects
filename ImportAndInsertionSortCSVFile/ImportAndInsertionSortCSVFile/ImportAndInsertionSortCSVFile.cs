using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportAndInsertionSortCSVFiles
  {
  /// <summary>
  ///   This class is a console program object with a Main method that executes a console application.
  ///   This console application sorts and displays employee information in a table by prompting a user
  ///   in the console to provide a selection of how employees are sorted based on numbered menu options.
  /// </summary>
  class Program
    {
    /// <summary>
    ///   This method is accessed in the encapsulating Main method. Its purpose is to access 
    ///   the 'employees.csv' file found in the same directory as this Program class. Each 
    ///   line of the file is read and the comma separated values are used to create and store
    ///   employees up to a maximum of 100 employees.
    /// </summary>
    ///
    /// <exception cref="System.Exception.FileNotFoundException">
    ///   Thrown when 'employees.csv' not found in the same directory as 'Program.cs'.
    /// </exception>
    /// <exception cref="System.Exception.FormatException">
    ///   Thrown when format of 'employees.csv' is not correct for some <c>lineNumber</c>.
    /// </exception>"
    ///
    /// <returns>
    ///   An array of type Employee[] corresponding to first 100 employees in 'employees.csv'.
    /// </returns>
    static Employee[] Read()
      {
      string line = ""; //Declare and initialize a line to be read.
      int lineNumber = 0; //Corresponds to array indices for storing line values as Employee.
      Employee[] importedEmployees = new Employee[100]; //Corresponds to final array of 100 employees.

      //*** Reading a file is wrapped in a try-catch for exceptions raised while accessing or reading contents.
      try
        {
        StreamReader fileInput = new StreamReader("employees.csv"); //StreamReader has methods used for reading.

        //*** Loop iterates through 'employees.csv' until the file has no lines left or at the 100th 
        //    line. Each line is read and stored by splitting lines at comma delimited employee 
        //    values (elements). Each line's elements are used to store an employee in the 
        //    importedEmployees array. 
        while (!fileInput.EndOfStream && lineNumber < 100)
          {
          line = fileInput.ReadLine();  //Reading a line.
          string[] lineElement = line.Split(','); //Splitting a line at commas.

          //*** Using line elements from current lineNumber to create an employee in importedEmployees.
          importedEmployees[lineNumber] = new Employee(lineElement[0],
            int.Parse(lineElement[1]), decimal.Parse(lineElement[2]), double.Parse(lineElement[3]));
          lineNumber++;
          //*** Message to user warning about exceeding 100 employees before terminating this reading method.
          if (lineNumber == 100)
            {
            Console.WriteLine("\n\nWARNING: Maximum of 100 employees can be stored and 'employees.csv'" +
            " exceeds this. Only first 100 employees will be stored.\n\n");
            }
          }
        //*** Message indicating how many employees were successfully imported.
        Console.WriteLine($"NOTE: {lineNumber} employees successfully imported from 'employees.csv'!\n\n");
        }
      catch (FileNotFoundException ex)
        {
        //*** Displaying error message with exception message.
        Console.WriteLine($"Could not find file 'employees.csv': {ex.Message}");
        }
      catch (FormatException ex)
        {
        //*** Displaying error message with exception message.
        Console.WriteLine($"Error on line {lineNumber + 1} reading line {line}: {ex.Message}");
        }
      return importedEmployees;
      }

    /// <summary>
    ///   This method sorts employees in ascending or descending order based on menu option criteria
    ///   the sorting algorithm used is an insertion sort (Biggs, 2009, pp.173-176). 
    /// </summary>
    /// <remarks> 
    ///   References:
    ///   Biggs, N. (2009). Discrete mathematics. Oxford: Oxford Univ. Press.
    /// </remarks>
    ///
    /// <param name="employees">
    ///   Array initially storing unsorted employees of type <typeparamref name="employees"/>".
    /// </param>
    /// <typeparam name="employees">Employee[]</typeparam>
    /// 
    /// <param name="sortOption">
    ///   The corresponding menu option of type <typeparamref name="sortOption"/>
    ///   selected for a particular sort criteria.
    /// </param>
    /// <typeparam name="sortOption">int</typeparam>
    ///
    /// <returns>
    ///   Sorted array <paramref name="employees"/>. 
    /// </returns>
    static Employee[] Sort(Employee[] employees, int sortOption)
      {
      //*** Switching sorting algorithms based on the sorting criteria selected by the user input.
      //    The insertion sorting algorithm's nested comparison of employee attributes is changed 
      //    depending on the sortOption selected by user input.
      switch (sortOption)
        {
        //*** Sorting by employee name (ascending).
        case 1:

          //*** Nested for loop, outer loop takes a check-employee from first to last array index
          //    and compares name to currently 'pushed' employees. Pushed-employees begin at the 
          //    first array index and increment each time a check-employee has been inserted.
          //    Pushing an employee represents comparing names and swapping in the nested for loop.
          //    Each time a comparison and possible swap occurs, the nested for loop increments 
          //    to compare names of each pushed-employee with the 'fixed' check-employee name.
          for (int i = 1; i < employees.Length; i++)
            {
            //*** Nested for loop takes check employee and compares to push employees by incrementing
            //    i downward from check employee index after each comparison and possible push.
            for (int j = i; j >= 1; j--)
              {
              //*** Condition to handle null elements when less than 100 employees are listed.
              if (employees[i] != null)
                {
                if (employees[j - 1].GetName().CompareTo(employees[j].GetName()) >= 0 && i > 0)
                  {
                  Employee tempEmployee = employees[j - 1]; //Temporary employee used to hold pushed employee.
                  employees[j - 1] = employees[j];  //Swapping check employee.
                  employees[j] = tempEmployee;  //Swapping pushed employee.
                  }

                //*** Stops comparing employees when check employee cannot be pushed anymore.
                else
                  break;
                }
              }
            }
          break;

        //*** Sorting by employee number (ascending).
        case 2:

          //*** Nested for loop, outer loop takes a check-employee from first to last array index
          //    and compares number to currently 'pushed' employees. Pushed-employees begin at the 
          //    first array index and increment each time a check-employee has been inserted.
          //    Pushing an employee represents comparing numbers and swapping in the nested for loop.
          //    Each time a comparison and possible swap occurs, the nested for loop increments 
          //    to compare numbers of each pushed-employee with the 'fixed' check-employee number.
          for (int i = 1; i < employees.Length; i++)
            {
            //*** Nested for loop takes check employee and compares to push employees by incrementing
            //    i downward from check employee index after each comparison and possible push.
            for (int j = i; j >= 1; j--)
              {
              //*** Condition to handle null elements when less than 100 employees are listed.
              if (employees[i] != null)
                {
                if (employees[j - 1].GetNumber().CompareTo(employees[j].GetNumber()) >= 0 && i > 0)
                  {
                  Employee tempEmployee = employees[j - 1]; //Temporary employee used to hold pushed employee.
                  employees[j - 1] = employees[j];  //Swapping check employee.
                  employees[j] = tempEmployee;  //Swapping pushed employee.
                  }

                //*** Stops comparing employees when check employee cannot be pushed anymore.
                else
                  break;
                }
              }
            }
          break;

        //*** Sorting by employee rate (decending).
        case 3:

          //*** Nested for loop, outer loop takes a check-employee from first to last array index
          //    and compares rate to currently 'pushed' employees. Pushed-employees begin at the 
          //    first array index and increment each time a check-employee has been inserted.
          //    Pushing an employee represents comparing rates and swapping in the nested for loop.
          //    Each time a comparison and possible swap occurs, the nested for loop increments 
          //    to compare rates of each pushed-employee with the 'fixed' check-employee rate.
          for (int i = 1; i < employees.Length; i++)
            {
            //*** Nested for loop takes check employee and compares to push employees by incrementing
            //    i downward from check employee index after each comparison and possible push.
            for (int j = i; j >= 1; j--)
              {
              //*** Condition to handle null elements when less than 100 employees are listed.
              if (employees[i] != null)
                {
                if (employees[j - 1].GetRate().CompareTo(employees[j].GetRate()) <= 0 && i > 0)
                  {
                  Employee tempEmployee = employees[j - 1]; //Temporary employee used to hold pushed employee.
                  employees[j - 1] = employees[j];  //Swapping check employee.
                  employees[j] = tempEmployee;  //Swapping pushed employee.
                  }

                //*** Stops comparing employees when check employee cannot be pushed anymore.
                else
                  break;
                }
              }
            }
          break;
        //*** Sorting by employee hours (descending).
        case 4:

          //*** Nested for loop, outer loop takes a check employee from first to last array index
          //    and compares hours to currently 'pushed' employees. Pushed-employees begin at the 
          //    first array index and increment each time a check-employee has been inserted.
          //    Pushing an employee represents comparing hours and swapping in the nested for loop.
          //    Each time a comparison and possible swap occurs, the nested for loop increments 
          //    to compare hours of each pushed-employee with the 'fixed' check-employee hours.
          for (int i = 1; i < employees.Length; i++)
            {
            //*** Nested for loop takes check employee and compares to push employees by incrementing
            //    i downward from check employee index after each comparison and possible push.
            for (int j = i; j >= 1; j--)
              {
              //*** Condition to handle null elements when less than 100 employees are listed.
              if (employees[i] != null)
                {
                if (employees[j - 1].GetHours().CompareTo(employees[j].GetHours()) <= 0 && i > 0)
                  {
                  Employee tempEmployee = employees[j - 1]; //Temporary employee used to hold pushed employee.
                  employees[j - 1] = employees[j];  //Swapping check employee.
                  employees[j] = tempEmployee;  //Swapping pushed employee.
                  }

                //*** Stops comparing employees when check employee cannot be pushed anymore.
                else
                  break;
                }
              }
            }
          break;

        //*** Sorting by employee gross (descending).
        case 5:

          //*** Nested for loop, outer loop takes a check-employee from first to last array index
          //    and compares gross pay to currently 'pushed' employees. Pushed-employees begin at the 
          //    first array index and increment each time a check-employee has been inserted.
          //    Pushing an employee represents comparing gross pay and swapping in the nested for loop.
          //    Each time a comparison and possible swap occurs, the nested for loop increments 
          //    to compare gross pay of each pushed-employee with the 'fixed' check-employee gross pay.
          for (int i = 1; i < employees.Length; i++)
            {
            //*** Nested for loop takes check employee and compares to push employees by incrementing
            //    i downward from check employee index after each comparison and possible push.
            for (int j = i; j >= 1; j--)
              {
              //*** Condition to handle null elements when less than 100 employees are listed.
              if (employees[i] != null)
                {
                if (employees[j - 1].GetGross().CompareTo(employees[j].GetGross()) <= 0 && i > 0)
                  {
                  Employee tempEmployee = employees[j - 1]; //Temporary employee used to hold pushed employee.
                  employees[j - 1] = employees[j];  //Swapping check employee.
                  employees[j] = tempEmployee;  //Swapping pushed employee.
                  }

                //*** Stops comparing employees when check employee cannot be pushed anymore.
                else
                  break;
                }
              }
            }
          break;
        }

      return employees;
      }

    /// <summary>
    ///   Main method that runs this console application for importing and sorting employee information 
    ///   from a file. Comma delimited file contents correspond to private variables of the <c>Employee</c> 
    ///   class initialized upon construction. A maximum of 100 employees may be stored from the file.
    ///   A user is continuously promted with a menu that has integer numbered options with sorting criteria. 
    ///   The user can select the options to display the corresponding sorted table of employees or 
    ///   quit the console application.
    /// </summary>
    /// 
    /// <exception cref="System.Exception.FormatException">
    ///     Thrown when the user inputs an option that is not an integer.
    /// </exception>
    /// 
    /// <param name="args">Unused.</param>
    static void Main(string[] args)
      {


      Employee[] unsortedEmployees = Read();  //Declaring a list ofunsorted employees to be read in.
      Employee[] sortedEmployees = new Employee[100]; //Declaring a list of employees returned after sorting.
      bool running = true;  //Flag indicating the user needs to be prompted the menu.
      bool outputTable;  //Flag indicating if a sorted table should be outputted.
      int option; //Declaring the menu option to be selected by user.

      //*** Loop which prompts the menu to the user iteratively until raising the running flag.
      while (running)
        {
        //*** Menu displayed to user to select options.
        Console.WriteLine(" EMPLOYEE MENU\n" +
                          "===============\n\n" +
                          "1. Sort by Employee Name (ascending)\n" +
                          "2. Sort by Employee Number (ascending)\n" +
                          "3. Sort by Employee Pay Rate (descending)\n" +
                          "4. Sort by Employee Hours (descending)\n" +
                          "5. Sort by Employee Gross Pay (descending)\n" +
                          "6. Exit\n\n" +
                          "Enter an option: ");
        outputTable = true; //A table must be outputted unless user inputs incorrect integer.

        //*** Validating user input to be an integer by catching a FormatException.
        try
          {
          option = int.Parse(Console.ReadLine()); //Attempting to parse user input as an integer.
          }
        //*** Raises exception whenever user input not an integer.
        catch (FormatException ex)
          {
          Console.WriteLine("\nNot an integer. Try Again.\n");  //Prompt user to try inputting another integer.
          continue;
          }

        //*** Switch cases based on the option which was read from the console as user input.
        //    When a valid option is input by the user, a table displaying the approriately sorted
        //    employees based on the corresponding case here that sorts the unsortedEmployees.
        switch (option)
          {
          //*** Sorting by employee name (ascending).
          case 1:
            Console.WriteLine("\nEmployees by Name (Ascending Order):\n"); //Sorted table heading.
            sortedEmployees = Sort(unsortedEmployees, option);
            break;

          //*** Sorting by employee number (ascending).
          case 2:
            Console.WriteLine("\nEmployees by Number (Ascending Order):\n");  //Sorted table heading.
            sortedEmployees = Sort(unsortedEmployees, option);
            break;

          //*** Sorting by employee rate (decending).
          case 3:
            Console.WriteLine("\nEmployees by Pay Rate (Descending Order):\n"); //Sorted table heading.
            sortedEmployees = Sort(unsortedEmployees, option);
            break;
          //*** Sorting by employee hours (descending).
          case 4:
            Console.WriteLine("\nEmployees by Hours (Descending Order):\n");  //Sorted table heading.
            sortedEmployees = Sort(unsortedEmployees, option);
            break;

          //*** Sorting by employee gross (descending).
          case 5:
            Console.WriteLine("\nEmployees by Gross Pay (Descending Order):\n");  //Sorted table heading.
            sortedEmployees = Sort(unsortedEmployees, option);
            break;

          case 6:
            running = false;  //Raising flag which terminates loop and ends console program.
            break;

          //*** An incorrect menu option entered by user will follow this default case.
          default:
            Console.WriteLine("\n\nInvalid menu selection. Try again.\n\n");  //Prompting user to re-select option.
            outputTable = false;
            break;
          }

        //*** Condiition ensuring a sorted table and its headings are only outputted for good user input.
        if (outputTable == true)
          {
          //*** Outputting the table of sorted employees according to menu option selection.
          Console.WriteLine("Name                  Number  Rate   Hours      Gross Pay\n" +
                            "===================   ======  =====  =====   ============");
          //*** Employees are iteratively written to the Console whenever not null in the sortedEmployees array.
          foreach (Employee emp in sortedEmployees)
            if (emp != null)
              {
              //*** Composite formatting is used here to make a table based on: 
              //    docs.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting#format-string-component
              Console.WriteLine("{0, -20}  {1, 6:F0}  {2, 5:F2}  {3, 5:F2}   {4, 12:F2}",
                emp.GetName(), emp.GetNumber(), emp.GetRate(), emp.GetHours(), emp.GetGross());
              }
          Console.WriteLine("\n\n");
          }
        }
      }
    }
  }
