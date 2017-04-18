namespace TripManager
{
    partial class TripManager
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
            this.GMapArea = new GMap.NET.WindowsForms.GMapControl();
            this.ToolboxTM = new System.Windows.Forms.ToolStrip();
            this.MenuTM = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTM.SuspendLayout();
            this.SuspendLayout();
            // 
            // GMapArea
            // 
            this.GMapArea.Bearing = 0F;
            this.GMapArea.CanDragMap = true;
            this.GMapArea.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapArea.GrayScaleMode = false;
            this.GMapArea.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapArea.LevelsKeepInMemmory = 5;
            this.GMapArea.Location = new System.Drawing.Point(532, 75);
            this.GMapArea.MarkersEnabled = true;
            this.GMapArea.MaxZoom = 18;
            this.GMapArea.MinZoom = 0;
            this.GMapArea.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMapArea.Name = "GMapArea";
            this.GMapArea.NegativeMode = false;
            this.GMapArea.PolygonsEnabled = true;
            this.GMapArea.RetryLoadTile = 0;
            this.GMapArea.RoutesEnabled = true;
            this.GMapArea.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMapArea.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMapArea.ShowTileGridLines = false;
            this.GMapArea.Size = new System.Drawing.Size(669, 535);
            this.GMapArea.TabIndex = 0;
            this.GMapArea.Zoom = 13D;
            this.GMapArea.Load += new System.EventHandler(this.GMapArea_Load);
            // 
            // ToolboxTM
            // 
            this.ToolboxTM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolboxTM.Location = new System.Drawing.Point(0, 28);
            this.ToolboxTM.Name = "ToolboxTM";
            this.ToolboxTM.Size = new System.Drawing.Size(1213, 25);
            this.ToolboxTM.TabIndex = 1;
            this.ToolboxTM.Text = "toolStrip1";
            this.ToolboxTM.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ToolboxTM_ItemClicked);
            // 
            // MenuTM
            // 
            this.MenuTM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.MenuTM.Location = new System.Drawing.Point(0, 0);
            this.MenuTM.Name = "MenuTM";
            this.MenuTM.Size = new System.Drawing.Size(1213, 28);
            this.MenuTM.TabIndex = 2;
            this.MenuTM.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TripManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 622);
            this.Controls.Add(this.ToolboxTM);
            this.Controls.Add(this.MenuTM);
            this.Controls.Add(this.GMapArea);
            this.MainMenuStrip = this.MenuTM;
            this.Name = "TripManager";
            this.Text = "Trip Manager";
            this.MenuTM.ResumeLayout(false);
            this.MenuTM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMapArea;
        private System.Windows.Forms.ToolStrip ToolboxTM;
        private System.Windows.Forms.MenuStrip MenuTM;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

