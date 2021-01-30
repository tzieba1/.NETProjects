//*** I, Tommy Zieba, 000797152 certify that this material is my original work. 
//    No other person's work has been used without due acknowledgement.
//    
//    Date: October 4, 2019.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///   This is the namespace which holds projects and associated items with respect to
///   Lab 2B in COMP 10204 - Fall 2019.
/// </summary>
namespace Lab2B
  {
  /// <summary>
  ///   Partial class that abstracts from a <c>Form</c> base class.
  /// </summary>
  public partial class PerfectCutHairSalonForm : Form
    {
    /// <summary>
    ///   Constructor for an instance of <c>PerfectCutHairSalonForm</c> initializing the form.
    /// </summary>
    public PerfectCutHairSalonForm()
      {
      InitializeComponent();
      }
    
    /// <summary>
    ///   Mthod used to enable <c>clientVisitsGroupBox</c> and <c>calculateButton</c> whenever
    ///   at least one <c>CheckBox</c> is checked in <c>servicesGroupBox</c>.
    /// </summary>
    private void TestAnyCheckBoxesChecked()
      {
      //Initially disable clientVisitsGroupBox before possibly enabling it - used as boolean flag.
      clientVisitsGroupBox.Enabled = false;
      //Iterating through checkBoxes in servicesGroupBox and either setting the Enabled 
      //property to true or not changing its Enabled property if any CheckBoxes are Checked.
      foreach (CheckBox checkBox in servicesGroupBox.Controls)
        {
        if (checkBox.Checked)
          {
          clientVisitsGroupBox.Enabled = true;
          calculateButton.Enabled = true; //Enable calculationButton in case TextBox Text nonempty.
          }
        }
      //Either enabling or disabling the calculateButton depending on the boolean flag representing
      //clientVisitGroupBox's Enabled property AFTER testing ALL CheckBoxes iteratively above.
      calculateButton.Enabled = 
        clientVisitsGroupBox.Enabled && numberOfClientVisitsTextBox.Text != "" ? 
        calculateButton.Enabled : false; 
      }

    /// <summary>
    ///   Event handler used to add functionality upon loading <c>PerfectCutHairSalonForm</c>.
    ///   Initally disables <c>clientVisitsGroupBox</c>, <c>servicesGroupBox</c> and 
    ///   <c>calculateButton</c> to guide user controls. 
    ///   
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///   The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void PerfectCutHairSalonForm_Load(object sender, EventArgs e)
      {
      clientVisitsGroupBox.Enabled = false; //Disable number of clients control until other fields specified.
      calculateButton.Enabled = false;  //Disable until user manipulates valid controls.
      standardAdultRadioButton.Select();  //Select first control incorresponding GroupBox by default.
      janeSamleyRadioButton.Select(); //Select first control incorresponding GroupBox by default.
      janeSamleyRadioButton.Focus();  //Focus to first control for keyboard form navigation.
      errorMessageLabel.Visible = false ; //Make error message invisible on initialization.
      }


    /// <summary>
    ///   Event handler that implements the <c>TestAnyCheckBoxesChecked()</c> method
    ///   whenever <c>CutCheckBox</c> is checked.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void CutCheckBox_CheckedChanged(object sender, EventArgs e)
      {
      TestAnyCheckBoxesChecked();
      }


    /// <summary>
    ///   Event handler that implements the <c>TestAnyCheckBoxesChecked()</c> method
    ///   whenever <c>ColourCheckBox</c> is checked.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void ColourCheckBox_CheckedChanged(object sender, EventArgs e)
      {
      TestAnyCheckBoxesChecked();
      }


    /// <summary>
    ///   Event handler that implements the <c>TestAnyCheckBoxesChecked()</c> method
    ///   whenever <c>HighlightsCheckBox</c> is checked.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void HighlightsCheckBox_CheckedChanged(object sender, EventArgs e)
      {
      TestAnyCheckBoxesChecked();
      }


    /// <summary>
    ///   Event handler that implements the <c>TestAnyCheckBoxesChecked()</c> method
    ///   whenever <c>ExtensionsCheckBox</c> is checked.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void ExtensionsCheckBox_CheckedChanged(object sender, EventArgs e)
      {
      TestAnyCheckBoxesChecked();
      }

    /// <summary>
    ///   Event handler that validates user input and enables <c>CalculateButton</c>
    ///   whenever the <c>NumberOfClientVisitsTextBox</c> has a valid <c>Message</c> property.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void NumberOfClientVisitsTextBox_TextChanged(object sender, EventArgs e)
      {
      /* Must clear errorMessageLabel text and disable calculateButton each time the
       * text changes and the following check occurs. 
       */
      errorMessageLabel.Visible = false;

      /* Condition determines if input is a valid integer to enable the calculateButton. */
      if (numberOfClientVisitsTextBox.Text != "")
        {
        try
          {
          //When the TextBox is successfully parsed as an integer, the calculate button will be 
          //Enabled or disabled depending on the integer being > 0. (Validation?) 
          if (int.Parse(numberOfClientVisitsTextBox.Text) > 0)
            calculateButton.Enabled = true;
          else
            errorMessageLabel.Visible = true;
          }
        catch (FormatException)
          {
          errorMessageLabel.Visible = true;
          }
        }
      }

    /// <summary>
    ///   Event handler that calculates the total price and displays it with <c>totalPriceLabel</c>
    ///   whenever the <c>NumberOfClientVisitsTextBox</c> has a valid <c>Message</c> property and
    ///   the <c>calculateButton</c> is clicked.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void CalculateButton_Click(object sender, EventArgs e)
      {
      /* Declaring variables for rates and discounts. */
      double rate = 0.0;
      double discount = 1.0;

      /* Loop through hairdresserGroupBox controls and test if checked to decide how 
       * to set the BaseRate property by using a switch-case on current Text. 
       */
      foreach (RadioButton radioButton in hairdresserGroupBox.Controls)
        {
        if (radioButton.Checked)
          {
          switch (radioButton.Text)
            {
            case "Jane Samley":
              rate += 30;
              break;

            case "Pat Johnson":
              rate += 45;
              break;

            case "Ron Chambers":
              rate += 40;
              break;

            case "Sue Pallon":
              rate += 50;
              break;

            case "Laura Renkins":
              rate += 55;
              break;
            }
          }
        }

      /* Looping through RadioButtons in clientTypeGroupBox to update clientDiscount. */
      foreach (RadioButton radioButton in clientTypeGroupBox.Controls)
        {
        if (radioButton.Checked)
          {
          switch (radioButton.Text)
            {
            case "Child (12 and under)":
              discount -= 0.1;
              break;

            case "Student":
              discount -= 0.05;
              break;

            case "Senior (over 65)":
              discount -= 0.15;
              break;
            }
          }
        }

      /* Looping through checkBoxes in servicesGroupBox to update serviceRate. */
      foreach (CheckBox checkBox in servicesGroupBox.Controls)
        {
        if (checkBox.Checked)
          {
          switch (checkBox.Text)
            {
            case "Cut":
              rate += 30;
              break;

            case "Colour":
              rate += 40;
              break;

            case "Highlights":
              rate += 50;
              break;

            case "Extensions":
              rate += 200;
              break;
            }
          }
        }

      /* Adjusting rate based on number of visits with switch on numberOfClientsTextBox Text. */
      switch (int.Parse(numberOfClientVisitsTextBox.Text))
        {
        case 1:
        case 2:
        case 3:
          break;

        case 4:
        case 5:
        case 6:
        case 7:
        case 8:
          discount -= 0.05;
          break;

        case 9:
        case 10:
        case 11:
        case 12:
        case 13:
          discount -= 0.1;
          break;

        default:
          discount -= 0.15;
          break;
        }

      double totalPrice =(discount * rate); //Calculate totalPrice.
      totalPriceLabel.Text = $"Total Price: ${totalPrice:F2}"; //Displays totalPrice on a Label.
      }

    /// <summary>
    ///   Event handler that clears the form, resets focus, and selects default <c>Control</c>s.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void ClearButton_Click(object sender, EventArgs e)
      {
      /* Clearing the clienVisitsTextBox, enabling groupBoxes, removing error messages
       * and re-focusing to first RadioButton to reset user input sequence. */
      numberOfClientVisitsTextBox.Text = "";
      hairdresserGroupBox.Enabled = true;
      servicesGroupBox.Enabled = true;
      clientTypeGroupBox.Enabled = true;
      clientVisitsGroupBox.Enabled = false;   
      totalPriceLabel.Text = "Total Price: "; //Reset the totalPriceLabel.
      standardAdultRadioButton.Select();      //Select first RadioButton from clientTypeGroupBox.
      janeSamleyRadioButton.Focus();          //Focus first radioButton in hairdresserGroupBox.

      foreach (CheckBox checkBox in servicesGroupBox.Controls) { checkBox.Checked = false; }
      }

    /// <summary>
    ///   This Method exits the application when the exitButton is clicked by the user.
    /// </summary>
    /// <param name="sender">References the <c>object</c> that raised the event.</param>
    /// <param name="e">
    ///     The event arguments (or data) for the <paramref name="sender"/>parameter.
    /// </param>
    private void ExitButton_Click(object sender, EventArgs e) { Close(); }
    }
  }
