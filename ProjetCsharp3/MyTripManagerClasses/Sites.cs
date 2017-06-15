using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTripManagerClasses
{
    public class Sites
    {
        #region VARIABLES MEMBRES
        private string _description;
        private string _image;
        private POI _unPOI;
        #endregion
        #region CONSTRUCTEUR
        public Sites()
        {
        }
        #endregion
        #region PROPRIETES
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        }

        public POI UnPOI
        {
            get { return _unPOI; }
            set { _unPOI = value; }
        }
        #endregion
        #region METHODES
        public override string ToString()
        {
            return Description;
        }
        #endregion


    }
}
