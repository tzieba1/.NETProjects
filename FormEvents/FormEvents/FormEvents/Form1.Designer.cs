namespace FormEvents
{
    partial class FormAlbum
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
            this.albumPictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.albumListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.informationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.increaseButton = new System.Windows.Forms.Button();
            this.decreaseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.albumPictureBox.Location = new System.Drawing.Point(303, 196);
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.Size = new System.Drawing.Size(220, 220);
            this.albumPictureBox.TabIndex = 0;
            this.albumPictureBox.TabStop = false;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(427, 431);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(96, 30);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(303, 431);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(91, 30);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(32, 29);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(69, 13);
            this.labelInformation.TabIndex = 3;
            this.labelInformation.Text = "Select Album";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(35, 196);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(241, 220);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "";
            this.descriptionRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.descriptionRichTextBox_LinkClicked);
            // 
            // albumListComboBox
            // 
            this.albumListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumListComboBox.FormattingEnabled = true;
            this.albumListComboBox.Location = new System.Drawing.Point(177, 26);
            this.albumListComboBox.Name = "albumListComboBox";
            this.albumListComboBox.Size = new System.Drawing.Size(346, 21);
            this.albumListComboBox.TabIndex = 0;
            this.informationToolTip.SetToolTip(this.albumListComboBox, "Please select album to view ");
            this.albumListComboBox.SelectedIndexChanged += new System.EventHandler(this.AlbumListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Album Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artist";
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.Location = new System.Drawing.Point(177, 63);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.ReadOnly = true;
            this.albumTitleTextBox.Size = new System.Drawing.Size(241, 20);
            this.albumTitleTextBox.TabIndex = 8;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(177, 95);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.ReadOnly = true;
            this.artistTextBox.Size = new System.Drawing.Size(241, 20);
            this.artistTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(35, 438);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(29, 23);
            this.increaseButton.TabIndex = 10;
            this.increaseButton.Text = "+";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Click += new System.EventHandler(this.changeFontSizeButton);
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(70, 438);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(29, 23);
            this.decreaseButton.TabIndex = 10;
            this.decreaseButton.Text = "-";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.changeFontSizeButton);
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 504);
            this.Controls.Add(this.decreaseButton);
            this.Controls.Add(this.increaseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumListComboBox);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.albumPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAlbum";
            this.Text = "Album Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox albumPictureBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.ComboBox albumListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip informationToolTip;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.Button decreaseButton;
    }
}

