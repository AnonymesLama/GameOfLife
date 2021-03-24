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
            Spielfeld feld = new Spielfeld(5,5); //5,5 to delete, kommt dann von userinput
            int generationen = 12; //to delete, kommt dann von userinput
            for (int i = generationen; i > 0; i--)
            {
                Spielfeld.angabe = "";
                feld.Simulate(true);  //abbruchbedingung: Simulate(false) -> aktuell würden mgl. changes noch übernommen
                MessageBox.Show(Spielfeld.angabe);
            }
            feld.Simulate(false);
        }
    }
}
