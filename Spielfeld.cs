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
        private bool change;
        private int cellCount;
        //private int feldGroesse;
        private Zelle[,] kolonie;
        private Zelle [,] nextKolonie;

        //nimmt Zellen an, setze jeweils nextstatus gemäß regeln
        // speichert output in nextkolonie

        public String EvaluateNextGeneration()
        {
            string ausgabe = "";
            change = true;

            //nextkolonie ist copy of kolonie

            while (change)
            {
                for (int i = 2; i< 16; i++)
                {
                    for (int j = 2; j < 9; j++)
                    {
                        Position[] nachbarn = BestimmeNachbarn(kolonie[i, j]);
                        int lebendig = 0;
                        foreach (Position x in nachbarn)
                        {
                            if ((kolonie[i, j].Position == x) && kolonie[i, j].Status)
                            {
                                lebendig++;
                            }
                            //ausgabe += x.Zeile;
                            //ausgabe += ",";
                            //ausgabe += x.Spalte;
                            //ausgabe += '\n';
                        }

                        if (kolonie[i,j].Status) {                          
                            if (lebendig < 2)
                            {
                                kolonie[i, j].NextStatus = false;
                            }
                            if (lebendig <= 3 && lebendig >=2)
                            {
                                kolonie[i, j].NextStatus = true;
                            }
                            if (lebendig > 3)
                            {
                                kolonie[i, j].NextStatus = false;
                            }
                        } else if (!kolonie[i,j].Status)
                        {
                            if (lebendig == 3)
                            {
                                kolonie[i, j].NextStatus = true;
                            }
                        }

                        ausgabe += "i = "+ i+"; j = "+j;
                        //je nach anzahl, change state in nextkolonie
                        //check ob change
                        //if regeln erfüllt:
                        //kolonie[i,j].Evolve();
                        change = false;
                    }
                }
                
            }
            return ausgabe;
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


        public Spielfeld ()
        {
            //für tests bereits bevölkern
            kolonie = new Zelle[16, 9];


            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Position Koordinate = Position(i, j);
                    kolonie[i, j] = new Zelle(i, j);
                }
            }
            kolonie[2, 2].StarterKolonie();
            kolonie[6, 6].StarterKolonie();
        }

        public Spielfeld(int breite, int laenge)
        {
            kolonie = new Zelle[breite,laenge];
        }
    }
}
