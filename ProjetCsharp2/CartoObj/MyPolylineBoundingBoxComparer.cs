using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class MyPolylineBoundingBoxComparer : IComparer<Polyline>
    {
        public int Compare(Polyline Poly1,Polyline Poly2)
        {
            double minX1,maxX1,minY1,maxY1,minX2,maxX2,minY2,maxY2;
            double airePoly1, airePoly2;
            // Fonction a mettre dans math
            minX1 = Poly1.ListPOI[0].Long;
            maxX1 = Poly1.ListPOI[0].Long;
            minY1 = Poly1.ListPOI[0].Lat;
            maxY1 = Poly1.ListPOI[0].Lat;
            foreach(POI unPOI in Poly1.ListPOI)
            {
                if (minX1 > unPOI.Long)
                    minX1 = unPOI.Long;
                if (maxX1 < unPOI.Long)
                    maxX1 = unPOI.Long;
                if (minY1 > unPOI.Lat)
                    minY1 = unPOI.Lat;
                if (maxY1 < unPOI.Lat)
                    maxY1 = unPOI.Lat;
            }
            airePoly1 = (maxX1 - minX1) * (maxY1 - minY1);
            minX2 = Poly2.ListPOI[0].Long;
            maxX2 = Poly2.ListPOI[0].Long;
            minY2 = Poly2.ListPOI[0].Lat;
            maxY2 = Poly2.ListPOI[0].Lat;
            foreach (POI unPOI in Poly2.ListPOI)
            {
                if (minX2 > unPOI.Long)
                    minX2 = unPOI.Long;
                if (maxX2 < unPOI.Long)
                    maxX2 = unPOI.Long;
                if (minY2 > unPOI.Lat)
                    minY2 = unPOI.Lat;
                if (maxY2 < unPOI.Lat)
                    maxY2 = unPOI.Lat;
            }
            airePoly2 = (maxX2 - minX2) * (maxY2 - minY2);
            if (airePoly1 < airePoly2)
                return -1;
            else if (airePoly1 > airePoly2)
                return 1;
            else
                return 0;
        }
    }
}
