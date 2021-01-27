using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
  {
  public partial class BankAccountForm : Form
    {
    BankAccountArchive archive = new BankAccountArchive();
    Transaction transaction;
    BankAccount tempAccount;
    public BankAccountForm()
      {
      InitializeComponent();
      }

    private void ChequingAccountRadioButton_CheckedChanged(object sender, EventArgs e)
      {
      if(chequingAccountRadioButton.Enabled)
        savingsAccountRadioButton.Enabled = false;
      else
        savingsAccountRadioButton.Enabled = true;
      }

    private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
      {
      foreach (BankAccount b in archive.GetAccounts())
      if (firstNameTextBox.Text == b.Owner.FirstName && lastNameTextBox.Text == b.Owner.LastName )
        {
          firstNameTextBox.ReadOnly = true;
          lastNameTextBox.ReadOnly = true;
          accountInformationGroupBox.Enabled = true;
          accountTypeGroupBox.Enabled = false;
          clearButton.Enabled = true;
          createButton.Enabled = false;
          accountNumberTextBox.Text = $"{b.Number:F0}";
          currentBalanceTextBox.Text = $"{b.Balance:C2}";
          foreach (Transaction t in b.Transactions)
            transactionsListBox.Items.Add($"{t.Type} of {t.Amount:C2} posted: {t.TimePosted}");
          }
        else
          {
          accountInformationGroupBox.Enabled = false;
          accountNumberTextBox.Text = "";
          currentBalanceTextBox.Text = "";
          amountTextBox.Text = "";
          }
      }
    private void LastNameTextBox_TextChanged(object sender, EventArgs e)
      {
      foreach (BankAccount b in archive.GetAccounts())
        {
        if (firstNameTextBox.Text == b.Owner.FirstName && lastNameTextBox.Text == b.Owner.LastName)
          {
          firstNameTextBox.ReadOnly = true;
          lastNameTextBox.ReadOnly = true;
          accountInformationGroupBox.Enabled = true;
          accountTypeGroupBox.Enabled = false;
          clearButton.Enabled = true;
          createButton.Enabled = false;
          accountNumberTextBox.Text = $"{b.Number:F0}";
          currentBalanceTextBox.Text = $"{b.Balance:C2}";
          foreach (Transaction t in b.Transactions)
            transactionsListBox.Items.Add($"{t.Type} of {t.Amount:C2} posted: {t.TimePosted}");
          }
        else
          {
          accountInformationGroupBox.Enabled = false;
          accountNumberTextBox.Text = "";
          currentBalanceTextBox.Text = "";
          amountTextBox.Text = "";
          }
        }
      }

    private void DepositRadioButton_CheckedChanged(object sender, EventArgs e)
      {
      if (depositRadioButton.Enabled)
        withdrawRadioButton.Enabled = false;
      else
        withdrawRadioButton.Enabled = true;
      }

    private void FirstNameLabel_Click(object sender, EventArgs e)
      {

      }

    private void LastNameLabel_Click(object sender, EventArgs e)
      {

      }

    private void AccountTypeGroupBox_Enter(object sender, EventArgs e)
      {

      }

    private void AccountNumberLabel_Click(object sender, EventArgs e)
      {

      }

    private void AccountInformationGroupBox_Enter(object sender, EventArgs e)
      {

      }

    private void TransactionsLabel_Click(object sender, EventArgs e)
      {

      }

    private void CreateButton_Click(object sender, EventArgs e)
      {
      firstNameTextBox.ReadOnly = true;
      lastNameTextBox.ReadOnly = true;
      if (firstNameTextBox.Text != "" && lastNameTextBox.Text != "")
        {
        accountInformationGroupBox.Enabled = true;
        clearButton.Enabled = true;
        createButton.Enabled = false;

        if (chequingAccountRadioButton.Checked)
          {
          tempAccount = new BankAccount(new Person(firstNameTextBox.Text, lastNameTextBox.Text), BankAccountType.CHEQUING);
          archive.AddAccount(tempAccount);
          }
        else
          {
          tempAccount = new BankAccount(new Person(firstNameTextBox.Text, lastNameTextBox.Text), BankAccountType.SAVINGS);
          archive.AddAccount(tempAccount);
          }

        currentBalanceTextBox.Text = $"{tempAccount.Balance:C2}";
        accountNumberTextBox.Text = $"{tempAccount.Number:F0}";
        }
      else if (firstNameTextBox.Text == "" || lastNameTextBox.Text == "")
        {
        statusLabel.ForeColor = Color.DarkRed;
        statusLabel.Text = "Error: A first and last name MUST be specified.";
        }
      }

    private void WithdrawRadioButton_CheckedChanged(object sender, EventArgs e)
      {
      if (withdrawRadioButton.Enabled)
        depositRadioButton.Enabled = false;
      else
        depositRadioButton.Enabled = true;
      }

    private void SavingsAccountRadioButton_CheckedChanged(object sender, EventArgs e)
      {
      if (savingsAccountRadioButton.Enabled)
        chequingAccountRadioButton.Enabled = false;
      else
        chequingAccountRadioButton.Enabled = true;
      }

    private void ClearButton_Click(object sender, EventArgs e)
      {
      lastNameTextBox.Text = "";
      firstNameTextBox.Text = "";
      amountTextBox.Text = "";
      accountNumberTextBox.Text = "";
      currentBalanceTextBox.Text = "";
      createButton.Enabled = true;
      addTransactionButton.Enabled = false;
      clearButton.Enabled = false;
      accountTypeGroupBox.Enabled = true;
      transactionsListBox.Items.Clear();
      firstNameTextBox.ReadOnly = false;
      lastNameTextBox.ReadOnly = false;
      }

    private void AddTransactionButton_Click(object sender, EventArgs e)
      {
      foreach (BankAccount b in archive.GetAccounts())
        {
        if (b.Number == int.Parse(accountNumberTextBox.Text))
          {
          transaction = new Transaction(TransactionType.WITHDRAWAL, decimal.Parse(amountTextBox.Text), DateTime.Now.ToUniversalTime());
          b.Transactions.Add(transaction);
          b.AddToTransactionList(transaction);
          transactionsListBox.Items.Add($"{transaction.Type} of {transaction.Amount:C2} posted: {transaction.TimePosted}");
          currentBalanceTextBox.Text = $"{b.Balance:C2}";
          }
        }
     
      }

    private void AmountTextBox_TextChanged(object sender, EventArgs e)
      {

      }

    private void CurrentBalanceTextBox_TextChanged(object sender, EventArgs e)
      {

      }

    private void AccountNumberTextBox_TextChanged(object sender, EventArgs e)
      {

      }

    private void TransactionsListBox_SelectedIndexChanged(object sender, EventArgs e)
      {

      }
    }
  }
