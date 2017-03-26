namespace Inpres_Map
{
    partial class InpresMapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InpresMapForm));
            this.InpresMapPB = new System.Windows.Forms.PictureBox();
            this.ToolbarS = new System.Windows.Forms.ToolStrip();
            this.PoiTB = new System.Windows.Forms.ToolStripButton();
            this.PolylineTB = new System.Windows.Forms.ToolStripButton();
            this.PolygonTB = new System.Windows.Forms.ToolStripButton();
            this.DescriptionTB = new System.Windows.Forms.ToolStripTextBox();
            this.ColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.ColorButton = new System.Windows.Forms.ToolStripButton();
            this.ModeDD = new System.Windows.Forms.ToolStripDropDownButton();
            this.CreateMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.MenuS = new System.Windows.Forms.MenuStrip();
            this.FileMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMI = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMI = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PGrid = new System.Windows.Forms.PropertyGrid();
            this.PolygonLB = new System.Windows.Forms.ListBox();
            this.PolylineLB = new System.Windows.Forms.ListBox();
            this.PoiLB = new System.Windows.Forms.ListBox();
            this.LabelPOI = new System.Windows.Forms.Label();
            this.LabelPolyline = new System.Windows.Forms.Label();
            this.LabelPolygon = new System.Windows.Forms.Label();
            this.ButtonValidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InpresMapPB)).BeginInit();
            this.ToolbarS.SuspendLayout();
            this.MenuS.SuspendLayout();
            this.SuspendLayout();
            // 
            // InpresMapPB
            // 
            this.InpresMapPB.BackColor = System.Drawing.Color.White;
            this.InpresMapPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InpresMapPB.Location = new System.Drawing.Point(238, 47);
            this.InpresMapPB.Margin = new System.Windows.Forms.Padding(2);
            this.InpresMapPB.Name = "InpresMapPB";
            this.InpresMapPB.Size = new System.Drawing.Size(792, 483);
            this.InpresMapPB.TabIndex = 0;
            this.InpresMapPB.TabStop = false;
            this.InpresMapPB.Click += new System.EventHandler(this.InpresMapPB_Click);
            this.InpresMapPB.Paint += new System.Windows.Forms.PaintEventHandler(this.InpresMapPB_Paint);
            this.InpresMapPB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.InpresMapPB_MouseClick);
            // 
            // ToolbarS
            // 
            this.ToolbarS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolbarS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolbarS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PoiTB,
            this.PolylineTB,
            this.PolygonTB,
            this.DescriptionTB,
            this.ColorLabel,
            this.ColorButton,
            this.ModeDD,
            this.DeleteButton});
            this.ToolbarS.Location = new System.Drawing.Point(0, 24);
            this.ToolbarS.Name = "ToolbarS";
            this.ToolbarS.Size = new System.Drawing.Size(1040, 27);
            this.ToolbarS.TabIndex = 1;
            this.ToolbarS.Text = "toolStrip1";
            this.ToolbarS.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolbarS_ItemClicked);
            // 
            // PoiTB
            // 
            this.PoiTB.Checked = true;
            this.PoiTB.CheckOnClick = true;
            this.PoiTB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PoiTB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PoiTB.Image = ((System.Drawing.Image)(resources.GetObject("PoiTB.Image")));
            this.PoiTB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PoiTB.Name = "PoiTB";
            this.PoiTB.Size = new System.Drawing.Size(24, 24);
            this.PoiTB.ToolTipText = "POI";
            this.PoiTB.Click += new System.EventHandler(this.PoiTB_Click);
            // 
            // PolylineTB
            // 
            this.PolylineTB.CheckOnClick = true;
            this.PolylineTB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolylineTB.Image = ((System.Drawing.Image)(resources.GetObject("PolylineTB.Image")));
            this.PolylineTB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolylineTB.Name = "PolylineTB";
            this.PolylineTB.Size = new System.Drawing.Size(24, 24);
            this.PolylineTB.ToolTipText = "Polyline";
            this.PolylineTB.Click += new System.EventHandler(this.PolylineTB_Click);
            // 
            // PolygonTB
            // 
            this.PolygonTB.CheckOnClick = true;
            this.PolygonTB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PolygonTB.Image = ((System.Drawing.Image)(resources.GetObject("PolygonTB.Image")));
            this.PolygonTB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PolygonTB.Name = "PolygonTB";
            this.PolygonTB.Size = new System.Drawing.Size(24, 24);
            this.PolygonTB.ToolTipText = "Polygon";
            this.PolygonTB.Click += new System.EventHandler(this.PolygonTB_Click);
            // 
            // DescriptionTB
            // 
            this.DescriptionTB.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTB.Name = "DescriptionTB";
            this.DescriptionTB.Size = new System.Drawing.Size(76, 27);
            this.DescriptionTB.Text = "Description";
            this.DescriptionTB.Click += new System.EventHandler(this.toolStripTextBox2_Click_1);
            // 
            // ColorLabel
            // 
            this.ColorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(36, 24);
            this.ColorLabel.Text = "Color";
            this.ColorLabel.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Red;
            this.ColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.ColorButton.ForeColor = System.Drawing.Color.Transparent;
            this.ColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(23, 24);
            this.ColorButton.Text = "ColorButton";
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ModeDD
            // 
            this.ModeDD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ModeDD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateMI,
            this.SelectMI,
            this.MoveMI});
            this.ModeDD.Image = ((System.Drawing.Image)(resources.GetObject("ModeDD.Image")));
            this.ModeDD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModeDD.Name = "ModeDD";
            this.ModeDD.Size = new System.Drawing.Size(51, 24);
            this.ModeDD.Text = "Mode";
            // 
            // CreateMI
            // 
            this.CreateMI.Checked = true;
            this.CreateMI.CheckOnClick = true;
            this.CreateMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateMI.Name = "CreateMI";
            this.CreateMI.Size = new System.Drawing.Size(108, 22);
            this.CreateMI.Text = "Create";
            this.CreateMI.Click += new System.EventHandler(this.CreateMI_Click);
            // 
            // SelectMI
            // 
            this.SelectMI.CheckOnClick = true;
            this.SelectMI.Name = "SelectMI";
            this.SelectMI.Size = new System.Drawing.Size(108, 22);
            this.SelectMI.Text = "Select";
            this.SelectMI.Click += new System.EventHandler(this.SelectMI_Click);
            // 
            // MoveMI
            // 
            this.MoveMI.CheckOnClick = true;
            this.MoveMI.Name = "MoveMI";
            this.MoveMI.Size = new System.Drawing.Size(108, 22);
            this.MoveMI.Text = "Move";
            this.MoveMI.Click += new System.EventHandler(this.MoveMI_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(91, 24);
            this.DeleteButton.Text = "Delete Selected";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MenuS
            // 
            this.MenuS.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMI,
            this.ToolsMI,
            this.HelpMI});
            this.MenuS.Location = new System.Drawing.Point(0, 0);
            this.MenuS.Name = "MenuS";
            this.MenuS.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuS.Size = new System.Drawing.Size(1040, 24);
            this.MenuS.TabIndex = 2;
            this.MenuS.Text = "menuStrip1";
            // 
            // FileMI
            // 
            this.FileMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTS});
            this.FileMI.Name = "FileMI";
            this.FileMI.Size = new System.Drawing.Size(37, 20);
            this.FileMI.Text = "File";
            this.FileMI.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // OpenTS
            // 
            this.OpenTS.Name = "OpenTS";
            this.OpenTS.Size = new System.Drawing.Size(112, 22);
            this.OpenTS.Text = "Open...";
            this.OpenTS.ToolTipText = "Ouvrir fichier";
            this.OpenTS.Click += new System.EventHandler(this.OpenTS_Click);
            // 
            // ToolsMI
            // 
            this.ToolsMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsMI});
            this.ToolsMI.Name = "ToolsMI";
            this.ToolsMI.Size = new System.Drawing.Size(47, 20);
            this.ToolsMI.Text = "Tools";
            // 
            // OptionsMI
            // 
            this.OptionsMI.Name = "OptionsMI";
            this.OptionsMI.Size = new System.Drawing.Size(152, 22);
            this.OptionsMI.Text = "Options";
            this.OptionsMI.Click += new System.EventHandler(this.OptionsMI_Click);
            // 
            // HelpMI
            // 
            this.HelpMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMI});
            this.HelpMI.Name = "HelpMI";
            this.HelpMI.Size = new System.Drawing.Size(44, 20);
            this.HelpMI.Text = "Help";
            // 
            // AboutMI
            // 
            this.AboutMI.Name = "AboutMI";
            this.AboutMI.Size = new System.Drawing.Size(107, 22);
            this.AboutMI.Text = "About";
            this.AboutMI.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // PGrid
            // 
            this.PGrid.Location = new System.Drawing.Point(9, 361);
            this.PGrid.Margin = new System.Windows.Forms.Padding(2);
            this.PGrid.Name = "PGrid";
            this.PGrid.Size = new System.Drawing.Size(225, 169);
            this.PGrid.TabIndex = 3;
            this.PGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PGrid_PropertyValueChanged);
            this.PGrid.Click += new System.EventHandler(this.PGrid_Click);
            // 
            // PolygonLB
            // 
            this.PolygonLB.FormattingEnabled = true;
            this.PolygonLB.Location = new System.Drawing.Point(9, 275);
            this.PolygonLB.Margin = new System.Windows.Forms.Padding(2);
            this.PolygonLB.Name = "PolygonLB";
            this.PolygonLB.Size = new System.Drawing.Size(226, 82);
            this.PolygonLB.TabIndex = 4;
            this.PolygonLB.SelectedIndexChanged += new System.EventHandler(this.PolygonLB_SelectedIndexChanged);
            // 
            // PolylineLB
            // 
            this.PolylineLB.FormattingEnabled = true;
            this.PolylineLB.Location = new System.Drawing.Point(9, 175);
            this.PolylineLB.Margin = new System.Windows.Forms.Padding(2);
            this.PolylineLB.Name = "PolylineLB";
            this.PolylineLB.Size = new System.Drawing.Size(226, 82);
            this.PolylineLB.TabIndex = 5;
            this.PolylineLB.SelectedIndexChanged += new System.EventHandler(this.PolylineLB_SelectedIndexChanged);
            // 
            // PoiLB
            // 
            this.PoiLB.FormattingEnabled = true;
            this.PoiLB.Location = new System.Drawing.Point(9, 75);
            this.PoiLB.Margin = new System.Windows.Forms.Padding(2);
            this.PoiLB.Name = "PoiLB";
            this.PoiLB.Size = new System.Drawing.Size(226, 82);
            this.PoiLB.TabIndex = 6;
            this.PoiLB.SelectedIndexChanged += new System.EventHandler(this.PoiLB_SelectedIndexChanged);
            // 
            // LabelPOI
            // 
            this.LabelPOI.AutoSize = true;
            this.LabelPOI.Location = new System.Drawing.Point(9, 58);
            this.LabelPOI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPOI.Name = "LabelPOI";
            this.LabelPOI.Size = new System.Drawing.Size(25, 13);
            this.LabelPOI.TabIndex = 7;
            this.LabelPOI.Text = "POI";
            this.LabelPOI.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelPolyline
            // 
            this.LabelPolyline.AutoSize = true;
            this.LabelPolyline.Location = new System.Drawing.Point(7, 158);
            this.LabelPolyline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPolyline.Name = "LabelPolyline";
            this.LabelPolyline.Size = new System.Drawing.Size(43, 13);
            this.LabelPolyline.TabIndex = 8;
            this.LabelPolyline.Text = "Polyline";
            // 
            // LabelPolygon
            // 
            this.LabelPolygon.AutoSize = true;
            this.LabelPolygon.Location = new System.Drawing.Point(9, 258);
            this.LabelPolygon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPolygon.Name = "LabelPolygon";
            this.LabelPolygon.Size = new System.Drawing.Size(45, 13);
            this.LabelPolygon.TabIndex = 9;
            this.LabelPolygon.Text = "Polygon";
            // 
            // ButtonValidate
            // 
            this.ButtonValidate.Location = new System.Drawing.Point(362, 24);
            this.ButtonValidate.Name = "ButtonValidate";
            this.ButtonValidate.Size = new System.Drawing.Size(75, 23);
            this.ButtonValidate.TabIndex = 11;
            this.ButtonValidate.Text = "Polygon OK";
            this.ButtonValidate.UseVisualStyleBackColor = true;
            this.ButtonValidate.Visible = false;
            this.ButtonValidate.Click += new System.EventHandler(this.ButtonValidate_Click);
            // 
            // InpresMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1040, 540);
            this.Controls.Add(this.ButtonValidate);
            this.Controls.Add(this.LabelPolygon);
            this.Controls.Add(this.LabelPolyline);
            this.Controls.Add(this.LabelPOI);
            this.Controls.Add(this.InpresMapPB);
            this.Controls.Add(this.PoiLB);
            this.Controls.Add(this.PolylineLB);
            this.Controls.Add(this.PolygonLB);
            this.Controls.Add(this.PGrid);
            this.Controls.Add(this.ToolbarS);
            this.Controls.Add(this.MenuS);
            this.MainMenuStrip = this.MenuS;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InpresMapForm";
            this.Text = "Inpres-Map";
            ((System.ComponentModel.ISupportInitialize)(this.InpresMapPB)).EndInit();
            this.ToolbarS.ResumeLayout(false);
            this.ToolbarS.PerformLayout();
            this.MenuS.ResumeLayout(false);
            this.MenuS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InpresMapPB;
        private System.Windows.Forms.ToolStrip ToolbarS;
        private System.Windows.Forms.MenuStrip MenuS;
        private System.Windows.Forms.ToolStripMenuItem FileMI;
        private System.Windows.Forms.ToolStripMenuItem ToolsMI;
        private System.Windows.Forms.ToolStripMenuItem OptionsMI;
        private System.Windows.Forms.ToolStripMenuItem HelpMI;
        private System.Windows.Forms.ToolStripMenuItem AboutMI;
        private System.Windows.Forms.ToolStripButton PoiTB;
        private System.Windows.Forms.ToolStripButton PolylineTB;
        private System.Windows.Forms.ToolStripButton PolygonTB;
        private System.Windows.Forms.ToolStripTextBox DescriptionTB;
        private System.Windows.Forms.ToolStripLabel ColorLabel;
        private System.Windows.Forms.ToolStripDropDownButton ModeDD;
        private System.Windows.Forms.ToolStripMenuItem CreateMI;
        private System.Windows.Forms.ToolStripMenuItem SelectMI;
        private System.Windows.Forms.ToolStripMenuItem MoveMI;
        private System.Windows.Forms.PropertyGrid PGrid;
        private System.Windows.Forms.ListBox PolygonLB;
        private System.Windows.Forms.ListBox PolylineLB;
        private System.Windows.Forms.ListBox PoiLB;
        private System.Windows.Forms.ToolStripButton ColorButton;
        private System.Windows.Forms.Label LabelPOI;
        private System.Windows.Forms.Label LabelPolyline;
        private System.Windows.Forms.Label LabelPolygon;
        private System.Windows.Forms.ToolStripMenuItem OpenTS;
        private System.Windows.Forms.Button ButtonValidate;
        private System.Windows.Forms.ToolStripButton DeleteButton;
    }
}

