namespace DrawIt
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
      this.components = new System.ComponentModel.Container();
      this.DrawingPanel = new System.Windows.Forms.Panel();
      this.StartButton = new System.Windows.Forms.Button();
      this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.IntervalTrackBar = new System.Windows.Forms.TrackBar();
      this.IntervalLabel = new System.Windows.Forms.Label();
      this.DrawingPanel.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.IntervalTrackBar)).BeginInit();
      this.SuspendLayout();
      // 
      // DrawingPanel
      // 
      this.DrawingPanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.DrawingPanel.Controls.Add(this.panel1);
      this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DrawingPanel.Location = new System.Drawing.Point(0, 0);
      this.DrawingPanel.Name = "DrawingPanel";
      this.DrawingPanel.Size = new System.Drawing.Size(800, 450);
      this.DrawingPanel.TabIndex = 0;
      // 
      // StartButton
      // 
      this.StartButton.Location = new System.Drawing.Point(12, 22);
      this.StartButton.Name = "StartButton";
      this.StartButton.Size = new System.Drawing.Size(75, 23);
      this.StartButton.TabIndex = 1;
      this.StartButton.Text = "Start";
      this.StartButton.UseVisualStyleBackColor = true;
      this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
      // 
      // AnimationTimer
      // 
      this.AnimationTimer.Interval = 60;
      this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.Control;
      this.panel1.Controls.Add(this.StartButton);
      this.panel1.Controls.Add(this.IntervalLabel);
      this.panel1.Controls.Add(this.IntervalTrackBar);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 66);
      this.panel1.TabIndex = 0;
      // 
      // IntervalTrackBar
      // 
      this.IntervalTrackBar.LargeChange = 10;
      this.IntervalTrackBar.Location = new System.Drawing.Point(534, 12);
      this.IntervalTrackBar.Maximum = 200;
      this.IntervalTrackBar.Minimum = 10;
      this.IntervalTrackBar.Name = "IntervalTrackBar";
      this.IntervalTrackBar.Size = new System.Drawing.Size(235, 45);
      this.IntervalTrackBar.SmallChange = 10;
      this.IntervalTrackBar.TabIndex = 0;
      this.IntervalTrackBar.TickFrequency = 10;
      this.IntervalTrackBar.Value = 10;
      this.IntervalTrackBar.Scroll += new System.EventHandler(this.IntervalTrackBar_Scroll);
      // 
      // IntervalLabel
      // 
      this.IntervalLabel.AutoSize = true;
      this.IntervalLabel.Location = new System.Drawing.Point(147, 22);
      this.IntervalLabel.Name = "IntervalLabel";
      this.IntervalLabel.Size = new System.Drawing.Size(0, 13);
      this.IntervalLabel.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.DrawingPanel);
      this.Name = "Form1";
      this.Text = "Form1";
      this.DrawingPanel.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.IntervalTrackBar)).EndInit();
      this.ResumeLayout(false);

      }

    #endregion
    private System.Windows.Forms.Panel DrawingPanel;
    private System.Windows.Forms.Button StartButton;
    private System.Windows.Forms.Timer AnimationTimer;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TrackBar IntervalTrackBar;
    private System.Windows.Forms.Label IntervalLabel;
    }
  }

