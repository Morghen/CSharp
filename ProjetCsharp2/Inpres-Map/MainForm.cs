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
using static Inpres_Map.OptionWindow;

namespace Inpres_Map
{
    public partial class InpresMapForm : Form
    {
        BindingList<POI> BLPOI = new BindingList<POI>();
        BindingList<Polyline> BLPLINE = new BindingList<Polyline>();
        BindingList<Polygon> BLPGON = new BindingList<Polygon>();
        Polyline currentPolyline = new Polyline();
        Polygon currentPolygon = new Polygon();
        double currentX = 0, currentY = 0;
        static public double precisionForm = 15;
        static public int largeurForm = 1;
        static public Color TBColor = Color.Black;

        private void WhenOptionWindowIsUpdated(object sender, ParamEventArgs e)
        {
            precisionForm = e.Precision;
            TBColor = e.Colour;
            PoiLB.ForeColor = TBColor;
            PolylineLB.ForeColor = TBColor;
            PolygonLB.ForeColor = TBColor;
        }

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
            foreach(Polygon unPolygon in BLPGON)
            {
                unPolygon.Draw(g);
            }
            foreach (Polyline unePolyline in BLPLINE)
            {
                unePolyline.Draw(g);
            }
            foreach (POI unPOI in BLPOI)
            {
                unPOI.Draw(g);
            }
        }

        private void InpresMapPB_MouseClick(object sender, MouseEventArgs e)
        {
            if(CreateMI.Checked == true && PoiTB.Checked == true)
            {
                POI unPOI = new POI(e.Y, e.X,DescriptionTB.Text,ColorButton.BackColor,largeurForm);
                BLPOI.Add(unPOI);
                InpresMapPB.Invalidate();
            }
            else if(CreateMI.Checked == true && PolylineTB.Checked == true)
            {
                POI polyPOI = new POI(e.Y, e.X,DescriptionTB.Text, ColorButton.BackColor,largeurForm);
                currentPolyline.Colour = ColorButton.BackColor;
                currentPolyline.AddPOI(polyPOI);
                BLPOI.Add(polyPOI);
                if (e.Button == MouseButtons.Right)
                {
                    BLPLINE.Add(currentPolyline);
                    currentPolyline = new Polyline();
                }
                InpresMapPB.Invalidate();

            }
            else if(CreateMI.Checked == true && PolygonTB.Checked == true)
            {
                ButtonValidate.Visible = true;
                POI gonPOI = new POI(e.Y, e.X, DescriptionTB.Text, ColorButton.BackColor,largeurForm);
                currentPolygon.Colour = ColorButton.BackColor;
                currentPolyline.Colour = ColorButton.BackColor;
                currentPolyline.AddPOI(gonPOI);
                BLPOI.Add(gonPOI);
                if (e.Button == MouseButtons.Right)
                {
                    currentPolygon.AddPolyline(currentPolyline);
                    BLPLINE.Add(currentPolyline);
                    currentPolyline = new Polyline();
                }
                InpresMapPB.Invalidate();
            }

            if(SelectMI.Checked == true)
            {
                // POI
                int i = 0;
                bool cartoObjTrouve = false;
                DeleteButton.Enabled = true;
                for(i=0;(i<BLPOI.Count) && cartoObjTrouve == false;i++)
                {
                    if (BLPOI[i].IsPointClose(e.X, e.Y, precisionForm) == true)
                        cartoObjTrouve = true;
                }
                if (cartoObjTrouve == true)
                {
                    if (PGrid.SelectedObject != null)
                        (PGrid.SelectedObject as CartoObj).Largeur = largeurForm;
                    PGrid.SelectedObject = BLPOI[i - 1];
                    (PGrid.SelectedObject as CartoObj).Largeur += 4;
                    InpresMapPB.Invalidate();
                }
                else
                {
                    // Polyline
                    cartoObjTrouve = false;
                    for (i = 0; i < (BLPLINE.Count) && cartoObjTrouve == false; i++)
                    {
                        if (BLPLINE[i].IsPointClose(e.X, e.Y, precisionForm) == true)
                        {
                            cartoObjTrouve = true;
                        }
                    }
                    if (cartoObjTrouve == true)
                    {
                        if (PGrid.SelectedObject != null)
                            (PGrid.SelectedObject as CartoObj).Largeur = largeurForm;
                        PGrid.SelectedObject = BLPLINE[i - 1];
                        (PGrid.SelectedObject as CartoObj).Largeur += 4;
                        currentX = e.X;
                        currentY = e.Y;
                        InpresMapPB.Invalidate();
                    }
                    else
                    {
                        // Polygon
                        cartoObjTrouve = false;
                        for (i = 0; i < (BLPGON.Count) && cartoObjTrouve == false; i++)
                        {
                            if (BLPGON[i].IsPointClose(e.X, e.Y, precisionForm) == true)
                            {
                                cartoObjTrouve = true;
                            }
                        }
                        if (cartoObjTrouve == true)
                        {
                            if (PGrid.SelectedObject != null)
                                (PGrid.SelectedObject as CartoObj).Largeur = largeurForm;
                            PGrid.SelectedObject = BLPGON[i - 1];
                            (PGrid.SelectedObject as CartoObj).Largeur += 4;
                            InpresMapPB.Invalidate();
                        }
                    }
                }
            }

            if(MoveMI.Checked == true)
            {
                if(PGrid.SelectedObject != null)
                {
                    if(PGrid.SelectedObject is POI)
                    {
                        (PGrid.SelectedObject as POI).Long = e.X;
                        (PGrid.SelectedObject as POI).Lat = e.Y;
                        InpresMapPB.Invalidate();
                    }
                    if (PGrid.SelectedObject is Polyline)
                    {
                        // Decalage de chaque points
                        foreach (POI unPOI in (PGrid.SelectedObject as Polyline).ListPOI)
                        {
                            unPOI.Lat = unPOI.Lat - (currentY - e.Y);
                            unPOI.Long = unPOI.Long - (currentX - e.X);
                        }
                        currentX = e.X;
                        currentY = e.Y;
                        InpresMapPB.Invalidate();
                    }
                }
            }
        }

        private void PoiLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PGrid.SelectedObject != null)
                (PGrid.SelectedObject as CartoObj).Largeur = largeurForm;
            if (PoiLB.SelectedItem != null)
            {
                Deselection(1);
                PGrid.SelectedObject = PoiLB.SelectedItem;
                (PGrid.SelectedObject as CartoObj).Largeur += 4;
            }
            InpresMapPB.Invalidate();
        }

        private void Deselection(int ch)
        {
            switch(ch)
            {
                case 0:
                    if (PGrid.SelectedObject is POI)
                    {
                        PolylineLB.SelectedItem = null;
                        PolygonLB.SelectedItem = null;
                    }
                    if (PGrid.SelectedObject is Polyline)
                    {
                        PoiLB.SelectedItem = null;
                        PolygonLB.SelectedItem = null;
                    }
                    if (PGrid.SelectedObject is Polygon)
                    {
                        PolylineLB.SelectedItem = null;
                        PoiLB.SelectedItem = null;
                    }
                    break;
                case 1:
                    PolylineLB.SelectedItem = null;
                    PolygonLB.SelectedItem = null;
                    break;
                case 2:
                    PoiLB.SelectedItem = null;
                    PolygonLB.SelectedItem = null;
                    break;
                case 3:
                    PolylineLB.SelectedItem = null;
                    PoiLB.SelectedItem = null;
                    break;
            }
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
            fd.Filter = "Fichiers BMP (*.bmp)|*.bmp|Fichiers JPEG (*.jpg)|*.jpg|Fichiers PNG (*.png)|*.png|Tous les fichiers (*.*)|*.*";
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

        private void ButtonValidate_Click(object sender, EventArgs e)
        {
            BLPGON.Add(currentPolygon);
            currentPolyline = new Polyline();
            currentPolygon = new Polygon();
            InpresMapPB.Invalidate();
        }

        private void PGrid_Click(object sender, EventArgs e)
        {
            
        }

        private void PolylineLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PGrid.SelectedObject != null)
                (PGrid.SelectedObject as CartoObj).Largeur = largeurForm;
            if (PolylineLB.SelectedItem != null)
            {
                Deselection(2);
                PGrid.SelectedObject = PolylineLB.SelectedItem;
                (PGrid.SelectedObject as CartoObj).Largeur += 4;
            }
            InpresMapPB.Invalidate();
        }

        private void PolygonLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PGrid.SelectedObject != null)
                (PGrid.SelectedObject as CartoObj).Largeur = largeurForm;
            if (PolygonLB.SelectedItem != null)
            {
                Deselection(3);
                PGrid.SelectedObject = PolygonLB.SelectedItem;
                (PGrid.SelectedObject as CartoObj).Largeur += 4;
            }
            InpresMapPB.Invalidate();
        }

        private void ToolbarS_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PGrid.SelectedObject != null)
            {
                if (PGrid.SelectedObject is POI)
                {
                    foreach (Polyline unePolyline in BLPLINE)
                    {
                        foreach (POI unPOI in unePolyline.ListPOI)
                        {
                            if (unPOI.Id == (PGrid.SelectedObject as POI).Id)
                            {
                                unePolyline.ListPOI.Remove(unPOI);
                                break;
                            }
                        }
                    }
                    BLPOI.Remove(PGrid.SelectedObject as POI);
                }
                if (PGrid.SelectedObject is Polyline)
                {
                    foreach(POI unPOI in (PGrid.SelectedObject as Polyline).ListPOI)
                    {
                        BLPOI.Remove(unPOI);
                    }
                    BLPLINE.Remove(PGrid.SelectedObject as Polyline);
                }
                if (PGrid.SelectedObject is Polygon)
                {
                    BLPGON.Remove(PGrid.SelectedObject as Polygon);
                }
                PGrid.SelectedObject = null;
                InpresMapPB.Invalidate();
            }
        }

        private void OptionsMI_Click(object sender, EventArgs e)
        {
            OptionWindow optionForm = new OptionWindow(new ParamEventArgs(precisionForm, TBColor));
            optionForm.OptionModified += WhenOptionWindowIsUpdated;
            optionForm.Show(this);
        }

        private void PGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            InpresMapPB.Invalidate();
        }
    }
}