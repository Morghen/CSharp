using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public abstract class CartoObj:INotifyPropertyChanged
    {
        #region VARIABLES MEMBRES
        protected int _id;
        protected Color _color;
        private string _description;
        private int _largeur;
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        #region CONSTRUCTEUR
        public CartoObj()
        { }
        #endregion
        #region PROPRIETES
        [BrowsableAttribute(false)]
        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        [BrowsableAttribute(false)]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [CategoryAttribute("Couleur")]
        public Color Colour
        {
            get { return _color; }
            set { _color = value; }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                if(PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Description"));
                }
            }
        }
        #endregion
        #region METHODES
        public abstract void Draw();
        #endregion
    }
}
