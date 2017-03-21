﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class Polygon : CartoObj,IPointy
    {
        #region VARIABLES MEMBRES
        private static int _compteur = 0;
        private List<Polyline> _listPolyline;
        private string _description;
        #endregion
        #region CONSTRUCTEURS
        public Polygon()
        {
            NextId();
            _listPolyline = new List<Polyline>();
            Description = "Polygon";
        }
        public Polygon(Polyline unPolyline,string description,Color color)
        {
            NextId();
            _listPolyline = new List<Polyline>();
            AddPolyline(unPolyline);
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
        public int Compteur
        {
            get { return _compteur; }
            set { _compteur = value; }
        }
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
        public List<Polyline> ListPolyline
        {
            get { return _listPolyline; }
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
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Colour);
            
        }
        #endregion
    }
}