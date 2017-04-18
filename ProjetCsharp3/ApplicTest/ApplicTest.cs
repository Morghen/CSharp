using MyCartographyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicTest
{
    class ApplicTest
    {
        static void Main(string[] args)
        {
            //Test création
            Console.WriteLine("Création des objets manuellement");
            POI Test1 = new POI(28, 27);
            POI Test2 = new POI(25.26, 27.38);
            Test1.Draw();
            Test2.Draw();
            Polyline Test3 = new Polyline(new POI(22, 54));
            Polyline Test4 = new Polyline();
            Test3.Draw();
            Test4.Draw();
            Polygon Test5 = new Polygon();
            Polygon Test6 = new Polygon(new Polyline());
            Polygon Test7 = new Polygon(new Polyline(new POI(99, 97)));
            Test5.Draw();
            Test6.Draw();
            Test7.Draw();
            //Création liste
            Console.WriteLine("Création de la liste");
            List<CartoObj> myCartoObjList = new List<CartoObj>();
            myCartoObjList.Add(Test1);
            myCartoObjList.Add(Test2);
            myCartoObjList.Add(Test3);
            myCartoObjList.Add(Test4);
            myCartoObjList.Add(Test5);
            myCartoObjList.Add(Test6);
            myCartoObjList.Add(Test7);
            Console.WriteLine("Liste créée");
            //Affichage via foreach
            Console.WriteLine("Affichage via boucle foreach");
            foreach (CartoObj unObjet in myCartoObjList)
            {
                unObjet.Draw();
            }
            //Parcourir la liste pour trouver les objets implémentant l'interface IPointy
            Console.WriteLine("Affichage des objets implémentant IPointy");
            foreach (CartoObj unObjet in myCartoObjList)
            {
                if (unObjet is IPointy)
                {
                    unObjet.Draw();
                }
            }
            //Parcourir la liste pour afficher les objets n'implémentant pas l'interface IPointy
            Console.WriteLine("Affichage des objets n'implémentant pas IPointy");
            foreach (CartoObj unObjet in myCartoObjList)
            {
                if(unObjet is POI)
                {
                    unObjet.Draw();
                }
            }
            //Création de la liste générique de 5 Polyline
            Console.WriteLine("Création de la liste générique");
            List<Polyline> listeGenPolyline = new List<Polyline>();
            Polyline Poly1 = new Polyline(new POI(25.0,65.2));
            Poly1.AddPOI(new POI(60.0, 48.5));
            Polyline Poly2 = new Polyline(new POI(85.1,45.6));
            Poly2.AddPOI(new POI(1, 1));
            Poly2.AddPOI(new POI(5.5, 6.7));
            Polyline Poly3 = new Polyline();
            Poly3.AddPOI(new POI(8.7, 5.1));
            Polyline Poly4 = new Polyline();
            Poly4.AddPOI(new POI(10, 85));
            Poly4.AddPOI(new POI(74, 65));
            Polyline Poly5 = new Polyline();
            Poly5.AddPOI(new POI(0, 0));
            listeGenPolyline.Add(Poly1);
            listeGenPolyline.Add(Poly2);
            listeGenPolyline.Add(Poly3);
            listeGenPolyline.Add(Poly4);
            listeGenPolyline.Add(Poly5);
            //Affichage de la liste
            Console.WriteLine("Affichage de la liste générique");
            foreach(Polyline unPoly in listeGenPolyline)
            {
                unPoly.Draw();
            }
            //Tri de la liste
            Console.WriteLine("Tri de la liste sur sa longueur de facon croissante");
            listeGenPolyline.Sort();
            //Affichage de la liste triée
            Console.WriteLine("Affichage de la liste triée");
            foreach(Polyline unPoly in listeGenPolyline)
            {
                unPoly.Draw();
            }
            //Tri de la liste par taille de bounding box
            Console.WriteLine("Tri de la liste par rapport a la taille de sa bounding box");
            MyPolylineBoundingBoxComparer cmp = new MyPolylineBoundingBoxComparer();
            listeGenPolyline.Sort(cmp);
            foreach(Polyline unPoly in listeGenPolyline)
            {
                unPoly.Draw();
            }
            //Test de la méthode Equals
            Console.WriteLine("Recherche d'une polyline ayant la meme longueur qu'une autre");
            Polyline TestPoly1 = new Polyline(new POI(50, 21));
            Polyline TestPoly2 = new Polyline(new POI(8.7, 5.1));
            Polyline TestPoly3 = new Polyline();
            TestPoly3.AddPOI(new POI(52.2, 89.2));
            TestPoly3.AddPOI(new POI(0.2, 0.5));
            Console.WriteLine("Test de Poly 1");
            TestPoly1.Draw();
            if (listeGenPolyline.Contains(TestPoly1))
                Console.WriteLine("Trouvé");
            else
                Console.WriteLine("Non trouvé");
            Console.WriteLine("Test de Poly 2");
            TestPoly2.Draw();
            if (listeGenPolyline.Contains(TestPoly2))
                Console.WriteLine("Trouvé");
            else
                Console.WriteLine("Non trouvé");
            Console.WriteLine("Test de Poly 3");
            TestPoly3.Draw();
            if (listeGenPolyline.Contains(TestPoly3))
                Console.WriteLine("Trouvé");
            else
                Console.WriteLine("Non trouvé");
            //Test de la méthode IsPointClose
            Console.WriteLine("Test de la méthode IsPointClose");
            foreach (Polyline unPoly in listeGenPolyline)
            {
                if(unPoly.IsPointClose(0,0,200))
                {
                    Console.WriteLine("Polyline proche du point : ");
                    unPoly.Draw();
                }
            }
            Console.WriteLine("Fin de l'applic test");
            Console.ReadKey();
        }
    }
}
