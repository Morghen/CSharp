using System;
using System.Collections.Generic;
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
        #endregion
        #region CONSTRUCTEURS
        public XMLToData(string TripDir)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Trip));
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.InitialDirectory = TripDir;
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
        #endregion
        #region METHODES
        public Trip newTrip()
        {
            return nouveauVoyage;
        }
        #endregion
    }
}
