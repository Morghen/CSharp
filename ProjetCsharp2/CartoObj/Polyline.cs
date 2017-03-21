﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMathLib;
using System.Drawing;

namespace MyCartographyObjects
{
    public class Polyline : CartoObj,IPointy,IComparable<Polyline>,IEquatable<Polyline>
    {
        #region VARIABLES MEMBRES
        private static int _compteur = 0;
        private List<POI> _listPOI;
        private string _description;
        #endregion
        #region CONSTRUCTEURS
        public Polyline()
        {
            NextId();
            _listPOI = new List<POI>();
            Description = "Polyline";
            Colour = Color.Red;
        }
        public Polyline(POI refPOI,string description,Color color)
        {
            NextId();
            _listPOI = new List<POI>();
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
        public int Compteur
        {
            get { return _compteur; }
            set { _compteur = value; }
        }
        public List<POI> ListPOI
        {
            get { return _listPOI; }
        }
 
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
        public int FirstIDPOI
        {
            get
            {
                return ListPOI.First().Id;
            }
        }
        public int LastIDPOI
        {
            get
            {
                return ListPOI.Last().Id;
            }
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
        public bool IsPointClose(double longi, double lat, double precision) // Voir POI
        {
            bool checkOK;
            double X, Y;
            foreach(POI unPOI in ListPOI)
            {
                X = Math.Abs(unPOI.Lat - lat);
                Y = Math.Abs(unPOI.Long - longi);
                if ((Math.Sqrt((X*X) + (Y*Y)) <= precision))
                {
                    checkOK = true;
                    return checkOK;
                }
            }
            checkOK = false;
            return checkOK;
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
            if (Math.Abs(tmpthis - tmpobj) < precision)
                return 0;
            else if ((tmpthis - tmpobj) > 0)
                return 1;
            else
                return -1;
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
            if (Math.Abs(tmpthis - tmpobj) < precision)
                return true;
            else
                return false;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Colour);
            for(int i=0;i<(ListPOI.Count() - 1); i++)
                g.DrawLine(pen, (float)ListPOI[i].Long, (float)ListPOI[i].Lat, (float)ListPOI[i + 1].Long, (float)ListPOI[i + 1].Lat);
        }
        #endregion
    }
}