namespace Inpres_Map
{
    partial class OptionWindow
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
            this.ColorLabel = new System.Windows.Forms.Label();
            this.PrecisionLabel = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonApply = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonColorPicker = new System.Windows.Forms.Button();
            this.numericPrecision = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecision)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(74, 44);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(54, 13);
            this.ColorLabel.TabIndex = 0;
            this.ColorLabel.Text = "Text color";
            // 
            // PrecisionLabel
            // 
            this.PrecisionLabel.AutoSize = true;
            this.PrecisionLabel.Location = new System.Drawing.Point(74, 67);
            this.PrecisionLabel.Name = "PrecisionLabel";
            this.PrecisionLabel.Size = new System.Drawing.Size(82, 13);
            this.PrecisionLabel.TabIndex = 1;
            this.PrecisionLabel.Text = "Global precision";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(50, 111);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 2;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // ButtonApply
            // 
            this.ButtonApply.Location = new System.Drawing.Point(131, 111);
            this.ButtonApply.Name = "ButtonApply";
            this.ButtonApply.Size = new System.Drawing.Size(75, 23);
            this.ButtonApply.TabIndex = 3;
            this.ButtonApply.Text = "Apply";
            this.ButtonApply.UseVisualStyleBackColor = true;
            this.ButtonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(212, 111);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonColorPicker
            // 
            this.ButtonColorPicker.BackColor = System.Drawing.Color.Red;
            this.ButtonColorPicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonColorPicker.Location = new System.Drawing.Point(179, 39);
            this.ButtonColorPicker.Name = "ButtonColorPicker";
            this.ButtonColorPicker.Size = new System.Drawing.Size(75, 23);
            this.ButtonColorPicker.TabIndex = 5;
            this.ButtonColorPicker.UseVisualStyleBackColor = false;
            this.ButtonColorPicker.Click += new System.EventHandler(this.ButtonColorPicker_Click);
            // 
            // numericPrecision
            // 
            this.numericPrecision.Location = new System.Drawing.Point(179, 65);
            this.numericPrecision.Name = "numericPrecision";
            this.numericPrecision.Size = new System.Drawing.Size(48, 20);
            this.numericPrecision.TabIndex = 6;
            // 
            // OptionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(348, 142);
            this.Controls.Add(this.numericPrecision);
            this.Controls.Add(this.ButtonColorPicker);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonApply);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.PrecisionLabel);
            this.Controls.Add(this.ColorLabel);
            this.Name = "OptionWindow";
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label PrecisionLabel;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonApply;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonColorPicker;
        private System.Windows.Forms.NumericUpDown numericPrecision;
    }
}