using System;
using System.Collections.Generic;
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
        private string _description;
        #endregion
        #region CONSTRUCTEURS
        public POI(double lat,double longi,string description,Color color)
        {
            NextId();
            Lat = lat;
            Long = longi;
            if (description != "Description")
                Description = description;
            else
                Description = "POI";
            if (color != null)
                Colour = color;
            else
                Colour = Color.Red;
            
        }
        public POI(int lat,int longi,string description,Color color)
        {
            NextId();
            Lat = lat;
            Long = longi;
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
        public double Lat
        {
            get { return _lat; }
            set { _lat = value; }
        }
        public double Long
        {
            get { return _long; }
            set { _long = value; }
        }
        public int Compteur
        {
            get { return _compteur; }
            set { _compteur = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
        public bool IsPointClose(double longi,double lat, double precision) //Méthode dans une autre librairie de classe math
        {
            bool checkOK;
            double X, Y;
            X = Math.Abs(Lat - lat);
            Y = Math.Abs(Long - longi);
            if ((Math.Sqrt((Math.Pow(X, 2) + (Math.Pow(Y, 2))))) <= precision)
                checkOK = true;
            else
                checkOK = false;
            return checkOK;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Colour);
            g.DrawLine(pen, (float)Long-5, (float)Lat-5, (float)Long +5,(float)Lat+5);
            g.DrawLine(pen, (float)Long+5, (float)Lat-5, (float)Long -5,(float)Lat+5);
        }
        #endregion
    }
}
