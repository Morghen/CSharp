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

namespace Inpres_Map
{
    public partial class OptionWindow : Form
    {
        public ParamEventArgs p;
        public event OptionChangedHandler OptionModified;
        public OptionWindow()
        {
            InitializeComponent();
        }

        public OptionWindow(ParamEventArgs e) :this()
        {
            ButtonColorPicker.BackColor = e.Colour;
            numericPrecision.Value = (decimal)e.Precision;
        }

        private void ButtonColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog TextColorPick = new ColorDialog();
            TextColorPick.AllowFullOpen = false;
            TextColorPick.ShowHelp = true;
            TextColorPick.Color = ButtonColorPicker.BackColor;
            if (TextColorPick.ShowDialog() == DialogResult.OK)
                ButtonColorPicker.BackColor = TextColorPick.Color;
        }

        public class ParamEventArgs
        {
            private double _precision;
            private Color _color;

            public double Precision
            {
                get { return _precision; }
                set { _precision = value; }
            }
            public Color Colour
            {
                get { return _color; }
                set { _color = value; }
            }

            public ParamEventArgs(double precision, Color color)
            {
                Precision = precision;
                Colour = color;
            }
        }
        public delegate void OptionChangedHandler(object sender, ParamEventArgs e);

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            if(OptionModified != null)
            {
                OptionModified(this, new ParamEventArgs((double)numericPrecision.Value, ButtonColorPicker.BackColor));
            }
            this.Close();
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (OptionModified != null)
                OptionModified(this, new ParamEventArgs((double)numericPrecision.Value, ButtonColorPicker.BackColor));
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
