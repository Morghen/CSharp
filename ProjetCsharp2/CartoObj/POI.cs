using MyMathLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCartographyObjects
{
    public class POI : CartoObj,IIsPointClose,IDrawable
    {
        #region VARIABLES MEMBRES
        private static int _compteur = 0;
        private double _lat;
        private double _long;
        #endregion
        #region CONSTRUCTEURS
        public POI(double lat,double longi,string description,Color color,int largeur)
        {
            NextId();
            Lat = lat;
            Long = longi;
            Largeur = largeur;
            if (description != "Description")
                Description = description;
            else
                Description = "POI";
            if (color != null)
                Colour = color;
            else
                Colour = Color.Red;
            
        }
        public POI(int lat,int longi,string description,Color color,int largeur)
        {
            NextId();
            Lat = lat;
            Long = longi;
            Largeur = largeur;
            if (description != "Description")
                Description = description;
            else
                Description = "POI";
            if (color != null)
                Colour = color;
            else
                Colour = Color.Red;
        }
        #endregion
        #region PROPRIETES
        [CategoryAttribute("Coord"),ReadOnlyAttribute(true)]
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        [CategoryAttribute("Coord"),ReadOnlyAttribute(true)]
        public double Long
        {
            get { return _long; }
            set { _long = value; }
        }
        [BrowsableAttribute(false)]
        public int Compteur
        {
            get { return _compteur; }
            set { _compteur = value; }
        }
        #endregion
        #region METHODES
        private void NextId()
        {
            Compteur++;
            Id = Compteur;
        }
        public override string ToString()
        {
            string ret;
            return ret = Description + " " + Id;
        }
        public override void Draw()
        {
            Console.WriteLine(this.ToString());
            Console.ReadKey();
        }
        public bool IsPointClose(double longi,double lat, double precision)
        {
            bool checkOK = false;
            double res = 0;
            res = MathLib.LongueurSegment(this.Long, longi, this.Lat, lat);
            if (res <= precision)
                checkOK = true;
            return checkOK;       
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Colour,Largeur);
            g.DrawLine(pen, (float)Long-5, (float)Lat-5, (float)Long +5,(float)Lat+5);
            g.DrawLine(pen, (float)Long+5, (float)Lat-5, (float)Long -5,(float)Lat+5);
        }
        #endregion
    }
}
