using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public abstract class CartoObj
    {
        #region VARIABLES MEMBRES
        protected int _id;
        protected Color _color;
        #endregion
        #region CONSTRUCTEUR
        public CartoObj()
        { }
        #endregion
        #region PROPRIETES
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Color Colour
        {
            get { return _color; }
            set { _color = value; }
        }
        #endregion
        #region METHODES
        public abstract void Draw();
        #endregion
    }
}
