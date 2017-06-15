using MyTripManagerClasses;
using System;
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
    public partial class DialogRenameTrajet : Form
    {
        private string _backup;

        public DialogRenameTrajet()
        {
            InitializeComponent();
        }

        public DialogRenameTrajet(string renaming)
        {
            InitializeComponent();
            foreach (Trajets unTrajet in TripManager._unVoyage.TrajetsList)
            {
                if (unTrajet.Description.Equals(renaming))
                {
                    descriptionTB.Text = unTrajet.Description;
                    Backup = unTrajet.Description;
                    break;
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (descriptionTB.Text.Equals(""))
            {
                MessageBox.Show("Champ vide");
            }
            else
            {
                foreach (Trajets unTrajet in TripManager._unVoyage.TrajetsList)
                {
                    if (unTrajet.Description.Equals(Backup))
                    {
                        unTrajet.Description = descriptionTB.Text;
                        DialogResult = DialogResult.OK;
                        break;
                    }
                }
                Dispose();
            }
        }

        public string Backup
        {
            get { return _backup; }
            set { _backup = value; }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}
