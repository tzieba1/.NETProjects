namespace BankAccount
  {
  partial class BankAccountForm
    {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
      {
      if (disposing && (components != null))
        {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
      {
      this.firstNameLabel = new System.Windows.Forms.Label();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameLabel = new System.Windows.Forms.Label();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.chequingAccountRadioButton = new System.Windows.Forms.RadioButton();
      this.savingsAccountRadioButton = new System.Windows.Forms.RadioButton();
      this.createButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.accountNumberLabel = new System.Windows.Forms.Label();
      this.transactionsLabel = new System.Windows.Forms.Label();
      this.addTransactionLabel = new System.Windows.Forms.Label();
      this.accountNumberTextBox = new System.Windows.Forms.TextBox();
      this.currentBalanceLabel = new System.Windows.Forms.Label();
      this.currentBalanceTextBox = new System.Windows.Forms.TextBox();
      this.accountTypeGroupBox = new System.Windows.Forms.GroupBox();
      this.accountInformationGroupBox = new System.Windows.Forms.GroupBox();
      this.statusLabel = new System.Windows.Forms.Label();
      this.addTransactionButton = new System.Windows.Forms.Button();
      this.amountTextBox = new System.Windows.Forms.TextBox();
      this.amountLabel = new System.Windows.Forms.Label();
      this.depositRadioButton = new System.Windows.Forms.RadioButton();
      this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
      this.transactionsListBox = new System.Windows.Forms.ListBox();
      this.accountTypeGroupBox.SuspendLayout();
      this.accountInformationGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // firstNameLabel
      // 
      this.firstNameLabel.AutoSize = true;
      this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.firstNameLabel.Location = new System.Drawing.Point(49, 32);
      this.firstNameLabel.Name = "firstNameLabel";
      this.firstNameLabel.Size = new System.Drawing.Size(71, 13);
      this.firstNameLabel.TabIndex = 0;
      this.firstNameLabel.Text = "First Name:";
      this.firstNameLabel.Click += new System.EventHandler(this.FirstNameLabel_Click);
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(139, 29);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(226, 20);
      this.firstNameTextBox.TabIndex = 1;
      this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
      // 
      // lastNameLabel
      // 
      this.lastNameLabel.AutoSize = true;
      this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lastNameLabel.Location = new System.Drawing.Point(403, 32);
      this.lastNameLabel.Name = "lastNameLabel";
      this.lastNameLabel.Size = new System.Drawing.Size(71, 13);
      this.lastNameLabel.TabIndex = 2;
      this.lastNameLabel.Text = "Last Name:";
      this.lastNameLabel.Click += new System.EventHandler(this.LastNameLabel_Click);
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(489, 29);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(231, 20);
      this.lastNameTextBox.TabIndex = 3;
      this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
      // 
      // chequingAccountRadioButton
      // 
      this.chequingAccountRadioButton.AutoSize = true;
      this.chequingAccountRadioButton.BackColor = System.Drawing.SystemColors.Control;
      this.chequingAccountRadioButton.Checked = true;
      this.chequingAccountRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.chequingAccountRadioButton.Location = new System.Drawing.Point(30, 29);
      this.chequingAccountRadioButton.Name = "chequingAccountRadioButton";
      this.chequingAccountRadioButton.Size = new System.Drawing.Size(113, 17);
      this.chequingAccountRadioButton.TabIndex = 5;
      this.chequingAccountRadioButton.TabStop = true;
      this.chequingAccountRadioButton.Text = "Chequing Account";
      this.chequingAccountRadioButton.UseVisualStyleBackColor = false;
      this.chequingAccountRadioButton.CheckedChanged += new System.EventHandler(this.ChequingAccountRadioButton_CheckedChanged);
      // 
      // savingsAccountRadioButton
      // 
      this.savingsAccountRadioButton.AutoSize = true;
      this.savingsAccountRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.savingsAccountRadioButton.Location = new System.Drawing.Point(30, 52);
      this.savingsAccountRadioButton.Name = "savingsAccountRadioButton";
      this.savingsAccountRadioButton.Size = new System.Drawing.Size(106, 17);
      this.savingsAccountRadioButton.TabIndex = 6;
      this.savingsAccountRadioButton.Text = "Savings Account";
      this.savingsAccountRadioButton.UseVisualStyleBackColor = true;
      this.savingsAccountRadioButton.CheckedChanged += new System.EventHandler(this.SavingsAccountRadioButton_CheckedChanged);
      // 
      // createButton
      // 
      this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.createButton.Location = new System.Drawing.Point(41, 191);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(101, 23);
      this.createButton.TabIndex = 7;
      this.createButton.Text = "Create";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
      // 
      // clearButton
      // 
      this.clearButton.Enabled = false;
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearButton.Location = new System.Drawing.Point(245, 191);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(110, 23);
      this.clearButton.TabIndex = 8;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
      // 
      // accountNumberLabel
      // 
      this.accountNumberLabel.AutoSize = true;
      this.accountNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.accountNumberLabel.Location = new System.Drawing.Point(19, 45);
      this.accountNumberLabel.Name = "accountNumberLabel";
      this.accountNumberLabel.Size = new System.Drawing.Size(70, 13);
      this.accountNumberLabel.TabIndex = 9;
      this.accountNumberLabel.Text = "Account #:";
      this.accountNumberLabel.Click += new System.EventHandler(this.AccountNumberLabel_Click);
      // 
      // transactionsLabel
      // 
      this.transactionsLabel.AutoSize = true;
      this.transactionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.transactionsLabel.Location = new System.Drawing.Point(9, 105);
      this.transactionsLabel.Name = "transactionsLabel";
      this.transactionsLabel.Size = new System.Drawing.Size(80, 13);
      this.transactionsLabel.TabIndex = 10;
      this.transactionsLabel.Text = "Transactions";
      this.transactionsLabel.Click += new System.EventHandler(this.TransactionsLabel_Click);
      // 
      // addTransactionLabel
      // 
      this.addTransactionLabel.AutoSize = true;
      this.addTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTransactionLabel.Location = new System.Drawing.Point(448, 121);
      this.addTransactionLabel.Name = "addTransactionLabel";
      this.addTransactionLabel.Size = new System.Drawing.Size(104, 13);
      this.addTransactionLabel.TabIndex = 11;
      this.addTransactionLabel.Text = "Add Transaction:";
      // 
      // accountNumberTextBox
      // 
      this.accountNumberTextBox.Location = new System.Drawing.Point(98, 42);
      this.accountNumberTextBox.Name = "accountNumberTextBox";
      this.accountNumberTextBox.ReadOnly = true;
      this.accountNumberTextBox.Size = new System.Drawing.Size(166, 20);
      this.accountNumberTextBox.TabIndex = 12;
      this.accountNumberTextBox.TextChanged += new System.EventHandler(this.AccountNumberTextBox_TextChanged);
      // 
      // currentBalanceLabel
      // 
      this.currentBalanceLabel.AutoSize = true;
      this.currentBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.currentBalanceLabel.Location = new System.Drawing.Point(302, 45);
      this.currentBalanceLabel.Name = "currentBalanceLabel";
      this.currentBalanceLabel.Size = new System.Drawing.Size(102, 13);
      this.currentBalanceLabel.TabIndex = 13;
      this.currentBalanceLabel.Text = "Current Balance:";
      // 
      // currentBalanceTextBox
      // 
      this.currentBalanceTextBox.Location = new System.Drawing.Point(410, 42);
      this.currentBalanceTextBox.Name = "currentBalanceTextBox";
      this.currentBalanceTextBox.ReadOnly = true;
      this.currentBalanceTextBox.Size = new System.Drawing.Size(237, 20);
      this.currentBalanceTextBox.TabIndex = 14;
      this.currentBalanceTextBox.TextChanged += new System.EventHandler(this.CurrentBalanceTextBox_TextChanged);
      // 
      // accountTypeGroupBox
      // 
      this.accountTypeGroupBox.Controls.Add(this.chequingAccountRadioButton);
      this.accountTypeGroupBox.Controls.Add(this.savingsAccountRadioButton);
      this.accountTypeGroupBox.Location = new System.Drawing.Point(41, 72);
      this.accountTypeGroupBox.Name = "accountTypeGroupBox";
      this.accountTypeGroupBox.Size = new System.Drawing.Size(194, 96);
      this.accountTypeGroupBox.TabIndex = 15;
      this.accountTypeGroupBox.TabStop = false;
      this.accountTypeGroupBox.Text = "Account Type";
      this.accountTypeGroupBox.Enter += new System.EventHandler(this.AccountTypeGroupBox_Enter);
      // 
      // accountInformationGroupBox
      // 
      this.accountInformationGroupBox.Controls.Add(this.statusLabel);
      this.accountInformationGroupBox.Controls.Add(this.addTransactionButton);
      this.accountInformationGroupBox.Controls.Add(this.amountTextBox);
      this.accountInformationGroupBox.Controls.Add(this.amountLabel);
      this.accountInformationGroupBox.Controls.Add(this.depositRadioButton);
      this.accountInformationGroupBox.Controls.Add(this.withdrawRadioButton);
      this.accountInformationGroupBox.Controls.Add(this.transactionsListBox);
      this.accountInformationGroupBox.Controls.Add(this.accountNumberTextBox);
      this.accountInformationGroupBox.Controls.Add(this.accountNumberLabel);
      this.accountInformationGroupBox.Controls.Add(this.transactionsLabel);
      this.accountInformationGroupBox.Controls.Add(this.addTransactionLabel);
      this.accountInformationGroupBox.Controls.Add(this.currentBalanceTextBox);
      this.accountInformationGroupBox.Controls.Add(this.currentBalanceLabel);
      this.accountInformationGroupBox.Enabled = false;
      this.accountInformationGroupBox.Location = new System.Drawing.Point(41, 247);
      this.accountInformationGroupBox.Name = "accountInformationGroupBox";
      this.accountInformationGroupBox.Size = new System.Drawing.Size(680, 374);
      this.accountInformationGroupBox.TabIndex = 16;
      this.accountInformationGroupBox.TabStop = false;
      this.accountInformationGroupBox.Text = "Account Information";
      this.accountInformationGroupBox.Enter += new System.EventHandler(this.AccountInformationGroupBox_Enter);
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.ForeColor = System.Drawing.Color.ForestGreen;
      this.statusLabel.Location = new System.Drawing.Point(9, 336);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(163, 13);
      this.statusLabel.TabIndex = 21;
      this.statusLabel.Text = "Last Transaction Status OK";
      // 
      // addTransactionButton
      // 
      this.addTransactionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addTransactionButton.Location = new System.Drawing.Point(448, 299);
      this.addTransactionButton.Name = "addTransactionButton";
      this.addTransactionButton.Size = new System.Drawing.Size(199, 34);
      this.addTransactionButton.TabIndex = 20;
      this.addTransactionButton.Text = "Add Transaction";
      this.addTransactionButton.UseVisualStyleBackColor = true;
      this.addTransactionButton.Click += new System.EventHandler(this.AddTransactionButton_Click);
      // 
      // amountTextBox
      // 
      this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.amountTextBox.Location = new System.Drawing.Point(448, 260);
      this.amountTextBox.Name = "amountTextBox";
      this.amountTextBox.Size = new System.Drawing.Size(199, 20);
      this.amountTextBox.TabIndex = 19;
      this.amountTextBox.Text = "0.00";
      this.amountTextBox.TextChanged += new System.EventHandler(this.AmountTextBox_TextChanged);
      // 
      // amountLabel
      // 
      this.amountLabel.AutoSize = true;
      this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.amountLabel.Location = new System.Drawing.Point(448, 243);
      this.amountLabel.Name = "amountLabel";
      this.amountLabel.Size = new System.Drawing.Size(53, 13);
      this.amountLabel.TabIndex = 18;
      this.amountLabel.Text = "Amount:";
      // 
      // depositRadioButton
      // 
      this.depositRadioButton.AutoSize = true;
      this.depositRadioButton.Checked = true;
      this.depositRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.depositRadioButton.Location = new System.Drawing.Point(448, 171);
      this.depositRadioButton.Name = "depositRadioButton";
      this.depositRadioButton.Size = new System.Drawing.Size(61, 17);
      this.depositRadioButton.TabIndex = 17;
      this.depositRadioButton.TabStop = true;
      this.depositRadioButton.Text = "Deposit";
      this.depositRadioButton.UseVisualStyleBackColor = true;
      this.depositRadioButton.CheckedChanged += new System.EventHandler(this.DepositRadioButton_CheckedChanged);
      // 
      // withdrawRadioButton
      // 
      this.withdrawRadioButton.AutoSize = true;
      this.withdrawRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.withdrawRadioButton.Location = new System.Drawing.Point(448, 148);
      this.withdrawRadioButton.Name = "withdrawRadioButton";
      this.withdrawRadioButton.Size = new System.Drawing.Size(70, 17);
      this.withdrawRadioButton.TabIndex = 16;
      this.withdrawRadioButton.Text = "Withdraw";
      this.withdrawRadioButton.UseVisualStyleBackColor = true;
      this.withdrawRadioButton.CheckedChanged += new System.EventHandler(this.WithdrawRadioButton_CheckedChanged);
      // 
      // transactionsListBox
      // 
      this.transactionsListBox.FormattingEnabled = true;
      this.transactionsListBox.Location = new System.Drawing.Point(12, 121);
      this.transactionsListBox.Name = "transactionsListBox";
      this.transactionsListBox.Size = new System.Drawing.Size(392, 212);
      this.transactionsListBox.TabIndex = 15;
      this.transactionsListBox.SelectedIndexChanged += new System.EventHandler(this.TransactionsListBox_SelectedIndexChanged);
      // 
      // BankAccountForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(775, 633);
      this.Controls.Add(this.accountInformationGroupBox);
      this.Controls.Add(this.accountTypeGroupBox);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.lastNameLabel);
      this.Controls.Add(this.firstNameTextBox);
      this.Controls.Add(this.firstNameLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "BankAccountForm";
      this.Text = "Bank Account Form";
      this.accountTypeGroupBox.ResumeLayout(false);
      this.accountTypeGroupBox.PerformLayout();
      this.accountInformationGroupBox.ResumeLayout(false);
      this.accountInformationGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Label firstNameLabel;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.Label lastNameLabel;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.RadioButton chequingAccountRadioButton;
    private System.Windows.Forms.RadioButton savingsAccountRadioButton;
    private System.Windows.Forms.Button createButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Label accountNumberLabel;
    private System.Windows.Forms.Label transactionsLabel;
    private System.Windows.Forms.Label addTransactionLabel;
    private System.Windows.Forms.TextBox accountNumberTextBox;
    private System.Windows.Forms.Label currentBalanceLabel;
    private System.Windows.Forms.TextBox currentBalanceTextBox;
    private System.Windows.Forms.GroupBox accountTypeGroupBox;
    private System.Windows.Forms.GroupBox accountInformationGroupBox;
    private System.Windows.Forms.Button addTransactionButton;
    private System.Windows.Forms.TextBox amountTextBox;
    private System.Windows.Forms.Label amountLabel;
    private System.Windows.Forms.RadioButton depositRadioButton;
    private System.Windows.Forms.RadioButton withdrawRadioButton;
    private System.Windows.Forms.ListBox transactionsListBox;
    private System.Windows.Forms.Label statusLabel;
    }
  }

