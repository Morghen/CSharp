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
    public partial class DialogSettings : Form
    {

        public DialogSettings()
        {
            InitializeComponent();
            ColorPickerButton.BackColor = TripManager.couleur;
            numericPrecision.Value = TripManager.precision;
        }
      
        private void OKButton_Click(object sender, EventArgs e)
        {
            TripManager.couleur = ColorPickerButton.BackColor;
            TripManager.precision = (int)numericPrecision.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ColorPickerButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorPick = new ColorDialog();
            colorPick.AllowFullOpen = false;
            colorPick.ShowHelp = true;
            colorPick.Color = ColorPickerButton.BackColor;
            if (colorPick.ShowDialog() == DialogResult.OK)
                ColorPickerButton.BackColor = colorPick.Color;
        }
    }
}
