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
        #endregion
        #region CONSTRUCTEURS
        public Trip()
        {
            Tag = "";
            DateDeb =  DateTime.Today;
            DateFin = DateTime.Today;
            Description = "";
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
        #endregion
        #region METHODES

        #endregion
    }
}
