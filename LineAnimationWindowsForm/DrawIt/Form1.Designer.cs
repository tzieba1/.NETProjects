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
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.DrawingPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.IntervalTrackBar = new System.Windows.Forms.TrackBar();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.IntervalLabel);
            this.ControlPanel.Controls.Add(this.IntervalTrackBar);
            this.ControlPanel.Controls.Add(this.StartButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(1045, 54);
            this.ControlPanel.TabIndex = 0;
            // 
            // DrawingPanel
            // 
            this.DrawingPanel.BackColor = System.Drawing.Color.Black;
            this.DrawingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPanel.Location = new System.Drawing.Point(0, 54);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.Size = new System.Drawing.Size(1045, 519);
            this.DrawingPanel.TabIndex = 1;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(31, 13);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // IntervalTrackBar
            // 
            this.IntervalTrackBar.LargeChange = 10;
            this.IntervalTrackBar.Location = new System.Drawing.Point(154, 9);
            this.IntervalTrackBar.Maximum = 200;
            this.IntervalTrackBar.Minimum = 10;
            this.IntervalTrackBar.Name = "IntervalTrackBar";
            this.IntervalTrackBar.Size = new System.Drawing.Size(187, 45);
            this.IntervalTrackBar.SmallChange = 10;
            this.IntervalTrackBar.TabIndex = 1;
            this.IntervalTrackBar.TickFrequency = 10;
            this.IntervalTrackBar.Value = 10;
            this.IntervalTrackBar.Scroll += new System.EventHandler(this.IntervalTrackBar_Scroll);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(358, 13);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(0, 13);
            this.IntervalLabel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 573);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.ControlPanel);
            this.Name = "Form1";
            this.Text = "My Screen Saver";
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel DrawingPanel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.TrackBar IntervalTrackBar;
    }
}

