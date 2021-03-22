using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Spielfeld
    {
        public int generationenAnzahl;
        private bool change = true;
        private int cellCount;
        //private int feldGroesse;
        private Zelle [] kolonie;
        private Zelle [] nextKolonie;

        //nimmt Zellen an, setze jeweils nextstatus gemäß regeln
        // speichert output in nextkolonie
        // 
        public void EvaluateNextGeneration()
        {
            //nextkolonie ist copy of kolonie

            while (change)
            {
                foreach (Zelle spot in kolonie)
                {
                    //berechne anzahl neighbors
                    //je nach anzahl, change state in nextkolonie
                    //check ob change
                    //if regeln erfüllt:
                    spot.Evolve();
                }
            }
        }


    }
}
