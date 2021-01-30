namespace Sorting
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
            this.StudentListBox = new System.Windows.Forms.ListBox();
            this.SortNameButton = new System.Windows.Forms.Button();
            this.SortGrade1Button = new System.Windows.Forms.Button();
            this.Grade1Then2Button = new System.Windows.Forms.Button();
            this.SortGrade2Button = new System.Windows.Forms.Button();
            this.SortAverageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentListBox
            // 
            this.StudentListBox.FormattingEnabled = true;
            this.StudentListBox.ItemHeight = 16;
            this.StudentListBox.Location = new System.Drawing.Point(34, 23);
            this.StudentListBox.Margin = new System.Windows.Forms.Padding(4);
            this.StudentListBox.Name = "StudentListBox";
            this.StudentListBox.Size = new System.Drawing.Size(648, 116);
            this.StudentListBox.TabIndex = 0;
            // 
            // SortNameButton
            // 
            this.SortNameButton.Location = new System.Drawing.Point(34, 158);
            this.SortNameButton.Name = "SortNameButton";
            this.SortNameButton.Size = new System.Drawing.Size(100, 47);
            this.SortNameButton.TabIndex = 1;
            this.SortNameButton.Text = "Sort by Last Name";
            this.SortNameButton.UseVisualStyleBackColor = true;
            this.SortNameButton.Click += new System.EventHandler(this.SortNameButton_Click);
            // 
            // SortGrade1Button
            // 
            this.SortGrade1Button.Location = new System.Drawing.Point(140, 158);
            this.SortGrade1Button.Name = "SortGrade1Button";
            this.SortGrade1Button.Size = new System.Drawing.Size(123, 47);
            this.SortGrade1Button.TabIndex = 1;
            this.SortGrade1Button.Text = "Sort by Grade1";
            this.SortGrade1Button.UseVisualStyleBackColor = true;
            this.SortGrade1Button.Click += new System.EventHandler(this.SortGrade1Button_Click);
            // 
            // Grade1Then2Button
            // 
            this.Grade1Then2Button.Location = new System.Drawing.Point(527, 158);
            this.Grade1Then2Button.Name = "Grade1Then2Button";
            this.Grade1Then2Button.Size = new System.Drawing.Size(155, 47);
            this.Grade1Then2Button.TabIndex = 1;
            this.Grade1Then2Button.Text = "Sort by Grade1 then Grade2";
            this.Grade1Then2Button.UseVisualStyleBackColor = true;
            this.Grade1Then2Button.Click += new System.EventHandler(this.Grade1Then2Button_Click);
            // 
            // SortGrade2Button
            // 
            this.SortGrade2Button.Location = new System.Drawing.Point(269, 158);
            this.SortGrade2Button.Name = "SortGrade2Button";
            this.SortGrade2Button.Size = new System.Drawing.Size(123, 47);
            this.SortGrade2Button.TabIndex = 1;
            this.SortGrade2Button.Text = "Sort by Grade2";
            this.SortGrade2Button.UseVisualStyleBackColor = true;
            this.SortGrade2Button.Click += new System.EventHandler(this.SortGrade2Button_Click);
            // 
            // SortAverageButton
            // 
            this.SortAverageButton.Location = new System.Drawing.Point(398, 158);
            this.SortAverageButton.Name = "SortAverageButton";
            this.SortAverageButton.Size = new System.Drawing.Size(123, 47);
            this.SortAverageButton.TabIndex = 1;
            this.SortAverageButton.Text = "Sort by Average";
            this.SortAverageButton.UseVisualStyleBackColor = true;
            this.SortAverageButton.Click += new System.EventHandler(this.SortAverageButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 231);
            this.Controls.Add(this.Grade1Then2Button);
            this.Controls.Add(this.SortAverageButton);
            this.Controls.Add(this.SortGrade2Button);
            this.Controls.Add(this.SortGrade1Button);
            this.Controls.Add(this.SortNameButton);
            this.Controls.Add(this.StudentListBox);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sorting using Lambda Expressions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox StudentListBox;
        private System.Windows.Forms.Button SortNameButton;
        private System.Windows.Forms.Button SortGrade1Button;
        private System.Windows.Forms.Button Grade1Then2Button;
        private System.Windows.Forms.Button SortGrade2Button;
        private System.Windows.Forms.Button SortAverageButton;
    }
}

