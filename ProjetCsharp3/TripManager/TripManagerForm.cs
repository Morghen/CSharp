﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripManager
{
    public partial class TripManager : Form
    {
        public TripManager()
        {
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
            string Msg = "Fonction pas encore implémentée\n";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(Msg, "New Trip", buttons);
        }

        private void LoadMenu_Click(object sender, EventArgs e)
        {
            string Msg = "Fonction pas encore implémentée\n";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(Msg, "New Trip", buttons);
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {
            string Msg = "Fonction pas encore implémentée\n";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(Msg, "New Trip", buttons);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
