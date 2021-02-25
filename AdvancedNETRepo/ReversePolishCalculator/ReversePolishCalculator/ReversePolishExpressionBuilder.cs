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
  /// <summary>
  /// Expression visitor used to build reverse polish expressions by accepting string input from console.
  /// </summary>
  public class ReversePolishExpressionBuilder : ExpressionVisitor
  {
    /// <summary>
    /// Default constructor.
    /// </summary>
    public ReversePolishExpressionBuilder() { }

    /// <summary>
    /// Constructor that accepts a root node (constant expression) to begin building a reverse
    /// polish expression. Root assigned to partialExpressionStack until first operator reached.
    /// </summary>
    /// <param name="expressionTerms">String list representing each term in expression sequence for building.</param>
    public ReversePolishExpressionBuilder(string expressionString) { this.ExpressionString = expressionString; }

    /// <summary>
    /// Property that is set from user input in a console program representing a reverse polish expression
    /// that needs validation and sanitizing from whitespace and to separate expression terms.
    /// </summary>
    public string ExpressionString
    {
      get { return this.expressionString; }
      set 
      { 
        this.expressionString = value;
        this.ValidateCharacters();
        this.SanitizeNumbersAndOperators();
      }
    }
    private string expressionString;

    /// <summary>
    /// Property that gets this builder's expression terms, or sets expression terms and builds the expression.
    /// </summary>
    public List<string> ExpressionTerms
    {
      get { return this.expressionTerms; }
      set
      {
        this.expressionTerms = value;
        BuildExpressionTree();
      }
    }
    private List<string> expressionTerms;

    /// <summary>
    /// Property representing root expression being built by this reverse polish expression visitor.
    /// Note that this must be reset after partial expressions are parsed and appended to the expression tree being built.
    /// </summary>
    public Expression RootExpression { get; set; }

    /// <summary>
    /// Result from evaluating current root expression that is built.
    /// </summary>
    public double Result { get; private set; }

    /// <summary>
    /// Operators stacked for building expressions.
    /// </summary>
    private List<char> operatorList = new List<char>();

    /// <summary>
    /// Constants and root expression to be formulated into an new root expression.
    /// </summary>
    private Stack<Expression> expressionStack = new Stack<Expression>();

    /// <summary>
    /// Resets this visitor/builder by clearing all stacks, lists, expressions, and results.
    /// To be used after throwing exceptions or entering multiple expressions to evaluate.
    /// </summary>
    public void Reset()
    {
      this.expressionString = "";
      this.expressionStack.Clear();
      this.operatorList.Clear();
      this.expressionTerms.Clear();
      this.RootExpression = null;
      this.Result = 0.0;
    }

    /// <summary>
    /// Method that validates this ExpressionString up to allowable characters overall, at the start, and at the end.
    /// </summary>
    private void ValidateCharacters()
    {
      string validPattern = @"[\s\+\-\*\/\^0123456789]";      // Valid operators, numbers, and whitespace in positive character group.
      string invalidPattern = @"[^\s\+\-\*\/\^0123456789]";   // Negation of valid character group (all other chars).

      // Validate characters (whitespace, numbers, operators).
      if (Regex.IsMatch(this.expressionString, validPattern) && !Regex.IsMatch(this.expressionString, invalidPattern))
      {
        // Validate first non-whitespace character of user input is a number.
        if (!Regex.IsMatch(this.expressionString, @"^\s*[\d]"))
          throw new FormatException("Expression must start with number.");
        // Validate last non-whitespace character of user input is an operator.
        if (!Regex.IsMatch(this.expressionString, @"[\+\-\*\/\^]\s*$"))
          throw new FormatException("Expression must end with an operator.");
      }
      else
        throw new FormatException("Invalid characters present.");
    }

    /// <summary>
    /// Splits on all whitespace and separates operators and numbers that are contiguous (without whitespace between).
    /// The ExpressionTerms property is set for this class with the result of separating terms in this method.
    /// </summary>
    private void SanitizeNumbersAndOperators()
    {
      List<string> expressionTerms = new List<string>();  // To be returned after sanitizing userInput.

      // Pattern used to split and extract numbers and/or operators.
      Regex whiteSpaceRegex = new Regex(@"\s+", RegexOptions.Compiled);

      // String array containing numbers and/or operators only.
      string[] sanitizedUserInput = whiteSpaceRegex.Split(this.expressionString);

      // Iterate over characters to add them correctly to the expression terms according to numbers and operators.
      foreach (string characterSequence in sanitizedUserInput)
      {
        // Check for only numbers to add entire number string (representing an integer) to expression terms.
        if (Regex.IsMatch(characterSequence, @"[0123456789]") && !Regex.IsMatch(characterSequence, @"[\+\-\*\/\^]"))
          expressionTerms.Add(characterSequence);

        // Check for only operators to add EACH operation to expresion terms.
        else if (!Regex.IsMatch(characterSequence, @"[0123456789]") && Regex.IsMatch(characterSequence, @"[\+\-\*\/\^]"))
        {
          foreach (char operation in characterSequence)
            expressionTerms.Add(operation.ToString());
        }
        // Otherwise, split characters further to extract numbers and operators and add them to expression terms correctly.
        else
        {
          // Add numbers and operators accordingly until end of character sequence.
          string numberString = "";
          for (int i = 0; i < characterSequence.Length; i++)
          {
            char character = characterSequence[i];

            // Check if current character is an operator to add it, otherwise append it to numberString.
            if (Regex.IsMatch(character.ToString(), @"[\+\-\*\/\^]"))
              expressionTerms.Add(character.ToString());
            else
              numberString += character;

            // Check for a next character.
            if (i + 1 < characterSequence.Length)
            {
              // Check if current character is number and next character is an operator to add and clear numberString.
              if (Regex.IsMatch(character.ToString(), @"[0123456789]") &&
                Regex.IsMatch(characterSequence[i + 1].ToString(), @"[\+\-\*\/\^]"))
              {
                expressionTerms.Add(character.ToString());
                numberString = "";
              }
              else
                numberString += character;
            }
            // Check if current character is a number to add it when no characters are left.
            else if (Regex.IsMatch(character.ToString(), @"[0123456789]"))
              expressionTerms.Add(character.ToString());
          }
        }
      }
      this.ExpressionTerms = expressionTerms;
    }

    /// <summary>
    /// Builds an expression tree from validated user input and returns it.
    /// </summary>
    /// <param name="expressionTerms"></param>
    private void BuildExpressionTree()
    {
      bool unstackable = false; // Flag lowered when constant/operator stacks full (scanned past operators at front).

      // Handle char sequences without whitespace and with numbers/operators - where root expression needs re-evaluation.
      for (int i = 0; i < this.expressionTerms.Count; i++)
      {
        string term = this.expressionTerms[i]; // Current term being scanned in expression.

        // Use "none" as placeholder to avoid i + 1 out of range for next term (when none remaining).
        string nextTerm = i + 1 < this.expressionTerms.Count ? this.expressionTerms[i + 1] : "none";

        // When term is a number, stack its constant expression.
        if (Regex.IsMatch(term, @"[0123456789]"))
          this.expressionStack.Push(Expression.Constant(double.Parse(term)));
        else  // Otherwise, stack operators until reaching the next number.
        {
          // Stack up operators while no numbers found in iterative next terms or expression terms end.
          while (!unstackable)
          {
            this.operatorList.Add(char.Parse(term));  // Push current term onto the operator stack before iterating.

            // Check the next term to decide to advance terms or begin unstacking.
            if (!Regex.IsMatch(nextTerm, @"[0123456789]") && nextTerm != "none")
            {
              i++;
              term = this.expressionTerms[i];
              nextTerm = i + 1 < this.expressionTerms.Count ? this.expressionTerms[i+1] : "none";
            }
            else
              unstackable = true; // Enable unstacking after reaching next number in terms or end of terms.            
          }
        }

        // Unstack constants and operators to modify root expression for this visitor/builder and lower unstacking flag.
        if (unstackable)
        {
          Unstack();
          unstackable = false;
        }
      }
      this.expressionStack.Clear();  // Clear expression stack for the next expression to be built.
      EvaluateExpression();          // Sets the result of this expression.
    }

    /// <summary>
    /// Unstacks constants and assigns a new root expression with this visitor/builder's current root expression.
    /// </summary>
    private void Unstack()
    {
      // Check number of constant expressions stacked with root has 1 fewer operations from operators currently stacked.
      if (this.expressionStack.Count == this.operatorList.Count + 1)
      {
        // Temporary expression used to unstack and join constants to the root expression.
        Expression tempExpression = this.expressionStack.Pop();

        // Iteratively re-assigns temp expression until it eventually becomes new root node.
        int operatorsRemaining = this.operatorList.Count;
        while (this.operatorList.Count != 0 && this.expressionStack.Count != 0 && operatorsRemaining != 0)
        {
          tempExpression = this.Visit(tempExpression);
          operatorsRemaining--;
        }

        // Re-assign and stack new root expression after all constant and operator unstacking is complete.
        this.RootExpression = tempExpression;
        this.expressionStack.Push(this.RootExpression);
      }
      else  // Throw generic format exception covering cases for both number and operator formatting.
        throw new FormatException("Cannot unstack terms; either too many operators following" +
          "\n\t constants or not enough constants preceding operators.");
    }

    /// <summary>
    /// Method that uses this class' VisitBinary and VisitConstant methods overridden 
    /// to evaluate this visitor/builder's root expression. 
    /// </summary>
    /// <returns>Evaluated expression as a double.</returns>
    private void EvaluateExpression()
    {
      Console.WriteLine($"  Rewritten: {(BinaryExpression)this.RootExpression}");
      Expression recursiveResult = this.VisitBinary((BinaryExpression)this.RootExpression);
      this.Result = (double)((ConstantExpression)recursiveResult).Value;
    }

    /// <summary>
    /// Method passes control of an expression node to correct method for visiting binary or constant
    /// expression nodes according to supported expression types required for operations 
    ///  +, -, *, /, and ^.
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    public override Expression Visit(Expression node)
    {
      char operation = this.operatorList[0];
      this.operatorList.RemoveAt(0);
      return operation switch
      {
        '+' => Expression.MakeBinary(ExpressionType.Add, node, this.expressionStack.Pop()),
        '-' => Expression.MakeBinary(ExpressionType.Subtract, node, this.expressionStack.Pop()),
        '*' => Expression.MakeBinary(ExpressionType.Multiply, node, this.expressionStack.Pop()),
        '/' => Expression.MakeBinary(ExpressionType.Divide, node, this.expressionStack.Pop()),
        '^' => Expression.MakeBinary(ExpressionType.Power, node, this.expressionStack.Pop()),
        // Default not reachable due to prior validation of specific operators.
        _ => throw new FormatException("Operation not recognized."),
      };
    }

    /// <summary>
    /// Recursive method that reaches to the lowest branch of the binary expression tree and builds up a result
    /// going back up the tree using the constants from each expression along the way back.
    /// </summary>
    /// <param name="node">Expression to be evaluated for a result.</param>
    /// <returns>Constant expression that holds this builder's result as its value.</returns>
    protected override Expression VisitBinary(BinaryExpression node)
    {
      // Condition for reaching end of binary tree and building it back up qith constant expressions.
      if (node.Left.NodeType == ExpressionType.Constant && node.Right.NodeType == ExpressionType.Constant)
      {
        ConstantExpression left = (ConstantExpression)node.Left;
        ConstantExpression right = (ConstantExpression)node.Right;
        return node.NodeType switch
        {
          ExpressionType.Add => Expression.Constant((double)left.Value + (double)right.Value),
          ExpressionType.Subtract => Expression.Constant((double)left.Value - (double)right.Value),
          ExpressionType.Multiply => Expression.Constant((double)left.Value * (double)right.Value),
          ExpressionType.Divide => Expression.Constant((double)left.Value / (double)right.Value),
          ExpressionType.Power => Expression.Constant(Math.Pow((double)left.Value, (double)right.Value)),
          _ => base.Visit(node),
        };
      }
      // Condition for re-applying this method to RHS.
      else if (node.Left.NodeType == ExpressionType.Constant)
      {
        Expression nextExpression = this.VisitBinary((BinaryExpression)node.Right);
        ConstantExpression recurseExpression = (ConstantExpression)nextExpression;
        ConstantExpression left = (ConstantExpression)node.Left;

        return node.NodeType switch
        {
          ExpressionType.Add => Expression.Constant((double)left.Value + (double)recurseExpression.Value),
          ExpressionType.Subtract => Expression.Constant((double)left.Value - (double)recurseExpression.Value),
          ExpressionType.Multiply => Expression.Constant((double)left.Value * (double)recurseExpression.Value),
          ExpressionType.Divide => Expression.Constant((double)left.Value / (double)recurseExpression.Value),
          ExpressionType.Power => Expression.Constant(Math.Pow((double)left.Value, (double)recurseExpression.Value)),
          _ => base.Visit(node),
        };
      }
      // Condition for re-applying this method to LHS.
      else if (node.Right.NodeType == ExpressionType.Constant)
      {
        Expression nextExpression = this.VisitBinary((BinaryExpression)node.Left);
        ConstantExpression recurseExpression = (ConstantExpression)nextExpression;
        ConstantExpression right = (ConstantExpression)node.Right;

        return node.NodeType switch
        {
          ExpressionType.Add => Expression.Constant((double)recurseExpression.Value + (double)right.Value),
          ExpressionType.Subtract => Expression.Constant((double)recurseExpression.Value - (double)right.Value),
          ExpressionType.Multiply => Expression.Constant((double)recurseExpression.Value * (double)right.Value),
          ExpressionType.Divide => Expression.Constant((double)recurseExpression.Value / (double)right.Value),
          ExpressionType.Power => Expression.Constant(Math.Pow((double)recurseExpression.Value, (double)right.Value)),
          _ => base.Visit(node),
        };
      }
      // Otherwise, must apply this method to both sides of expression tree.
      else
      {
        Expression nextLeftExpression = this.VisitBinary((BinaryExpression)node.Left);
        ConstantExpression recurseLeftExpresion = (ConstantExpression)nextLeftExpression;

        Expression nextRightExpression = this.VisitBinary((BinaryExpression)node.Right);
        ConstantExpression recurseRightExpresion = (ConstantExpression)nextRightExpression;

        return node.NodeType switch
        {
          ExpressionType.Add => Expression.Constant((double)recurseLeftExpresion.Value + (double)recurseRightExpresion.Value),
          ExpressionType.Subtract => Expression.Constant((double)recurseLeftExpresion.Value - (double)recurseRightExpresion.Value),
          ExpressionType.Multiply => Expression.Constant((double)recurseLeftExpresion.Value * (double)recurseRightExpresion.Value),
          ExpressionType.Divide => Expression.Constant((double)recurseLeftExpresion.Value / (double)recurseRightExpresion.Value),
          ExpressionType.Power => Expression.Constant(Math.Pow((double)recurseLeftExpresion.Value, (double)recurseRightExpresion.Value)),
          _ => base.Visit(node),
        };
      }
    }

    /// <summary>
    /// Visiting a constant expression node reflects it.
    /// </summary>
    /// <param name="node">Constant expression to be reflected.</param>
    /// <returns>Reflected constant expression.</returns>
    protected override Expression VisitConstant(ConstantExpression node) { return node; }
  }
}
