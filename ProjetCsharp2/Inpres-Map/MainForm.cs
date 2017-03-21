using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyCartographyObjects;
using System.IO;

namespace Inpres_Map
{
    public partial class InpresMapForm : Form
    {
        BindingList<POI> BLPOI = new BindingList<POI>();
        BindingList<Polyline> BLPLINE = new BindingList<Polyline>();
        BindingList<Polygon> BLPGON = new BindingList<Polygon>();
        Polyline currentPolyline = new Polyline();
        Polygon currentPolygon = new Polygon();
        public InpresMapForm()
        {
            InitializeComponent();
            PoiLB.DataSource = BLPOI;
            PolylineLB.DataSource = BLPLINE;
            PolygonLB.DataSource = BLPGON;
            PGrid.CommandsVisibleIfAvailable = true;
            PGrid.TabIndex = 1;
            PGrid.Text = "Propriétés";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Application développée par Rémy Mauhin pour le cours de C#.\nHEPL 2016-2017";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, "About Inpres-Map", buttons);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog MyColorPicker = new ColorDialog();
            MyColorPicker.AllowFullOpen = false;
            MyColorPicker.ShowHelp = true;
            MyColorPicker.Color = ColorButton.BackColor;
            if (MyColorPicker.ShowDialog() == DialogResult.OK)
                ColorButton.BackColor = MyColorPicker.Color;
        }

        private void InpresMapPB_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InpresMapPB_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Draw(g);
        }

        private void CreateMI_Click(object sender, EventArgs e)
        {
            if(SelectMI.Checked == true || MoveMI.Checked == true)
            {
                SelectMI.Checked = false;
                MoveMI.Checked = false;
            }
        }

        private void SelectMI_Click(object sender, EventArgs e)
        {
            if (CreateMI.Checked == true || MoveMI.Checked == true)
            {
                CreateMI.Checked = false;
                MoveMI.Checked = false;
            }
        }

        private void MoveMI_Click(object sender, EventArgs e)
        {
            if (SelectMI.Checked == true || CreateMI.Checked == true)
            {
                SelectMI.Checked = false;
                CreateMI.Checked = false;
            }
        }

        private void Draw(Graphics g)
        {
            foreach(POI unPOI in BLPOI)
            {
                unPOI.Draw(g);
            }
            foreach(Polyline unePolyline in BLPLINE)
            {
                unePolyline.Draw(g);
            }
            foreach(Polygon unPolygon in BLPGON)
            {
               // unPolygon.Draw(g);
            }
        }

        private void InpresMapPB_MouseClick(object sender, MouseEventArgs e)
        {
            if(CreateMI.Checked == true && PoiTB.Checked == true)
            {
                POI unPOI = new POI(e.Y, e.X,DescriptionTB.Text,ColorButton.BackColor);
                BLPOI.Add(unPOI);
                InpresMapPB.Invalidate();
            }
            else if(CreateMI.Checked == true && PolylineTB.Checked == true)
            {
                POI polyPOI = new POI(e.Y, e.X, "POI " + DescriptionTB.Text, ColorButton.BackColor);
                currentPolyline.AddPOI(polyPOI);
                BLPOI.Add(polyPOI);
                if (e.Button == MouseButtons.Right)
                    BLPLINE.Add(currentPolyline);
                InpresMapPB.Invalidate();

            }
            else if(CreateMI.Checked == true && PolygonTB.Checked == true)
            {
                POI gonPOI = new POI(e.X, e.Y, "POI " + DescriptionTB.Text, ColorButton.BackColor);
                currentPolyline.AddPOI(gonPOI);
                currentPolygon.AddPolyline(currentPolyline);
                BLPOI.Add(gonPOI);
                if (e.Button == MouseButtons.Right)
                {
                    BLPLINE.Add(currentPolyline);
                    BLPGON.Add(currentPolygon);
                }
                InpresMapPB.Invalidate();



            }
        }

        private void PoiLB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PoiTB_Click(object sender, EventArgs e)
        {
            PolylineTB.Checked = false;
            PolygonTB.Checked = false;
        }

        private void PolylineTB_Click(object sender, EventArgs e)
        {
            PoiTB.Checked = false;
            PolygonTB.Checked = false;

        }

        private void PolygonTB_Click(object sender, EventArgs e)
        {
            PoiTB.Checked = false;
            PolylineTB.Checked = false;
        }

        private void OpenTS_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Fichiers BMP (*.bmp)|*.bmp|Fichiers JPEG (*.jpg)|*.jpg|Fichiers PNG (*.png)|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    InpresMapPB.Image = new Bitmap(fd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : impossible de lire le fichier. " + ex.Message);
                }
            }
        }
    }
}