using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Windows.Media;

namespace WPF_GameOfLife
{
    public class Feld
    {
        private Rectangle shape;
        private bool status;
        public Rectangle Shape
        {
            get { return this.shape; }
            set
            {
                this.shape = value;
                if (shape.Fill == Brushes.Black)
                {
                    this.Status = true;
                }
                else
                {
                    this.Status = false;
                }
            }
        }

        public bool Status {
            get { return this.status; }
            set
            {
                status = value;
                if (status)
                {
                    this.Shape.Fill = Brushes.Black;
                }
                else
                {
                    this.Shape.Fill = Brushes.White;
                }
            } 
        }

        public Feld(Rectangle shape, bool status)
        {
            this.status = status;
            this.shape = shape;
        }
    }   
}
