using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTripManagerClasses
{
    public class TripManagerParam
    {
        private int _precision;
        private Color _couleur;
        private string _tripPath;
        private string _sitePath;
        private string _imagePath;

        public TripManagerParam()
        {
            LoadParam();
            if (!Directory.Exists(ImagePath))
            {
                Directory.CreateDirectory(ImagePath);
            }
            if (!Directory.Exists(TripPath))
            {
                Directory.CreateDirectory(TripPath);
            }
            if (!Directory.Exists(SitePath))
            {
                Directory.CreateDirectory(SitePath);
            }
            if (!File.Exists(SitePath + @"\ListesSites.xml"))
            {
                File.Create(SitePath + @"\ListesSites.xml");
            }
        }

        public int Precision
        {
            get
            {
                return _precision;
            }

            set
            {
                _precision = value;
            }
        }

        public Color Couleur
        {
            get
            {
                return _couleur;
            }

            set
            {
                _couleur = value;
            }
        }

        public string TripPath
        {
            get
            {
                return _tripPath;
            }

            set
            {
                _tripPath = value;
            }
        }

        public string SitePath
        {
            get
            {
                return _sitePath;
            }

            set
            {
                _sitePath = value;
            }
        }

        public string ImagePath
        {
            get
            {
                return _imagePath;
            }

            set
            {
                _imagePath = value;
            }
        }

        public void SaveParam(int precision,Color couleur)
        {
            RegistryKey soft = Registry.CurrentUser.CreateSubKey("Software");
            RegistryKey applic = soft.CreateSubKey("Trip Manager");
            RegistryKey map = applic.CreateSubKey("Map");
            if(map.GetValue("Precision") == null)
            {
                map.SetValue("Precision", Convert.ToInt32(precision));
            }
            if(map.GetValue("Couleur") == null)
            {
                map.SetValue("Couleur", (Color)couleur);
            }
            RegistryKey trip = applic.CreateSubKey("Trip");
            if(trip.GetValue("PathTrip") == null)
            {
                trip.SetValue("PathTrip", Directory.GetCurrentDirectory() + @"\Trips");
            }
            if (trip.GetValue("PathSite") == null)
            {
                trip.SetValue("PathSite", Directory.GetCurrentDirectory() + @"\Sites");
            }
            if (trip.GetValue("PathImage") == null)
            {
                trip.SetValue("PathImage", Directory.GetCurrentDirectory() + @"\Images");
            }
        }

        public void LoadParam()
        {
            RegistryKey soft = Registry.CurrentUser.CreateSubKey("Software");
            RegistryKey applic = soft.CreateSubKey("Trip Manager");
            RegistryKey map = applic.CreateSubKey("Map");
            if (map.GetValue("Precision") == null)
            {
                Precision = 15;
            }
            else
            {
                Precision = Convert.ToInt32(map.GetValue("Precision"));
            }
            if (map.GetValue("Couleur") == null)
            {
                Couleur = Color.Red;
            }
            else
            {
                Couleur = Color.Red;          
            }
            RegistryKey trip = applic.CreateSubKey("Trip");
            if (trip.GetValue("PathTrip") == null)
            {
                TripPath = Directory.GetCurrentDirectory() + @"\Trips";
            }
            else
            {
                TripPath = Convert.ToString(trip.GetValue("PathTrip"));
            }
            if (trip.GetValue("PathSite") == null)
            {
                SitePath = Directory.GetCurrentDirectory() + @"\Sites";
            }
            else
            {
                SitePath = Convert.ToString(trip.GetValue("PathSite"));
            }
            if (trip.GetValue("PathImage") == null)
            {
                ImagePath = Directory.GetCurrentDirectory() + @"\Images";
            }
            else
            {
                ImagePath = Convert.ToString(trip.GetValue("PathImage"));
            }
        }
    }
}
