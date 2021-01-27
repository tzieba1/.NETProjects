namespace Lab5A
{
  partial class DropInTheBucketForm
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
      this.ControlPanel = new System.Windows.Forms.Panel();
      this.SpeedLabel = new System.Windows.Forms.Label();
      this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
      this.ExitButton = new System.Windows.Forms.Button();
      this.ColorButton = new System.Windows.Forms.Button();
      this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
      this.FaucetPictureBox = new System.Windows.Forms.PictureBox();
      this.LiquidColorDialog = new System.Windows.Forms.ColorDialog();
      this.DrawingPanel = new System.Windows.Forms.Panel();
      this.ControlPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.FaucetPictureBox)).BeginInit();
      this.DrawingPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // ControlPanel
      // 
      this.ControlPanel.BackColor = System.Drawing.SystemColors.Control;
      this.ControlPanel.Controls.Add(this.SpeedLabel);
      this.ControlPanel.Controls.Add(this.SpeedTrackBar);
      this.ControlPanel.Controls.Add(this.ExitButton);
      this.ControlPanel.Controls.Add(this.ColorButton);
      this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.ControlPanel.Location = new System.Drawing.Point(0, 0);
      this.ControlPanel.Name = "ControlPanel";
      this.ControlPanel.Size = new System.Drawing.Size(509, 75);
      this.ControlPanel.TabIndex = 0;
      // 
      // SpeedLabel
      // 
      this.SpeedLabel.AutoSize = true;
      this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SpeedLabel.Location = new System.Drawing.Point(346, 9);
      this.SpeedLabel.Name = "SpeedLabel";
      this.SpeedLabel.Size = new System.Drawing.Size(55, 18);
      this.SpeedLabel.TabIndex = 3;
      this.SpeedLabel.Text = "Speed";
      // 
      // SpeedTrackBar
      // 
      this.SpeedTrackBar.Location = new System.Drawing.Point(247, 27);
      this.SpeedTrackBar.Maximum = 20;
      this.SpeedTrackBar.Name = "SpeedTrackBar";
      this.SpeedTrackBar.Size = new System.Drawing.Size(250, 45);
      this.SpeedTrackBar.TabIndex = 2;
      this.SpeedTrackBar.Scroll += new System.EventHandler(this.SpeedTrackBar_Scroll);
      // 
      // ExitButton
      // 
      this.ExitButton.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ExitButton.Location = new System.Drawing.Point(14, 13);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(75, 30);
      this.ExitButton.TabIndex = 1;
      this.ExitButton.Text = "Exit";
      this.ExitButton.UseVisualStyleBackColor = true;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      // 
      // ColorButton
      // 
      this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ColorButton.Location = new System.Drawing.Point(95, 13);
      this.ColorButton.Name = "ColorButton";
      this.ColorButton.Size = new System.Drawing.Size(75, 30);
      this.ColorButton.TabIndex = 0;
      this.ColorButton.Text = "Colour";
      this.ColorButton.UseVisualStyleBackColor = true;
      this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
      // 
      // AnimationTimer
      // 
      this.AnimationTimer.Interval = 60;
      this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
      // 
      // FaucetPictureBox
      // 
      this.FaucetPictureBox.Image = global::Lab5A.Properties.Resources.Faucet;
      this.FaucetPictureBox.InitialImage = global::Lab5A.Properties.Resources.Faucet;
      this.FaucetPictureBox.Location = new System.Drawing.Point(150, 50);
      this.FaucetPictureBox.Name = "FaucetPictureBox";
      this.FaucetPictureBox.Size = new System.Drawing.Size(90, 68);
      this.FaucetPictureBox.TabIndex = 1;
      this.FaucetPictureBox.TabStop = false;
      // 
      // DrawingPanel
      // 
      this.DrawingPanel.Controls.Add(this.FaucetPictureBox);
      this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.DrawingPanel.Location = new System.Drawing.Point(0, 75);
      this.DrawingPanel.Name = "DrawingPanel";
      this.DrawingPanel.Size = new System.Drawing.Size(509, 436);
      this.DrawingPanel.TabIndex = 2;
      this.DrawingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawingPanel_Paint);
      // 
      // DropInTheBucketForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(509, 511);
      this.Controls.Add(this.DrawingPanel);
      this.Controls.Add(this.ControlPanel);
      this.Name = "DropInTheBucketForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "A Drop In The Bucket";
      this.ControlPanel.ResumeLayout(false);
      this.ControlPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.FaucetPictureBox)).EndInit();
      this.DrawingPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel ControlPanel;
    private System.Windows.Forms.Label SpeedLabel;
    private System.Windows.Forms.TrackBar SpeedTrackBar;
    private System.Windows.Forms.Button ExitButton;
    private System.Windows.Forms.Button ColorButton;
    private System.Windows.Forms.Timer AnimationTimer;
    private System.Windows.Forms.PictureBox FaucetPictureBox;
    private System.Windows.Forms.ColorDialog LiquidColorDialog;
    private System.Windows.Forms.Panel DrawingPanel;
  }
}

