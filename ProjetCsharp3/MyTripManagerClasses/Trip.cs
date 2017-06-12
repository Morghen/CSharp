using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTripManagerClasses
{
    public class Trip
    {
        #region VARIABLES MEMBRES
        private string _tag;
        private DateTime _dateDeb;
        private DateTime _dateFin;
        private string _description;
        private List<Sites> _sitesList;
        private List<Trajets> _trajetsList;
        #endregion
        #region CONSTRUCTEURS
        public Trip()
        {
            Tag = "Nouveau voyage";
            DateDeb =  DateTime.Today;
            DateFin = DateTime.Today;
            Description = "Nouveau";
        }

    
        public Trip(string tag,DateTime dateDeb,DateTime dateFin,string description)
        {
            Tag = tag;
            DateDeb = dateDeb;
            DateFin = dateFin;
            Description = description;
        }
        #endregion
        #region PROPRIETES
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

        public List<Sites> SitesList
        {
            get { return _sitesList; }
            set { _sitesList = value; }
        }

        public List<Trajets> TrajetsList
        {
            get { return _trajetsList; }
            set { _trajetsList = value; }
        }
        #endregion
        #region METHODES

        #endregion
    }
}
