using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public struct Position
    {
        public int Z;
        public int S;

        public Position(int zeile, int spalte)
        {
            this.Z = zeile;
            this.S = spalte;
        }
    }


    public class Zelle
    {
        private Position Koordinate = new Position();
        private bool status;
        private bool nextStatus;

        //public Position Koordinate { get; set; }
        public int GetZeile ()
        {
            return this.Koordinate.Z;
        }
        public int GetSpalte()
        {
            return this.Koordinate.S;
        }
        public bool Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        public bool NextStatus
        {
            get { return this.nextStatus; }
            set { this.nextStatus = value; }
        }

        //angesprochene Zelle wird aktiviert
        public void StarterKolonie() { this.status = true; }

        //Generationenübergang für Zelle.Status
        public void Evolve() { this.Status = this.NextStatus; }

        public Zelle(Position p)
        {
            this.status = false;
            this.Koordinate = p;
        }

        public Zelle(int zeile, int spalte)
        {
            this.status = false;
            this.NextStatus = false;
            this.Koordinate.Z = zeile;
            this.Koordinate.S = spalte;
        }


    }


}
