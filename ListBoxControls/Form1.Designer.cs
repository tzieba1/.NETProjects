namespace ListBoxControls
  {
  partial class listboxControlsForm
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
      this.nameLabel = new System.Windows.Forms.Label();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.namesListBox = new System.Windows.Forms.ListBox();
      this.addbutton = new System.Windows.Forms.Button();
      this.deleteButton = new System.Windows.Forms.Button();
      this.moveUpButton = new System.Windows.Forms.Button();
      this.moveDownButton = new System.Windows.Forms.Button();
      this.clearButton = new System.Windows.Forms.Button();
      this.statusLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameLabel.Location = new System.Drawing.Point(87, 80);
      this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(54, 17);
      this.nameLabel.TabIndex = 0;
      this.nameLabel.Text = "Name:";
      // 
      // nameTextBox
      // 
      this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.nameTextBox.Location = new System.Drawing.Point(213, 76);
      this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(289, 23);
      this.nameTextBox.TabIndex = 1;
      this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
      // 
      // namesListBox
      // 
      this.namesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.namesListBox.FormattingEnabled = true;
      this.namesListBox.ItemHeight = 16;
      this.namesListBox.Location = new System.Drawing.Point(92, 150);
      this.namesListBox.Margin = new System.Windows.Forms.Padding(4);
      this.namesListBox.Name = "namesListBox";
      this.namesListBox.Size = new System.Drawing.Size(410, 324);
      this.namesListBox.TabIndex = 2;
      // 
      // addbutton
      // 
      this.addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.addbutton.Location = new System.Drawing.Point(578, 76);
      this.addbutton.Margin = new System.Windows.Forms.Padding(4);
      this.addbutton.Name = "addbutton";
      this.addbutton.Size = new System.Drawing.Size(234, 42);
      this.addbutton.TabIndex = 3;
      this.addbutton.Text = "Add";
      this.addbutton.UseVisualStyleBackColor = true;
      this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
      // 
      // deleteButton
      // 
      this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.deleteButton.Location = new System.Drawing.Point(578, 164);
      this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(234, 46);
      this.deleteButton.TabIndex = 4;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
      // 
      // moveUpButton
      // 
      this.moveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.moveUpButton.Location = new System.Drawing.Point(578, 254);
      this.moveUpButton.Margin = new System.Windows.Forms.Padding(4);
      this.moveUpButton.Name = "moveUpButton";
      this.moveUpButton.Size = new System.Drawing.Size(234, 43);
      this.moveUpButton.TabIndex = 5;
      this.moveUpButton.Text = "Move Up";
      this.moveUpButton.UseVisualStyleBackColor = true;
      this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
      // 
      // moveDownButton
      // 
      this.moveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.moveDownButton.Location = new System.Drawing.Point(578, 346);
      this.moveDownButton.Margin = new System.Windows.Forms.Padding(4);
      this.moveDownButton.Name = "moveDownButton";
      this.moveDownButton.Size = new System.Drawing.Size(234, 43);
      this.moveDownButton.TabIndex = 6;
      this.moveDownButton.Text = "Move Down";
      this.moveDownButton.UseVisualStyleBackColor = true;
      // 
      // clearButton
      // 
      this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clearButton.Location = new System.Drawing.Point(578, 430);
      this.clearButton.Margin = new System.Windows.Forms.Padding(4);
      this.clearButton.Name = "clearButton";
      this.clearButton.Size = new System.Drawing.Size(234, 44);
      this.clearButton.TabIndex = 7;
      this.clearButton.Text = "Clear";
      this.clearButton.UseVisualStyleBackColor = true;
      this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
      // 
      // statusLabel
      // 
      this.statusLabel.AutoSize = true;
      this.statusLabel.ForeColor = System.Drawing.Color.LimeGreen;
      this.statusLabel.Location = new System.Drawing.Point(92, 496);
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(52, 17);
      this.statusLabel.TabIndex = 8;
      this.statusLabel.Text = "label1";
      // 
      // listboxControlsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(908, 554);
      this.Controls.Add(this.statusLabel);
      this.Controls.Add(this.clearButton);
      this.Controls.Add(this.moveDownButton);
      this.Controls.Add(this.moveUpButton);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.addbutton);
      this.Controls.Add(this.namesListBox);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(this.nameLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "listboxControlsForm";
      this.Text = "ListBox Controls";
      this.Load += new System.EventHandler(this.listboxControlsForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.ListBox namesListBox;
    private System.Windows.Forms.Button addbutton;
    private System.Windows.Forms.Button deleteButton;
    private System.Windows.Forms.Button moveUpButton;
    private System.Windows.Forms.Button moveDownButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Label statusLabel;
    }
  }

