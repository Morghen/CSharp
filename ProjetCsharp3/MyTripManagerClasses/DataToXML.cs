using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace MyTripManagerClasses
{
    public class DataToXML
    {
        #region CONSTRUCTEURS
        public DataToXML(Trip unVoyage,string TripDir)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(Trip));
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = TripDir;
            saveFile.Filter = "XML file (*.xml)|*.xml";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string save = saveFile.FileName;
                    using (Stream fStream = new FileStream(save, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        xmlFormat.Serialize(fStream, unVoyage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write file on disk. Original error: " + ex.Message);
                }
            }
        }
        #endregion
    }
}
