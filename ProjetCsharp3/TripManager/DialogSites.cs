using MyTripManagerClasses;
using System;
using System.Windows.Forms;

namespace TripManager
{
    public partial class DialogSites : Form
    {
        public DialogSites()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(descriptionTB.Text.Equals(""))
            {
                MessageBox.Show("Erreur : champ vide");
                return;
            }
            else
            {
                TripManager.nouvSite.Description = descriptionTB.Text;
                DialogResult = DialogResult.OK;
                Dispose();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
