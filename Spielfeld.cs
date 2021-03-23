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
        private bool change = true;
        private int cellCount;
        //private int feldGroesse;
        private Zelle[,] kolonie;
        private Zelle [,] nextKolonie;

        //nimmt Zellen an, setze jeweils nextstatus gemäß regeln
        // speichert output in nextkolonie
        // 
        public String EvaluateNextGeneration()
        {
            string ausgabe = "";
            //nextkolonie ist copy of kolonie

            while (change)
            {
                for (int i = 2; i< 16; i++)
                {
                    for (int j = 2; j < 9; j++)
                    {
                        if (kolonie[i,j].Status) { 
                            Zelle currentZelle = kolonie[i, j];
                            Position [] nachbarn = BestimmeNachbarn(kolonie[i, j]);
                            foreach (Position x in nachbarn)
                            {
                                ausgabe += x.Zeile;
                                ausgabe += ",";
                                ausgabe += x.Spalte;
                                ausgabe += '\n';
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

            nachbarn[0] = new Position(zelle.Position.Zeile - 1, zelle.Position.Spalte - 1);
            nachbarn[1] = new Position(zelle.Position.Zeile - 1, zelle.Position.Spalte    );
            nachbarn[2] = new Position(zelle.Position.Zeile - 1, zelle.Position.Spalte + 1);
            nachbarn[3] = new Position(zelle.Position.Zeile    , zelle.Position.Spalte - 1);
            nachbarn[4] = new Position(zelle.Position.Zeile    , zelle.Position.Spalte + 1);
            nachbarn[5] = new Position(zelle.Position.Zeile + 1, zelle.Position.Spalte - 1);
            nachbarn[6] = new Position(zelle.Position.Zeile + 1, zelle.Position.Spalte    );
            nachbarn[7] = new Position(zelle.Position.Zeile + 1, zelle.Position.Spalte + 1);

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
                    //HIER TODO 
                    kolonie[i, j] = new Zelle(new Position(i, j));
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
