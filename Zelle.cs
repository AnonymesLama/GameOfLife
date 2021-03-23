using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Zelle
    {
        private Position position;
        private bool status;
        private bool nextStatus;

        public Position Position { get; set; }
        public bool Status
        {
            get { return this.status; }
        }

        public bool NextStatus
        {
            get { return this.nextStatus; }
        }

        //setter für status. nur bei initialisierung nutzen
        public void StarterKolonie() { this.status = true; }

        //setterfunktion für nextstatus
        public void Evolve() { this.nextStatus = this.status; }

        public Zelle(Position p)
        {
            this.status = false;
            this.Position = p;
        }


    }

    class Position
    {
        private int zeile;
        private int spalte;
        public int Zeile { get; set; }
        public int Spalte { get; set; }


        public Position(int z, int s)
        {
            this.Zeile = z;
            this.Spalte = s;
        }
    }
}
