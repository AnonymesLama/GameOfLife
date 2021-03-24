using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Spielfeld feld = new Spielfeld();
            int generationen = 12;
            for (int i = generationen; i > 0; i--)
            {
                String test = feld.EvaluateNextGeneration();
                MessageBox.Show(test + " " +i);
            }
        }
    }
}
