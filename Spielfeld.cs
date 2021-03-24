using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Spielfeld
    {
        public static int generationenAnzahl;
        //private bool change;
        //private int cellCount;
        private int breite;
        private int laenge; 
        //private int feldGroesse;
        private Zelle[,] kolonie;
        //private Zelle [,] nextKolonie;
        public static String angabe;


        public void Simulate(bool change)
        {
            //change = true;

            while (change)
            {
                int changecounter = 0;
                for (int i = 1; i < breite+1; i++)
                {
                    for (int j = 1; j < laenge+1 ; j++)
                    {
                        Position[] nachbarn = BestimmeNachbarn(kolonie[i, j]);
                        int lebendig = 0;
                        foreach (Position x in nachbarn)
                        {
                            if (kolonie[x.S, x.Z].Status)
                            {
                                lebendig++;
                            }
                        }

                        if (kolonie[i,j].Status) {                          
                            if (lebendig < 2)
                            {
                                kolonie[i, j].NextStatus = false;
                                changecounter++;
                                angabe += " änderung einsam ("+changecounter+")|";
                            }
                            if (lebendig <= 3 && lebendig >=2)
                            {
                                kolonie[i, j].NextStatus = true;
                            }
                            if (lebendig > 3)
                            {
                                kolonie[i, j].NextStatus = false;
                                changecounter++;
                                angabe += " änderung suffocate (" + changecounter + ")|";
                            }
                        }
                        if (!kolonie[i,j].Status)
                        {
                            if (lebendig == 3)
                            {
                                kolonie[i, j].NextStatus = true;
                                changecounter++;
                                angabe += " änderung newborn (" + changecounter + ")|";
                            }
                        }
                    }
                }
                if (changecounter == 0)
                {
                    //change = false;  //das hier funktioniert noch nicht...
                    SetChange();
                    return;
                }
                angabe += " ---" +changecounter+" änderungen vorgenommen---";
                generationenAnzahl++;
            }
            SetChange();
            angabe += "raus aus while schleife - keine änderungen mehr";
        }

        public void SetChange()
        {
            for (int i = breite; i >0; i--)
            {
                for (int j = laenge; j >0; j--)
                {
                    kolonie[i, j].Evolve();                    
                }
            }
        }

        public Position [] BestimmeNachbarn (Zelle zelle)
        {
            Position[] nachbarn = new Position[8];
            int zeile = zelle.GetZeile();
            int spalte = zelle.GetSpalte();

            nachbarn[0] = new Position(zeile - 1, spalte - 1);
            nachbarn[1] = new Position(zeile - 1, spalte    );
            nachbarn[2] = new Position(zeile - 1, spalte + 1);
            nachbarn[3] = new Position(zeile    , spalte - 1);
            nachbarn[4] = new Position(zeile    , spalte + 1);
            nachbarn[5] = new Position(zeile + 1, spalte - 1);
            nachbarn[6] = new Position(zeile + 1, spalte    );
            nachbarn[7] = new Position(zeile + 1, spalte + 1);

            return nachbarn;
        }

        //public Spielfeld ()
        //{
        //    //statisch 16 x 9
        //    kolonie = new Zelle[16, 9];
        //    for (int i = 0; i < 16; i++)
        //    {
        //        for (int j = 0; j < 9; j++)
        //        {
        //            kolonie[i, j] = new Zelle(i, j);
        //        }
        //    }
        //    kolonie[2, 3].StarterKolonie();
        //    kolonie[3, 2].StarterKolonie();
        //    kolonie[3, 3].StarterKolonie();
        //} //statisch

        public Spielfeld(int b, int l)
        {
            this.breite = b;
            this.laenge = l;
            kolonie = new Zelle[breite+2,laenge+2];
            for (int i = 0; i < breite+2; i++)
            {
                for (int j = 0; j < laenge+2; j++)
                {
                    kolonie[i, j] = new Zelle(i, j);
                }
            }

            //zufällige vergabe von startfeldern:


            //to delete, nur zu testzwecken
            kolonie[2, 3].StarterKolonie();
            kolonie[3, 2].StarterKolonie();
            kolonie[3, 3].StarterKolonie();
        }
    }
}
