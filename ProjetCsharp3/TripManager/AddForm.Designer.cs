namespace TripManager
{
    partial class AddForm
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
            this.TagLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.StartingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndingTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TagTB = new System.Windows.Forms.TextBox();
            this.DescriptionTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TagLabel
            // 
            this.TagLabel.AutoSize = true;
            this.TagLabel.Location = new System.Drawing.Point(69, 89);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(41, 17);
            this.TagLabel.TabIndex = 0;
            this.TagLabel.Text = "Tag :";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(69, 128);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(97, 17);
            this.StartDateLabel.TabIndex = 1;
            this.StartDateLabel.Text = "Starting date :";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(69, 169);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(92, 17);
            this.EndDateLabel.TabIndex = 2;
            this.EndDateLabel.Text = "Ending date :";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(69, 212);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(87, 17);
            this.DescriptionLabel.TabIndex = 3;
            this.DescriptionLabel.Text = "Description :";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(208, 390);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 4;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(356, 390);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StartingDatePicker
            // 
            this.StartingDatePicker.Location = new System.Drawing.Point(183, 128);
            this.StartingDatePicker.Name = "StartingDatePicker";
            this.StartingDatePicker.Size = new System.Drawing.Size(200, 22);
            this.StartingDatePicker.TabIndex = 6;
            // 
            // EndingTimePicker
            // 
            this.EndingTimePicker.Location = new System.Drawing.Point(183, 169);
            this.EndingTimePicker.Name = "EndingTimePicker";
            this.EndingTimePicker.Size = new System.Drawing.Size(200, 22);
            this.EndingTimePicker.TabIndex = 7;
            // 
            // TagTB
            // 
            this.TagTB.Location = new System.Drawing.Point(183, 89);
            this.TagTB.Name = "TagTB";
            this.TagTB.Size = new System.Drawing.Size(335, 22);
            this.TagTB.TabIndex = 8;
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.Location = new System.Drawing.Point(183, 212);
            this.DescriptionTB.Multiline = true;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(335, 155);
            this.DescriptionTB.TabIndex = 9;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.DescriptionTB);
            this.Controls.Add(this.TagTB);
            this.Controls.Add(this.EndingTimePicker);
            this.Controls.Add(this.StartingDatePicker);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.TagLabel);
            this.Name = "AddForm";
            this.Text = "New Trip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.DateTimePicker StartingDatePicker;
        private System.Windows.Forms.DateTimePicker EndingTimePicker;
        private System.Windows.Forms.TextBox TagTB;
        private System.Windows.Forms.TextBox DescriptionTB;
    }
}