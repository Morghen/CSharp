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
    public partial class AddForm : Form
    {
        public ParamEventArgs p;
        public event NewTripChangedHandler NewTripModified;
        public AddForm()
        {
            InitializeComponent();
        }
        public AddForm(ParamEventArgs e) :this()
        {
            TagTB.Text = e.Tag;
            StartingDatePicker.Value = e.DateDeb;
            EndingTimePicker.Value = e.DateFin;
            DescriptionTB.Text = e.Description;
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if(NewTripModified != null)
            {
                if(TagTB.Text.Equals("") | DescriptionTB.Text.Equals(""))
                {
                    MessageBox.Show("Erreur : certains champs sont incomplets");
                    return;
                }
                if(StartingDatePicker.Value > EndingTimePicker.Value)
                {
                    MessageBox.Show("Erreur : conflit entre la date de début et la date de fin");
                    return;
                }
                NewTripModified(this, new ParamEventArgs(TagTB.Text,StartingDatePicker.Value,EndingTimePicker.Value,DescriptionTB.Text));
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class ParamEventArgs
    {
        private string _tag;
        private DateTime _dateDeb;
        private DateTime _dateFin;
        private string _description;

        public string Tag
        {
            set { _tag = value; }
            get { return _tag; }
        }

        public DateTime DateDeb
        {
            set { _dateDeb = value; }
            get { return _dateDeb; }
        }

        public DateTime DateFin
        {
            set { _dateFin = value; }
            get { return _dateFin; }
        }

        public string Description
        {
            set { _description = value; }
            get { return _description; }
        }

        public ParamEventArgs(string tag, DateTime dateDeb,DateTime dateFin,string description)
        {
            Tag = tag;
            DateDeb = dateDeb;
            DateFin = dateFin;
            Description = description;
        }
    }

    public delegate void NewTripChangedHandler(object sender, ParamEventArgs e);
}
