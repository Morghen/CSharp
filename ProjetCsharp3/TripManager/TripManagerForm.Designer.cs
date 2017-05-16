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
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagementMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TrajetLabel = new System.Windows.Forms.Label();
            this.SitesLabel = new System.Windows.Forms.Label();
            this.SplitContaierGD = new System.Windows.Forms.SplitContainer();
            this.PanelSites = new System.Windows.Forms.Panel();
            this.SitesLB = new System.Windows.Forms.ListBox();
            this.PanelTrajet = new System.Windows.Forms.Panel();
            this.TrajetTV = new System.Windows.Forms.TreeView();
            this.MenuTM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContaierGD)).BeginInit();
            this.SplitContaierGD.Panel1.SuspendLayout();
            this.SplitContaierGD.Panel2.SuspendLayout();
            this.SplitContaierGD.SuspendLayout();
            this.PanelSites.SuspendLayout();
            this.PanelTrajet.SuspendLayout();
            this.SuspendLayout();
            // 
            // GMapArea
            // 
            this.GMapArea.Bearing = 0F;
            this.GMapArea.CanDragMap = true;
            this.GMapArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GMapArea.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMapArea.GrayScaleMode = false;
            this.GMapArea.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMapArea.LevelsKeepInMemmory = 5;
            this.GMapArea.Location = new System.Drawing.Point(0, 0);
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
            this.GMapArea.Size = new System.Drawing.Size(866, 569);
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
            // 
            // MenuTM
            // 
            this.MenuTM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuTM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.ManagementMenu,
            this.AboutMI});
            this.MenuTM.Location = new System.Drawing.Point(0, 0);
            this.MenuTM.Name = "MenuTM";
            this.MenuTM.Size = new System.Drawing.Size(1213, 28);
            this.MenuTM.TabIndex = 2;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.LoadMenu,
            this.SaveMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(44, 24);
            this.FileMenu.Text = "File";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(181, 26);
            this.AddMenu.Text = "New Trip...";
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // LoadMenu
            // 
            this.LoadMenu.Name = "LoadMenu";
            this.LoadMenu.Size = new System.Drawing.Size(181, 26);
            this.LoadMenu.Text = "Load Trip...";
            this.LoadMenu.Click += new System.EventHandler(this.LoadMenu_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(181, 26);
            this.SaveMenu.Text = "Save Trip...";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // ManagementMenu
            // 
            this.ManagementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.ManagementMenu.Name = "ManagementMenu";
            this.ManagementMenu.Size = new System.Drawing.Size(109, 24);
            this.ManagementMenu.Text = "Management";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // AboutMI
            // 
            this.AboutMI.Name = "AboutMI";
            this.AboutMI.Size = new System.Drawing.Size(62, 24);
            this.AboutMI.Text = "About";
            this.AboutMI.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // TrajetLabel
            // 
            this.TrajetLabel.AutoSize = true;
            this.TrajetLabel.Location = new System.Drawing.Point(3, 15);
            this.TrajetLabel.Name = "TrajetLabel";
            this.TrajetLabel.Size = new System.Drawing.Size(45, 17);
            this.TrajetLabel.TabIndex = 4;
            this.TrajetLabel.Text = "Trajet";
            // 
            // SitesLabel
            // 
            this.SitesLabel.AutoSize = true;
            this.SitesLabel.Location = new System.Drawing.Point(3, 284);
            this.SitesLabel.Name = "SitesLabel";
            this.SitesLabel.Size = new System.Drawing.Size(39, 17);
            this.SitesLabel.TabIndex = 6;
            this.SitesLabel.Text = "Sites";
            this.SitesLabel.Click += new System.EventHandler(this.SitesLabel_Click);
            // 
            // SplitContaierGD
            // 
            this.SplitContaierGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContaierGD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContaierGD.Location = new System.Drawing.Point(0, 53);
            this.SplitContaierGD.Name = "SplitContaierGD";
            // 
            // SplitContaierGD.Panel1
            // 
            this.SplitContaierGD.Panel1.Controls.Add(this.PanelSites);
            this.SplitContaierGD.Panel1.Controls.Add(this.SitesLabel);
            this.SplitContaierGD.Panel1.Controls.Add(this.PanelTrajet);
            this.SplitContaierGD.Panel1.Controls.Add(this.TrajetLabel);
            this.SplitContaierGD.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // SplitContaierGD.Panel2
            // 
            this.SplitContaierGD.Panel2.Controls.Add(this.GMapArea);
            this.SplitContaierGD.Size = new System.Drawing.Size(1213, 569);
            this.SplitContaierGD.SplitterDistance = 343;
            this.SplitContaierGD.TabIndex = 7;
            // 
            // PanelSites
            // 
            this.PanelSites.Controls.Add(this.SitesLB);
            this.PanelSites.Location = new System.Drawing.Point(2, 304);
            this.PanelSites.Name = "PanelSites";
            this.PanelSites.Size = new System.Drawing.Size(399, 262);
            this.PanelSites.TabIndex = 8;
            // 
            // SitesLB
            // 
            this.SitesLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SitesLB.FormattingEnabled = true;
            this.SitesLB.ItemHeight = 16;
            this.SitesLB.Location = new System.Drawing.Point(0, 0);
            this.SitesLB.Name = "SitesLB";
            this.SitesLB.Size = new System.Drawing.Size(399, 262);
            this.SitesLB.TabIndex = 5;
            // 
            // PanelTrajet
            // 
            this.PanelTrajet.Controls.Add(this.TrajetTV);
            this.PanelTrajet.Location = new System.Drawing.Point(3, 35);
            this.PanelTrajet.Name = "PanelTrajet";
            this.PanelTrajet.Size = new System.Drawing.Size(399, 185);
            this.PanelTrajet.TabIndex = 7;
            // 
            // TrajetTV
            // 
            this.TrajetTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrajetTV.Location = new System.Drawing.Point(0, 0);
            this.TrajetTV.Name = "TrajetTV";
            this.TrajetTV.Size = new System.Drawing.Size(399, 185);
            this.TrajetTV.TabIndex = 3;
            // 
            // TripManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 622);
            this.Controls.Add(this.SplitContaierGD);
            this.Controls.Add(this.ToolboxTM);
            this.Controls.Add(this.MenuTM);
            this.MainMenuStrip = this.MenuTM;
            this.Name = "TripManager";
            this.Text = "Trip Manager";
            this.MenuTM.ResumeLayout(false);
            this.MenuTM.PerformLayout();
            this.SplitContaierGD.Panel1.ResumeLayout(false);
            this.SplitContaierGD.Panel1.PerformLayout();
            this.SplitContaierGD.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContaierGD)).EndInit();
            this.SplitContaierGD.ResumeLayout(false);
            this.PanelSites.ResumeLayout(false);
            this.PanelTrajet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMapArea;
        private System.Windows.Forms.ToolStrip ToolboxTM;
        private System.Windows.Forms.MenuStrip MenuTM;
        private System.Windows.Forms.ToolStripMenuItem AboutMI;
        private System.Windows.Forms.Label TrajetLabel;
        private System.Windows.Forms.Label SitesLabel;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem ManagementMenu;
        private System.Windows.Forms.SplitContainer SplitContaierGD;
        private System.Windows.Forms.Panel PanelSites;
        private System.Windows.Forms.ListBox SitesLB;
        private System.Windows.Forms.Panel PanelTrajet;
        private System.Windows.Forms.TreeView TrajetTV;
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

