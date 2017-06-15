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
        public Polyline PolyEnCours = new Polyline();

        static public Sites unSite = new Sites();
        static public Trajets nouvTrajet = new Trajets();
        static public MouseEventArgs coordActu;

        public ContextMenuStrip cms = new ContextMenuStrip();
        public int CreateTrajet = 0;
        

        private void WhenNewTripIsCreated(object sender, ParamEventArgs e)
        {
            _unVoyage.Tag = e.Tag;
            _unVoyage.DateDeb = e.DateDeb;
            _unVoyage.DateFin = e.DateFin;
            _unVoyage.Description = e.Description; 
        }

        public TripManager()
        {
            InitializeComponent();
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

        private void SitesLabel_Click(object sender, EventArgs e)
        {

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
            try
            {
                foreach (Trajets unTrajet in _unVoyage.TrajetsList)
                {
                    TreeNode currentNode = TrajetTV.Nodes.Add(unTrajet.Description);
                    foreach (Sites unSite in unTrajet.Childs)
                    {
                        currentNode.Nodes.Add(unSite.Description);
                    }
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
            nouvTrajet = new Trajets();
            PolyEnCours = new Polyline();
            EndTrajetButton.Click -= EndTrajetButton_Click;
            CreateTrajet = 0;
            EndTrajetButton.Enabled = false;
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
    }
}
