using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTripManagerClasses;
using System.IO;
using System.Xml;
using MyCartographyObjects;
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace TripManager
{
    public partial class TripManager : Form
    {
        public Trip _unVoyage = new Trip();
        public string _currentDir;
        public string _TripDir;
        public string _SitesDir;
        public BindingList<Sites> _sitesList = new BindingList<Sites>();
        public GMapOverlay markersOverlay = new GMapOverlay("Marqueurs");

        static public Sites nouvSite = new Sites();
        static public Trajets nouvTrajet = new Trajets();
        static public MouseEventArgs coordActu;

        public ContextMenuStrip cms = new ContextMenuStrip();
        

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
                _TripDir = _currentDir + @"\Trips";     // REGISTRY
                _SitesDir = _currentDir + @"\Sites";    // REGISTRY
                if (!Directory.Exists(_TripDir))
                {
                    Directory.CreateDirectory(_TripDir);
                }
                if(!Directory.Exists(_SitesDir))
                {
                    Directory.CreateDirectory(_SitesDir);
                }
                if(!File.Exists(_SitesDir + @"\ListesSites.xml"))
                {
                    File.Create(_SitesDir + @"\ListesSites.xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'initialisation : " + ex.Message);
                Environment.Exit(0);
            }
            LoadSites();
            SitesLB.DataSource = _sitesList;
            TrajetTV.Nodes.Clear();
            cms.Items.Clear();
            cms.Items.Add("Nouveau site");
            cms.Items.Add("Nouveau trajet");
            cms.ItemClicked += Cms_ItemClicked;

        }

        private void LoadSites()
        {
            XMLToData loadSites = new XMLToData(_SitesDir);
            _sitesList = loadSites.newSitesList();
            MessageBox.Show("Sites chargés");

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
            XMLToData load = new XMLToData(_TripDir,1);
            _unVoyage = load.newTrip();       
            try
            {
                foreach (Trajets unTrajet in _unVoyage.TrajetsList)
                {
                    TreeNode currentNode = TrajetTV.Nodes.Add(unTrajet.ToString());
                    foreach (Sites unSite in unTrajet.Childs)
                    {
                        currentNode.Nodes.Add(unSite.ToString());
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
            DataToXML save = new DataToXML(_unVoyage,_TripDir); 
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GMapArea_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                coordActu = e;
                cms.Show(GMapArea,new Point(e.X,e.Y));
            }
        }

        private void Cms_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Text == "Nouveau site")
            {
                DialogSites dialogSite = new DialogSites();
                if(dialogSite.ShowDialog() == DialogResult.OK)
                {
                    nouvSite.Image = null;
                    nouvSite.UnPOI = new POI(GMapArea.FromLocalToLatLng(coordActu.X,coordActu.Y).Lat,GMapArea.FromLocalToLatLng(coordActu.X,coordActu.Y).Lng);
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(nouvSite.UnPOI.Lat,nouvSite.UnPOI.Long),GMarkerGoogleType.red);
                    markersOverlay.Markers.Add(marker);
                    GMapArea.Overlays.Clear();
                    GMapArea.Overlays.Add(markersOverlay);
                    _sitesList.Add(nouvSite);
                    nouvSite = new Sites();
                }
            }
            else if (e.ClickedItem.Text == "Nouveau trajet")
            {
                MessageBox.Show("Clic sur trajet");
            }
        }

        private void TripManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataToXML finalSave = new DataToXML(_sitesList, _SitesDir);
            MessageBox.Show("Sites sauvegardés");
        }
    }
}
