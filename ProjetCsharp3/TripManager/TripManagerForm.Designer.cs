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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripManager));
            this.GMapArea = new GMap.NET.WindowsForms.GMapControl();
            this.ToolboxTM = new System.Windows.Forms.ToolStrip();
            this.EndTrajetButton = new System.Windows.Forms.ToolStripButton();
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
            this.ToolboxTM.SuspendLayout();
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
            this.GMapArea.Margin = new System.Windows.Forms.Padding(2);
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
            this.GMapArea.Size = new System.Drawing.Size(564, 475);
            this.GMapArea.TabIndex = 0;
            this.GMapArea.Zoom = 13D;
            this.GMapArea.Load += new System.EventHandler(this.GMapArea_Load);
            this.GMapArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GMapArea_MouseDown);
            // 
            // ToolboxTM
            // 
            this.ToolboxTM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolboxTM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EndTrajetButton});
            this.ToolboxTM.Location = new System.Drawing.Point(0, 24);
            this.ToolboxTM.Name = "ToolboxTM";
            this.ToolboxTM.Size = new System.Drawing.Size(910, 25);
            this.ToolboxTM.TabIndex = 1;
            this.ToolboxTM.Text = "toolStrip1";
            // 
            // EndTrajetButton
            // 
            this.EndTrajetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EndTrajetButton.Enabled = false;
            this.EndTrajetButton.Image = ((System.Drawing.Image)(resources.GetObject("EndTrajetButton.Image")));
            this.EndTrajetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EndTrajetButton.Name = "EndTrajetButton";
            this.EndTrajetButton.Size = new System.Drawing.Size(57, 22);
            this.EndTrajetButton.Text = "Fin trajet";
            this.EndTrajetButton.ToolTipText = "\r\n";
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
            this.MenuTM.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuTM.Size = new System.Drawing.Size(910, 24);
            this.MenuTM.TabIndex = 2;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenu,
            this.LoadMenu,
            this.SaveMenu});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // AddMenu
            // 
            this.AddMenu.Name = "AddMenu";
            this.AddMenu.Size = new System.Drawing.Size(132, 22);
            this.AddMenu.Text = "New Trip...";
            this.AddMenu.Click += new System.EventHandler(this.AddMenu_Click);
            // 
            // LoadMenu
            // 
            this.LoadMenu.Name = "LoadMenu";
            this.LoadMenu.Size = new System.Drawing.Size(132, 22);
            this.LoadMenu.Text = "Load Trip...";
            this.LoadMenu.Click += new System.EventHandler(this.LoadMenu_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(132, 22);
            this.SaveMenu.Text = "Save Trip...";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // ManagementMenu
            // 
            this.ManagementMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.ManagementMenu.Name = "ManagementMenu";
            this.ManagementMenu.Size = new System.Drawing.Size(90, 20);
            this.ManagementMenu.Text = "Management";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // AboutMI
            // 
            this.AboutMI.Name = "AboutMI";
            this.AboutMI.Size = new System.Drawing.Size(52, 20);
            this.AboutMI.Text = "About";
            this.AboutMI.Click += new System.EventHandler(this.AboutMenu_Click);
            // 
            // TrajetLabel
            // 
            this.TrajetLabel.AutoSize = true;
            this.TrajetLabel.Location = new System.Drawing.Point(2, 12);
            this.TrajetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrajetLabel.Name = "TrajetLabel";
            this.TrajetLabel.Size = new System.Drawing.Size(34, 13);
            this.TrajetLabel.TabIndex = 4;
            this.TrajetLabel.Text = "Trajet";
            // 
            // SitesLabel
            // 
            this.SitesLabel.AutoSize = true;
            this.SitesLabel.Location = new System.Drawing.Point(2, 231);
            this.SitesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SitesLabel.Name = "SitesLabel";
            this.SitesLabel.Size = new System.Drawing.Size(30, 13);
            this.SitesLabel.TabIndex = 6;
            this.SitesLabel.Text = "Sites";
            // 
            // SplitContaierGD
            // 
            this.SplitContaierGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContaierGD.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.SplitContaierGD.Location = new System.Drawing.Point(0, 49);
            this.SplitContaierGD.Margin = new System.Windows.Forms.Padding(2);
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
            this.SplitContaierGD.Size = new System.Drawing.Size(910, 475);
            this.SplitContaierGD.SplitterDistance = 343;
            this.SplitContaierGD.SplitterWidth = 3;
            this.SplitContaierGD.TabIndex = 7;
            // 
            // PanelSites
            // 
            this.PanelSites.Controls.Add(this.SitesLB);
            this.PanelSites.Location = new System.Drawing.Point(2, 247);
            this.PanelSites.Margin = new System.Windows.Forms.Padding(2);
            this.PanelSites.Name = "PanelSites";
            this.PanelSites.Size = new System.Drawing.Size(299, 213);
            this.PanelSites.TabIndex = 8;
            // 
            // SitesLB
            // 
            this.SitesLB.AllowDrop = true;
            this.SitesLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SitesLB.FormattingEnabled = true;
            this.SitesLB.Location = new System.Drawing.Point(0, 0);
            this.SitesLB.Margin = new System.Windows.Forms.Padding(2);
            this.SitesLB.Name = "SitesLB";
            this.SitesLB.Size = new System.Drawing.Size(299, 213);
            this.SitesLB.TabIndex = 5;
            // 
            // PanelTrajet
            // 
            this.PanelTrajet.Controls.Add(this.TrajetTV);
            this.PanelTrajet.Location = new System.Drawing.Point(2, 28);
            this.PanelTrajet.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTrajet.Name = "PanelTrajet";
            this.PanelTrajet.Size = new System.Drawing.Size(299, 150);
            this.PanelTrajet.TabIndex = 7;
            // 
            // TrajetTV
            // 
            this.TrajetTV.AllowDrop = true;
            this.TrajetTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrajetTV.Location = new System.Drawing.Point(0, 0);
            this.TrajetTV.Margin = new System.Windows.Forms.Padding(2);
            this.TrajetTV.Name = "TrajetTV";
            this.TrajetTV.Size = new System.Drawing.Size(299, 150);
            this.TrajetTV.TabIndex = 3;
            // 
            // TripManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 524);
            this.Controls.Add(this.SplitContaierGD);
            this.Controls.Add(this.ToolboxTM);
            this.Controls.Add(this.MenuTM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuTM;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TripManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TripManager_FormClosing);
            this.ToolboxTM.ResumeLayout(false);
            this.ToolboxTM.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem AddMenu;
        private System.Windows.Forms.ToolStripMenuItem LoadMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton EndTrajetButton;
        private System.Windows.Forms.TreeView TrajetTV;
    }
}

