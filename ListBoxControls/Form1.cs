using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxControls
  {
  public partial class listboxControlsForm : Form
    {
    public listboxControlsForm()
      {
      InitializeComponent();
      }

    private void listboxControlsForm_Load(object sender, EventArgs e)
      {

      }
    
    private void nameTextBox_TextChanged(object sender, EventArgs e)
      {

      }

    private void addbutton_Click(object sender, EventArgs e)
      {
      if (nameTextBox.Text != "")
        {
        statusLabel.Text = "";
        namesListBox.Items.Add(nameTextBox.Text);
        }
      else
        {
        statusLabel.ForeColor = Color.DarkRed;
        statusLabel.Text = "Name cannot be blank. Please input a name.";
        }
      }

    private void clearButton_Click(object sender, EventArgs e)
      {
      nameTextBox.Text = "";
      namesListBox.Items.Clear();
      statusLabel.Text = "";
      }

    private void deleteButton_Click(object sender, EventArgs e)
      {
      if (namesListBox.SelectedIndex != -1)
        {
        statusLabel.Text = "";
        namesListBox.Items.RemoveAt(namesListBox.SelectedIndex);
        }
      else
        {
        statusLabel.ForeColor = Color.DarkRed;
        statusLabel.Text = "Must select a name to be removed. Try again.";
        }
      }

    private void moveUpButton_Click(object sender, EventArgs e)
      {
      if(namesListBox.SelectedIndex != -1 && namesListBox.SelectedIndex != 0)
        {
        statusLabel.Text = "";
        int index = namesListBox.SelectedIndex;
        string selectedName = (string)namesListBox.Items[index];
        namesListBox.Items.RemoveAt(index);
        namesListBox.Items.Insert(index-1, selectedName);
        namesListBox.SetSelected(index - 1, true);
        }
      else
        {
        statusLabel.ForeColor = Color.DarkRed;
        statusLabel.Text = "Must select a valid name to move up. Try again.";
        }
      }
    }
  }
