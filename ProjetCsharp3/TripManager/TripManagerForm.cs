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
        public Trip unVoyage = new Trip();
        public string currentDir;
        public string TripDir;
        


        private void WhenNewTripIsCreated(object sender, ParamEventArgs e)
        {
            unVoyage.Tag = e.Tag;
            unVoyage.DateDeb = e.DateDeb;
            unVoyage.DateFin = e.DateFin;
            unVoyage.Description = e.Description; 
        }
        public TripManager()
        {
            try
            {
                currentDir = Directory.GetCurrentDirectory();
                TripDir = currentDir + @"\Trips";
                if (!Directory.Exists(TripDir))
                {
                    Directory.CreateDirectory(TripDir);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur d'initialisation : " + ex.Message);
                Environment.Exit(0);
            }
            InitializeComponent();
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
            AddForm AddWindow = new AddForm(new ParamEventArgs(unVoyage.Tag,unVoyage.DateDeb,unVoyage.DateFin,unVoyage.Description));
            AddWindow.NewTripModified += WhenNewTripIsCreated;
            AddWindow.Show(this);
        }

        private void LoadMenu_Click(object sender, EventArgs e)
        {
            XMLToData load = new XMLToData(TripDir);
            unVoyage = load.newTrip();
        }
        private void SaveMenu_Click(object sender, EventArgs e)
        {
            DataToXML save = new DataToXML(unVoyage,TripDir); 
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
