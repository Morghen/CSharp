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
    public partial class DialogTrajets : Form
    {
        public DialogTrajets()
        {
            InitializeComponent();
            datePicker.MinDate = TripManager._unVoyage.DateDeb;
            datePicker.MaxDate = TripManager._unVoyage.DateFin;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(descriptionTB.Text.Equals(""))
            {
                MessageBox.Show("Erreur : description invalide");
                return;
            }
            else
            {
                TripManager.nouvTrajet.Description = descriptionTB.Text;
                TripManager.nouvTrajet.Date = datePicker.Value;
                TripManager.nouvTrajet.Description = TripManager.nouvTrajet.ToString();
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
