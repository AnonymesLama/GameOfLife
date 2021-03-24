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
        }

        public bool NextStatus
        {
            get { return this.nextStatus; }
            set { this.nextStatus = value; }
        }

        //setter für status. nur bei initialisierung nutzen
        public void StarterKolonie() { this.status = true; }

        //setterfunktion für nextstatus
        public void Evolve() { this.nextStatus = this.status; }

        public Zelle(Position p)
        {
            this.status = false;
            this.Koordinate = p;
        }

        public Zelle(int zeile, int spalte)
        {
            this.status = false;
            this.Koordinate.Z = zeile;
            this.Koordinate.S = spalte;
        }


    }


}
