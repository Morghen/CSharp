using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathLib;
using System.Drawing;
using System.ComponentModel;

namespace MyCartographyObjects
{
    public class Polyline : CartoObj,IIsPointClose,IPointy,IComparable<Polyline>,IEquatable<Polyline>
    {
        #region VARIABLES MEMBRES
        private static int _compteur = 0;
        private List<POI> _listPOI;
        #endregion
        #region CONSTRUCTEURS
        public Polyline()
        {
            NextId();
            _listPOI = new List<POI>();
            Largeur = 1;
            Description = "Polyline";
            Colour = Color.Red;
        }
        public Polyline(POI refPOI,string description,Color color,int largeur)
        {
            NextId();
            _listPOI = new List<POI>();
            Largeur = largeur;
            AddPOI(refPOI);
            if (description != "Description")
                Description = description;
            else
                Description = "Polyline";
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
        [BrowsableAttribute(false)]
        public List<POI> ListPOI
        {
            get { return _listPOI; }
        }
        [ReadOnlyAttribute(true)]
        public int NbPoints
        {
            get
            {
                int _count = 0;
                foreach (POI unPOI in ListPOI)
                {
                    _count++;
                }
                return _count;
            }
        }
        [BrowsableAttribute(false)]
        public int FirstIDPOI
        {
            get
            {
                return ListPOI.First().Id;
            }
        }
        [BrowsableAttribute(false)]
        public int LastIDPOI
        {
            get
            {
                return ListPOI.Last().Id;
            }
        }
        #endregion
        #region METHODES
        private void NextId()
        {
            Compteur++;
            Id = Compteur;
            return;
        }
        public void AddPOI(POI unPOI)
        {
            ListPOI.Add(unPOI);
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
        public bool IsPointClose(double longi, double lat, double precision)
        {
            bool checkOk = false;
            double SegmentAB, SegmentBC, SegmentAC;
            for(int i = 0;i<(ListPOI.Count -1);i++)
            {
                SegmentAB = MathLib.LongueurSegment(this.ListPOI[i].Long, longi, this.ListPOI[i + 1].Lat, lat);
                SegmentBC = MathLib.LongueurSegment(longi, this.ListPOI[i + 1].Long, lat, this.ListPOI[i + 1].Lat);
                SegmentAC = MathLib.LongueurSegment(this.ListPOI[i].Long, this.ListPOI[i + 1].Long, this.ListPOI[i].Lat, this.ListPOI[i + 1].Lat);
                if ((SegmentAB + SegmentBC).CompareTo(SegmentAC) <= 0)
                    return checkOk = true;
            }
            return checkOk;
        }
        public int CompareTo(Polyline unePoly)
        {
            double tmpthis = 0.0, tmpobj = 0.0;
            double precision = 0.5;
            for (int i = 0; i < (this.NbPoints -1); i++)
            {
                tmpthis = tmpthis + MathLib.LongueurSegment(this.ListPOI[i].Long,this.ListPOI[i+1].Long,this.ListPOI[i].Lat,this.ListPOI[i+1].Lat);
            }
            for (int i = 0; i < (unePoly.NbPoints -1); i++)
            {
                tmpobj = tmpobj + MathLib.LongueurSegment(unePoly.ListPOI[i].Long, unePoly.ListPOI[i + 1].Long, unePoly.ListPOI[i].Lat, unePoly.ListPOI[i+1].Lat);
            }
            return Math.Abs(tmpthis - tmpobj).CompareTo(precision);
        }
        public bool Equals(Polyline unePoly)
        {
            double tmpthis = 0.0,tmpobj = 0.0;
            double precision = 0.5;
            for (int i = 0; i < (this.NbPoints - 1); i++)
            {
                tmpthis = tmpthis + MathLib.LongueurSegment(this.ListPOI[i].Long, this.ListPOI[i + 1].Long, this.ListPOI[i].Lat, this.ListPOI[i + 1].Lat);
            }
            for (int i = 0; i < (unePoly.NbPoints - 1); i++)
            {
                tmpobj = tmpobj + MathLib.LongueurSegment(unePoly.ListPOI[i].Long, unePoly.ListPOI[i + 1].Long, unePoly.ListPOI[i].Lat, unePoly.ListPOI[i + 1].Lat);
            }
            if((tmpthis - tmpobj).CompareTo(precision) == 0)
            {
                return true;
            }
            return false;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Colour,Largeur);
            for(int i=0;i<(ListPOI.Count() - 1); i++)
                g.DrawLine(pen, (float)ListPOI[i].Long, (float)ListPOI[i].Lat, (float)ListPOI[i + 1].Long, (float)ListPOI[i + 1].Lat);
        }
        #endregion
    }
}
