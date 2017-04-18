using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class Polygon : CartoObj,IPointy,IIsPointClose
    {
        #region VARIABLES MEMBRES
        private static int _compteur = 0;
        private List<Polyline> _listPolyline;
        #endregion
        #region CONSTRUCTEURS
        public Polygon()
        {
            NextId();
            _listPolyline = new List<Polyline>();
            Description = "Polygon";
            Largeur = 1;
        }
        public Polygon(Polyline unPolyline,string description,Color color,int largeur)
        {
            NextId();
            _listPolyline = new List<Polyline>();
            AddPolyline(unPolyline);
            Largeur = largeur;
            if (description != "Description")
                Description = description;
            else
                Description = "Polygon";
            if (color != null)
                Colour = color;
            else
                Colour = Color.Red;
        }
        #endregion
        #region PROPRIETES
        [BrowsableAttribute(false)]
        public int Compteur
        {
            get { return _compteur; }
            set { _compteur = value; }
        }
        [ReadOnlyAttribute(true)]
        public int NbPoints
        {
            get
            {
                int _count = 0;
                int _valId = 0;
                if (ListPolyline.Count() > 1)
                {
                    _count = ListPolyline[0].NbPoints;
                    _valId = ListPolyline[0].LastIDPOI;
                    for (int i = 1; i < ListPolyline.Count(); i++)
                    {
                        if (_valId == ListPolyline[i].FirstIDPOI)
                            _count += ListPolyline[i].NbPoints - 1;
                        else
                            _count += ListPolyline[i].NbPoints;
                        _valId = ListPolyline[i].LastIDPOI;
                    }
                }
                else
                    _count = ListPolyline[0].NbPoints;
                return _count;
            } 
        }
        [BrowsableAttribute(false)]
        public List<Polyline> ListPolyline
        {
            get { return _listPolyline; }
        }
        #endregion
        #region METHODES
        private void NextId()
        {
            Compteur++;
            Id = Compteur;
            return;
        }
        public void AddPolyline(Polyline unPolyline)
        {
            _listPolyline.Add(unPolyline);
            return;
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
            return;
        }
        public bool IsPointClose(double longi,double lat,double prec)
        {
            foreach(Polyline unePoly in ListPolyline)
            {
                if (unePoly.IsPointClose(longi, lat, prec) == true)
                    return true;
            }
            return false;
        }
        public void Draw(Graphics g)
        {
            PointF[] tabPoints = new PointF[NbPoints];
            int i = 0;
            foreach (Polyline unePolyline in ListPolyline)
            {
                foreach (POI unPOI in unePolyline.ListPOI)
                {
                    tabPoints[i] = new PointF((float)unPOI.Long, (float)unPOI.Lat);
                    i++;
                }
            }
            g.FillPolygon(Brushes.DarkOrange, tabPoints, System.Drawing.Drawing2D.FillMode.Alternate);
        }
        #endregion
    }
}
