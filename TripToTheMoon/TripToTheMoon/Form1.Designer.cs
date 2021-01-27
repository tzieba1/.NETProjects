namespace TripToTheMoon
  {
  partial class Form1
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
      this.titleLabel = new System.Windows.Forms.Label();
      this.astronautNameLabel = new System.Windows.Forms.Label();
      this.departureDateLabel = new System.Windows.Forms.Label();
      this.tripListLabel = new System.Windows.Forms.Label();
      this.departureDateInformationLabel = new System.Windows.Forms.Label();
      this.tripListInformationLabel = new System.Windows.Forms.Label();
      this.bookTripButton = new System.Windows.Forms.Button();
      this.departureDateMonthCalendar = new System.Windows.Forms.MonthCalendar();
      this.astronautNameTextBox = new System.Windows.Forms.TextBox();
      this.tripListBox = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // titleLabel
      // 
      this.titleLabel.AutoSize = true;
      this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.titleLabel.Location = new System.Drawing.Point(26, 33);
      this.titleLabel.Name = "titleLabel";
      this.titleLabel.Size = new System.Drawing.Size(729, 91);
      this.titleLabel.TabIndex = 0;
      this.titleLabel.Text = "A Trip to the Moon!";
      // 
      // astronautNameLabel
      // 
      this.astronautNameLabel.AutoSize = true;
      this.astronautNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.astronautNameLabel.Location = new System.Drawing.Point(39, 140);
      this.astronautNameLabel.Name = "astronautNameLabel";
      this.astronautNameLabel.Size = new System.Drawing.Size(97, 13);
      this.astronautNameLabel.TabIndex = 1;
      this.astronautNameLabel.Text = "Astronaut Name";
      // 
      // departureDateLabel
      // 
      this.departureDateLabel.AutoSize = true;
      this.departureDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.departureDateLabel.Location = new System.Drawing.Point(39, 168);
      this.departureDateLabel.Name = "departureDateLabel";
      this.departureDateLabel.Size = new System.Drawing.Size(94, 13);
      this.departureDateLabel.TabIndex = 2;
      this.departureDateLabel.Text = "Departure Date";
      // 
      // tripListLabel
      // 
      this.tripListLabel.AutoSize = true;
      this.tripListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tripListLabel.Location = new System.Drawing.Point(398, 168);
      this.tripListLabel.Name = "tripListLabel";
      this.tripListLabel.Size = new System.Drawing.Size(53, 13);
      this.tripListLabel.TabIndex = 3;
      this.tripListLabel.Text = "Trip List";
      // 
      // departureDateInformationLabel
      // 
      this.departureDateInformationLabel.AutoSize = true;
      this.departureDateInformationLabel.Location = new System.Drawing.Point(39, 198);
      this.departureDateInformationLabel.Name = "departureDateInformationLabel";
      this.departureDateInformationLabel.Size = new System.Drawing.Size(305, 13);
      this.departureDateInformationLabel.TabIndex = 4;
      this.departureDateInformationLabel.Text = "Departs the first Saturday of every Month (must be in the future)";
      // 
      // tripListInformationLabel
      // 
      this.tripListInformationLabel.AutoSize = true;
      this.tripListInformationLabel.Location = new System.Drawing.Point(398, 198);
      this.tripListInformationLabel.Name = "tripListInformationLabel";
      this.tripListInformationLabel.Size = new System.Drawing.Size(170, 13);
      this.tripListInformationLabel.TabIndex = 5;
      this.tripListInformationLabel.Text = "Maximum 3 Astronauts on the Trip.";
      // 
      // bookTripButton
      // 
      this.bookTripButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.bookTripButton.Location = new System.Drawing.Point(39, 394);
      this.bookTripButton.Name = "bookTripButton";
      this.bookTripButton.Size = new System.Drawing.Size(94, 27);
      this.bookTripButton.TabIndex = 6;
      this.bookTripButton.Text = "Book Trip!";
      this.bookTripButton.UseVisualStyleBackColor = true;
      // 
      // departureDateMonthCalendar
      // 
      this.departureDateMonthCalendar.Location = new System.Drawing.Point(39, 220);
      this.departureDateMonthCalendar.Name = "departureDateMonthCalendar";
      this.departureDateMonthCalendar.TabIndex = 7;
      this.departureDateMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.DepartureDateMonthCalendar_DateChanged);
      // 
      // astronautNameTextBox
      // 
      this.astronautNameTextBox.Location = new System.Drawing.Point(144, 137);
      this.astronautNameTextBox.Name = "astronautNameTextBox";
      this.astronautNameTextBox.Size = new System.Drawing.Size(200, 20);
      this.astronautNameTextBox.TabIndex = 8;
      // 
      // tripListBox
      // 
      this.tripListBox.FormattingEnabled = true;
      this.tripListBox.Location = new System.Drawing.Point(401, 220);
      this.tripListBox.Name = "tripListBox";
      this.tripListBox.Size = new System.Drawing.Size(524, 160);
      this.tripListBox.TabIndex = 9;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(962, 455);
      this.Controls.Add(this.tripListBox);
      this.Controls.Add(this.astronautNameTextBox);
      this.Controls.Add(this.departureDateMonthCalendar);
      this.Controls.Add(this.bookTripButton);
      this.Controls.Add(this.tripListInformationLabel);
      this.Controls.Add(this.departureDateInformationLabel);
      this.Controls.Add(this.tripListLabel);
      this.Controls.Add(this.departureDateLabel);
      this.Controls.Add(this.astronautNameLabel);
      this.Controls.Add(this.titleLabel);
      this.Name = "Form1";
      this.Text = "LET\'S GO TO THE MOON";
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Label titleLabel;
    private System.Windows.Forms.Label astronautNameLabel;
    private System.Windows.Forms.Label departureDateLabel;
    private System.Windows.Forms.Label tripListLabel;
    private System.Windows.Forms.Label departureDateInformationLabel;
    private System.Windows.Forms.Label tripListInformationLabel;
    private System.Windows.Forms.Button bookTripButton;
    private System.Windows.Forms.MonthCalendar departureDateMonthCalendar;
    private System.Windows.Forms.TextBox astronautNameTextBox;
    private System.Windows.Forms.ListBox tripListBox;
    }
  }

