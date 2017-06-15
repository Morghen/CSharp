namespace TripManager
{
    partial class DialogSettings
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
            this.precisionLabel = new System.Windows.Forms.Label();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.numericPrecision = new System.Windows.Forms.NumericUpDown();
            this.ColorPickerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // precisionLabel
            // 
            this.precisionLabel.AutoSize = true;
            this.precisionLabel.Location = new System.Drawing.Point(76, 36);
            this.precisionLabel.Name = "precisionLabel";
            this.precisionLabel.Size = new System.Drawing.Size(56, 13);
            this.precisionLabel.TabIndex = 0;
            this.precisionLabel.Text = "Precision :";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(76, 79);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(70, 13);
            this.ColorLabel.TabIndex = 1;
            this.ColorLabel.Text = "Couleur POI :";
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(82, 140);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(227, 140);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // numericPrecision
            // 
            this.numericPrecision.Location = new System.Drawing.Point(182, 29);
            this.numericPrecision.Name = "numericPrecision";
            this.numericPrecision.Size = new System.Drawing.Size(120, 20);
            this.numericPrecision.TabIndex = 4;
            // 
            // ColorPickerButton
            // 
            this.ColorPickerButton.BackColor = System.Drawing.Color.Red;
            this.ColorPickerButton.ForeColor = System.Drawing.Color.Red;
            this.ColorPickerButton.Location = new System.Drawing.Point(226, 79);
            this.ColorPickerButton.Name = "ColorPickerButton";
            this.ColorPickerButton.Size = new System.Drawing.Size(75, 23);
            this.ColorPickerButton.TabIndex = 5;
            this.ColorPickerButton.UseVisualStyleBackColor = false;
            this.ColorPickerButton.Click += new System.EventHandler(this.ColorPickerButton_Click);
            // 
            // DialogSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 193);
            this.Controls.Add(this.ColorPickerButton);
            this.Controls.Add(this.numericPrecision);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.precisionLabel);
            this.Name = "DialogSettings";
            this.Text = "DialogSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label precisionLabel;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NumericUpDown numericPrecision;
        private System.Windows.Forms.Button ColorPickerButton;
    }
}