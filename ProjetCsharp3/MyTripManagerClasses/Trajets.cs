using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTripManagerClasses
{
    [Serializable]
    public class Trajets
    {
        #region VARIABLES MEMBRES
        private string _description;
        private DateTime _date;
        private Polyline _unePolyline;
        private List<Sites> _childs;
        #endregion
        #region CONSTRUCTEURS
        public Trajets()
        {
        }
        #endregion
        #region PROPRIETES
        public List<Sites> Childs
        {
            get { return _childs; }
            set { _childs = value; }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }

            set
            {
                _date = value;
            }
        }

        public Polyline UnePolyline
        {
            get
            {
                return _unePolyline;
            }

            set
            {
                _unePolyline = value;
            }
        }
        #endregion
        #region METHODES
        override public string ToString()
        {
            return Description + " " + Date.Day + @"\" + Date.Month;
        }
        #endregion
    }
}
