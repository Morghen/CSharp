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

namespace TripManager
{
    public partial class TripManager : Form
    {
        public Trip _unVoyage = new Trip();
        public string _currentDir;
        public string _TripDir;
        public BindingList<Sites> _sitesList;
        


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
                _TripDir = _currentDir + @"\Trips";
                if (!Directory.Exists(_TripDir))
                {
                    Directory.CreateDirectory(_TripDir);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'initialisation : " + ex.Message);
                Environment.Exit(0);
            }
            _sitesList = new BindingList<Sites>();
            SitesLB.DataSource = _sitesList;
            TrajetTV.Nodes.Clear();
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
            catch(Exception ex)
            {
                MessageBox.Show("Avertissement : aucun voyage chargé, voyage par défaut choisi");
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
            XMLToData load = new XMLToData(_TripDir);
            _unVoyage = load.newTrip();
        }
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            DataToXML save = new DataToXML(_unVoyage,_TripDir); 
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
