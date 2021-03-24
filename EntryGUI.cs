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
    public partial class EntryGUI : Form
    {  
        public EntryGUI()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int generations = Int32.Parse(numGenerations.Value.ToString());
            getGenerations(generations);
            Application.Run(new GameGUI());
        }

        private int getGenerations(int g)
        {
            return g;
        }
    }
}
