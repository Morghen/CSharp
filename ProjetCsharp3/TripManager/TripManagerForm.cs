using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MyTripManagerClasses;
using System.IO;
using MyCartographyObjects;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;

namespace TripManager
{
    public partial class TripManager : Form
    {
        static public Trip _unVoyage = new Trip();
        public TripManagerParam param;
        public string _currentDir;
        static public string tripDir;
        static public string sitesDir;
        static public string imageDir;
        static public int precision;
        static public Color couleur;
        public BindingList<Sites> _sitesList = new BindingList<Sites>();
        public GMapOverlay markersOverlay = new GMapOverlay("Marqueurs");
        public GMapOverlay routeOverlay = new GMapOverlay("Routes");
        public Polyline PolyEnCours = new Polyline();

        static public Sites unSite = new Sites();
        static public Trajets nouvTrajet = new Trajets();
        static public MouseEventArgs coordActu;
        public string flaggedForRename;

        public ContextMenuStrip cms = new ContextMenuStrip();
        public ContextMenuStrip tvstrip = new ContextMenuStrip();
        public int CreateTrajet = 0;
        

        private void WhenNewTripIsCreated(object sender, ParamEventArgs e)
        {
            _unVoyage.Tag = e.Tag;
            _unVoyage.DateDeb = e.DateDeb;
            _unVoyage.DateFin = e.DateFin;
            _unVoyage.Description = e.Description;
            TrajetTV.Nodes.Clear();
            routeOverlay.Clear();
        }

        public TripManager()
        {
            InitializeComponent();
            SitesLB.MouseDown += new MouseEventHandler(SitesLB_MouseDown);
            SitesLB.DragOver += new DragEventHandler(SitesLB_DragOver);
            TrajetTV.DragEnter += new DragEventHandler(TrajetTV_DragEnter);
            TrajetTV.ItemDrag += TrajetTV_ItemDrag;
            TrajetTV.DragDrop += new DragEventHandler(TrajetTV_DragDrop);


            try
            {
                _currentDir = Directory.GetCurrentDirectory();
                param = new TripManagerParam();
                precision = param.Precision;
                couleur = param.Couleur;
                tripDir = param.TripPath;
                sitesDir = param.SitePath;
                imageDir = param.ImagePath;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'initialisation : " + ex.Message);
                Environment.Exit(0);
            }
            LoadSites(markersOverlay);
            SitesLB.DataSource = _sitesList;
            TrajetTV.Nodes.Clear();
            cms.Items.Clear();
            cms.Items.Add("Nouveau site");
            cms.Items.Add("Nouveau trajet");
            cms.ItemClicked += Cms_ItemClicked;
            tvstrip.Items.Clear();
            tvstrip.Items.Add("Renommer");
            tvstrip.Items.Add("Supprimmer");
            tvstrip.ItemClicked += Tvstrip_ItemClicked;

        }

        private void Tvstrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text.Equals("Renommer"))
            {
                DialogRenameTrajet renameTrajet = new DialogRenameTrajet(flaggedForRename);
                if(renameTrajet.ShowDialog() == DialogResult.OK)
                {
                    TrajetTV.Nodes.Clear();
                    PopulateTV(TrajetTV, _unVoyage);
                    MessageBox.Show("Trajet renommé");
                }
            }
            else if(e.ClickedItem.Text.Equals("Supprimmer"))
            {
                for(int i =0;i<_unVoyage.TrajetsList.Count;i++)
                {
                    if(_unVoyage.TrajetsList[i].Description.Equals(flaggedForRename))
                    {
                        for(int j = 0;j<TrajetTV.GetNodeCount(false);j++)
                        {
                            if (TrajetTV.Nodes[i].Text.Equals(flaggedForRename))
                            {
                                TrajetTV.Nodes[i].Nodes.Clear();
                                TrajetTV.Nodes.RemoveAt(i);
                            }
                        }
                        _unVoyage.TrajetsList.RemoveAt(i);
                        break;
                    }
                }
                TrajetTV.Nodes.Clear();
                PopulateTV(TrajetTV, _unVoyage);
                routeOverlay.Clear();
                foreach (Trajets unTrajet in _unVoyage.TrajetsList)
                {
                    CreateRoute(unTrajet.UnePolyline);
                }

            }
        }

        private void PopulateTV(TreeView trajetTV, Trip _unVoyage)
        {
            foreach (Trajets unTrajet in _unVoyage.TrajetsList)
            {
                TreeNode currentNode = trajetTV.Nodes.Add(unTrajet.Description);
                foreach (Sites unSite in unTrajet.Childs)
                {
                    currentNode.Nodes.Add(unSite.Description);
                }
            }
        }

        private void TrajetTV_ItemDrag(object sender, ItemDragEventArgs e)
        {
            TrajetTV.DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void TrajetTV_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode nodeToDropIn = TrajetTV.GetNodeAt(TrajetTV.PointToClient(new Point(e.X, e.Y)));
            if(nodeToDropIn == null) { return; }
            if (nodeToDropIn.Level > 0)
            {
                nodeToDropIn = nodeToDropIn.Parent;
            }
            object data = (Sites)e.Data.GetData(typeof(Sites));
            nodeToDropIn.Nodes.Add(data.ToString());
            for (int i = 0; i < _unVoyage.TrajetsList.Count; i++)
            {
                if (nodeToDropIn.Text.Equals(_unVoyage.TrajetsList[i].Description))
                {
                    _unVoyage.TrajetsList[i].Childs.Add((Sites)data);
                    break;
                }
            } 
            TrajetTV.ExpandAll();
        }
        private void TrajetTV_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void SitesLB_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void SitesLB_MouseDown(object sender, MouseEventArgs e)
        {
            SitesLB.DoDragDrop(SitesLB.SelectedItem, DragDropEffects.Move);
        }

        private void LoadSites(GMapOverlay markerOverlay)
        {
            XMLToData loadSites = new XMLToData(sitesDir);
            _sitesList = loadSites.newSitesList();
            if(_sitesList != null)
            {
                foreach (Sites unSite in _sitesList)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(unSite.UnPOI.Lat, unSite.UnPOI.Long), new Bitmap(unSite.Image));
                    MarkerTooltipMode mode = MarkerTooltipMode.OnMouseOver;
                    marker.ToolTip = new GMapToolTip(marker);
                    marker.ToolTipMode = mode;
                    Brush TooltipBackColor = new SolidBrush(Color.White);
                    marker.ToolTip.Fill = TooltipBackColor;
                    marker.ToolTip.Foreground = new SolidBrush(couleur);
                    marker.ToolTipText = unSite.Description;
                    markersOverlay.Markers.Add(marker);
                    GMapArea.Overlays.Clear();
                    GMapArea.Overlays.Add(markersOverlay);
                    GMapArea.Overlays.Add(routeOverlay);
                }
                MessageBox.Show("Sites chargés");
            } 
            else
            {
                _sitesList = new BindingList<Sites>();
                MessageBox.Show("Initialisation terminée");
            }
        }

        private void GMapArea_Load(object sender, EventArgs e)
        {
            GMapArea.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            GMapArea.SetPositionByKeywords("Bruxelles, Belgique");
            GMapArea.ShowCenter = false;
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            string Msg = "Application developpée par Rémy MAUHIN pour le cours de C#.\nHEPL 2016-2017.";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(Msg, "About Trip Manager", buttons);
        }

        private void AddMenu_Click(object sender, EventArgs e)
        {
            AddForm AddWindow = new AddForm(new ParamEventArgs(_unVoyage.Tag,_unVoyage.DateDeb,_unVoyage.DateFin,_unVoyage.Description));
            AddWindow.NewTripModified += WhenNewTripIsCreated;
            AddWindow.Show(this);
        }

        private void LoadMenu_Click(object sender, EventArgs e)
        {
            XMLToData load = new XMLToData(tripDir,1);
            _unVoyage = load.newTrip();
            TrajetTV.Nodes.Clear(); 
            try
            {
                foreach (Trajets unTrajet in _unVoyage.TrajetsList)
                {
                    TreeNode currentNode = TrajetTV.Nodes.Add(unTrajet.Description);
                    foreach (Sites unSite in unTrajet.Childs)
                    {
                        currentNode.Nodes.Add(unSite.Description);
                    }
                    routeOverlay.Clear();
                    CreateRoute(unTrajet.UnePolyline);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Avertissement : aucuns trajets trouvés");
            }
        }
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            DataToXML save = new DataToXML(_unVoyage,tripDir); 
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GMapArea_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && CreateTrajet != 1)
            {
                coordActu = e;
                cms.Show(GMapArea,new Point(e.X,e.Y));
            }
            if(e.Button == MouseButtons.Left && CreateTrajet == 1)
            {
                coordActu = e;
                PolyEnCours.AddPOI(new POI(GMapArea.FromLocalToLatLng(coordActu.X, coordActu.Y).Lat, GMapArea.FromLocalToLatLng(coordActu.X, coordActu.Y).Lng));
            }           
        }

        private void Cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Nouveau site")
            {
                DialogSites dialogSite = new DialogSites();
                if(dialogSite.ShowDialog() == DialogResult.OK)
                {
                    CreateSiteMarker(unSite);
                }
            }
            else if (e.ClickedItem.Text == "Nouveau trajet")
            {
                DialogTrajets dialogTrajet = new DialogTrajets();
                if(dialogTrajet.ShowDialog() == DialogResult.OK)
                {
                    CreateTrajet = 1;
                    EndTrajetButton.Enabled = true;
                    EndTrajetButton.Click += EndTrajetButton_Click;
                }
            }
        }

        private void EndTrajetButton_Click(object sender, EventArgs e)
        {
            nouvTrajet.UnePolyline = PolyEnCours;
            _unVoyage.TrajetsList.Add(nouvTrajet);
            TrajetTV.Nodes.Add(nouvTrajet.Description);
            TrajetTV.ExpandAll();
            CreateRoute(PolyEnCours);
            nouvTrajet = new Trajets();
            PolyEnCours = new Polyline();
            EndTrajetButton.Click -= EndTrajetButton_Click;
            CreateTrajet = 0;
            EndTrajetButton.Enabled = false;
        }

        private void CreateRoute(Polyline polyEnCours)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            foreach(POI unPOI in polyEnCours.ListPOI)
            {
                points.Add(new PointLatLng(unPOI.Lat, unPOI.Long));
            }
            GMapRoute route = new GMapRoute(points, "route");
            route.Stroke = new Pen(couleur, 3);
            routeOverlay.Routes.Add(route);
        }

        private void TripManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataToXML finalSave = new DataToXML(_sitesList, sitesDir);
            param.SaveParam(precision, couleur);
            MessageBox.Show("Sites sauvegardés");
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogSettings settings = new DialogSettings();
            if(settings.ShowDialog() == DialogResult.OK)
            {
                if (markersOverlay.Markers.Count != 0)
                {
                    for (int i = 0; i < markersOverlay.Markers.Count; i++)
                    {
                        markersOverlay.Markers[i].ToolTip.Foreground = new SolidBrush(couleur);
                    }
                }
                param.SaveParam(precision, couleur);
                MessageBox.Show("Changement sauvegardés");
            }
        }

        private void CreateSiteMarker(Sites site)
        {
            site.UnPOI = new POI(GMapArea.FromLocalToLatLng(coordActu.X, coordActu.Y).Lat, GMapArea.FromLocalToLatLng(coordActu.X, coordActu.Y).Lng);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(site.UnPOI.Lat, site.UnPOI.Long), new Bitmap(site.Image));
            MarkerTooltipMode mode = MarkerTooltipMode.OnMouseOver;
            marker.ToolTip = new GMapToolTip(marker);
            marker.ToolTipMode = mode;
            Brush TooltipBackColor = new SolidBrush(Color.White);
            marker.ToolTip.Fill = TooltipBackColor;
            marker.ToolTip.Foreground = new SolidBrush(couleur);
            marker.ToolTipText = site.Description;
            markersOverlay.Markers.Add(marker);
            GMapArea.Overlays.Clear();
            GMapArea.Overlays.Add(markersOverlay);
            _sitesList.Add(site);
            GMapArea.Invalidate();
            site = new Sites();
        }

        private void TrajetTV_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Button == MouseButtons.Right && e.Node.Level == 0)
            {
                flaggedForRename = e.Node.Text;
                tvstrip.Show(TrajetTV, new Point(e.X, e.Y));
            }
        }
    }
}
