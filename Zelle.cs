using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Zelle
    {
        private bool status;
        private bool nextStatus;

        public bool Status
        {
            get { return this.status; }
        }

        public bool NextStatus
        {
            get { return this.nextStatus; }
        }

        //setter für status. nur bei initialisierung nutzen
        public void StarterKolonie () { this.status = true; }

        //setterfunktion für nextstatus
        public void Evolve() { this.nextStatus = status; }




    }
}
