using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyTripManagerClasses
{
    public class XMLToData
    {
        #region VARIABLES
        public Trip nouveauVoyage = null;
        public BindingList<Sites> nouvelleListesSites = null;
        #endregion
        #region CONSTRUCTEURS
        public XMLToData(string dir, int type)
        {

            XmlSerializer xmlFormat = new XmlSerializer(typeof(Trip));
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.InitialDirectory = dir;
            loadFile.Filter = "XML file (*.xml)|*.xml";
            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string load = loadFile.FileName;
                    using (Stream fStream = File.OpenRead(load))
                    {
                        nouveauVoyage = (Trip)xmlFormat.Deserialize(fStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file on disk. Original error: " + ex.Message);
                }
            }
        }
        public XMLToData(string dir)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(BindingList<Sites>));
            try
            {
                string load = dir + @"\ListesSites.xml";
                using (Stream fStream = File.OpenRead(load))
                {
                    nouvelleListesSites = (BindingList<Sites>)xmlFormat.Deserialize(fStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not write file on disk. Original error: " + ex.Message);
            }
        }
        #endregion
        #region METHODES
        public Trip newTrip()
        {
            return nouveauVoyage;
        }
        public BindingList<Sites> newSitesList()
        {
            return nouvelleListesSites;
        }
        #endregion
    }
}
