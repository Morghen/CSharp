using MyTripManagerClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TripManager
{
    public partial class DialogSites : Form
    {
        public Bitmap imagetmp;

        public DialogSites()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(descriptionTB.Text.Equals("") || imagetmp == null)
            {
                MessageBox.Show("Erreur : il existe des champs vides");
                return;
            }
            else
            {
                TripManager.unSite.Description = descriptionTB.Text;
                TripManager.unSite.Image = TripManager.imageDir + @"\" + descriptionTB.Text + ".bmp";
                imagetmp = null;
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = TripManager.imageDir;
            open.Filter = "BMP Files (*.bmp)|*.bmp|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = open.FileName;
                    imagetmp = new Bitmap(Image.FromFile(path),new Size(64,64));
                    imagetmp.Save(TripManager.imageDir + @"\" + descriptionTB.Text + ".bmp");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not open file on disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
