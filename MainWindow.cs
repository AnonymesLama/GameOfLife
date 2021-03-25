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
    public partial class MainWindow : Form
    {
        private int numX, numY; //the number of buttons to create are stored here
        private bool golInProgress = false; //determines wether a Game of Life is in progress or not;
        private bool[] resetState; //Array to hold the initial alive status before starting the game
        System.Windows.Forms.Timer generationTimer; //Timer for the generation iteration;

        public MainWindow()
        {
            InitializeComponent();
            this.BoardWidth.Value = 5;
            this.BoardHeight.Value = 5;
            this.generationTimer = new System.Windows.Forms.Timer();
            this.generationTimer.Tick += new System.EventHandler(nextGeneration);
            this.generationTimer.Interval = (int)this.generationDelay.Value;
        }

        private int getNumAliveNeighbours(int index)
        {
            int aliveNeighbours = 0;
            int maxIndex = this.Board.Controls.Count - 1;
            for (int i = -1; i < 2; i++)
            {
                /* If direct upper or lower neighbour is out of bound skip this row */
                if (index + (numX * i) < 0) continue;
                if (index + (numX * i) > maxIndex) continue;
                for (int j = -1; j < 2; j++)
                {
                    /* Skip oneself */
                    if (i == 0 && j == 0) continue;
                    if ((index + j + 1) % numX == 0) continue;
                    if (index + (numX * i) + j > maxIndex) continue;
                    if (index + (numX * i) + j < 0) continue;
                    if (this.Board.Controls[index + (numX * i) + j].BackColor == System.Drawing.Color.Black) aliveNeighbours++;
                }
            }
            return aliveNeighbours;
        }

        /* Small wrapper for the info label to make the calls more obvious */
        private void inform(string Text)
        {
            this.InfoLabel.Text = Text;
        }

        public void cellClick(object sender, System.EventArgs e)
        {
            Button cell = (Button)sender;
            if (cell.BackColor != System.Drawing.Color.Black) cell.BackColor = System.Drawing.Color.Black;
            else cell.BackColor = System.Drawing.Color.White;
        }

        /* 
         * Callback function for the create button.
         * Cultivates the board with the provided number of buttons.
         */
        public void createClick(object sender, System.EventArgs e)
        {
            inform("Creating board...");
            /* Clear any existing buttons */
            this.Board.Controls.Clear();
            this.BoardCreationStatus.Value = 0;

            /* Get number of buttons */
            this.numX = (int)this.BoardWidth.Value;
            this.numY = (int)this.BoardHeight.Value;
            /* Set Maximum for the loading bar */
            this.BoardCreationStatus.Maximum = numX * numY;
            int buttonW, buttonH;
            /* Determine button width and height */
            buttonW = this.Board.Width / numX;
            buttonH = this.Board.Height / numY;
            /* Cultivate board */
            for (int i = 0; i < numY; i++)
            {
                for (int j = 0; j < numX; j++)
                {
                    Button btn = new Button();
                    btn.Location = new System.Drawing.Point(j * buttonW, i * buttonH);
                    btn.Name = "cell" + this.Board.Controls.Count;
                    btn.Size = new System.Drawing.Size(buttonW, buttonH);
                    btn.Text = "";
                    btn.UseVisualStyleBackColor = true;
                    btn.BackColor = System.Drawing.Color.White;
                    btn.Click += new System.EventHandler(cellClick);
                    this.Board.Controls.Add(btn);
                    this.BoardCreationStatus.PerformStep();
                }
            }
            inform("Created the board ready to start");
        }

        /* 
         * Callback function for the start button.
         * Initializes the game of life with the spefified living cells
         */
        public void startClick(object sender, System.EventArgs e)
        {
            if (this.Board.Controls.Count == 0)
            {
                inform("Please create the board first");
                return;
            }
            this.BoardWidth.Enabled = false;
            this.BoardHeight.Enabled = false;
            this.Reset.Enabled = false;
            this.Create.Enabled = false;
            this.Start.Enabled = false;

            if (golInProgress == false)
            {
                this.resetState = new bool[this.Board.Controls.Count];
                for (int i = 0; i < this.Board.Controls.Count; i++)
                {
                    if (this.Board.Controls[i].BackColor == System.Drawing.Color.Black) resetState[i] = true;
                    else resetState[i] = false;
                }
            }
            this.golInProgress = true;
            this.generationTimer.Start();
            inform("Running...");
        }
        public void nextGeneration(object sender, System.EventArgs e)
        {
            int index = 0;
            bool[] isAlive = new bool[this.Board.Controls.Count];
            Control.ControlCollection newGeneration = new Control.ControlCollection(this.Board);
            foreach (Button cell in this.Board.Controls)
            {
                int aliveNeighbours = this.getNumAliveNeighbours(index);
                switch (aliveNeighbours)
                {
                    case 2:
                        if (cell.BackColor == System.Drawing.Color.Black) isAlive[index] = true;
                        else isAlive[index] = false;
                        break;
                    case 3:
                        isAlive[index] = true;
                        break;
                    default:
                        isAlive[index] = false;
                        break;

                }
                index++;
            }
            for (int i = 0; i < this.Board.Controls.Count; i++)
            {
                if (isAlive[i]) this.Board.Controls[i].BackColor = System.Drawing.Color.Black;
                else this.Board.Controls[i].BackColor = System.Drawing.Color.White;
            }
        }

        /*
         * Callback function for the stop button.
         * Interrupts the Game of Life (are you god?) to be continued after or reset completely.
         */
        public void stopClick(object sender, System.EventArgs e)
        {
            this.generationTimer.Stop();
            this.BoardWidth.Enabled = true;
            this.BoardHeight.Enabled = true;
            this.Reset.Enabled = true;
            this.Create.Enabled = true;
            this.Start.Enabled = true;
            inform("Stopped");
        }

        /*
         * Callback function for the reset button.
         * Resets the Game to its starting point so it may be run again.
         */
        public void resetClick(object sender, System.EventArgs e)
        {
            if (this.Board.Controls.Count == 0)
            {
                inform("You must create a board first");
                return;
            }
            for (int i = 0; i < this.Board.Controls.Count; i++)
            {
                if (resetState[i] == true) this.Board.Controls[i].BackColor = System.Drawing.Color.Black;
                else this.Board.Controls[i].BackColor = System.Drawing.Color.White;
            }
            this.golInProgress = false;
            inform("Game reset");
        }

        public void generationDelayChange(object sender, System.EventArgs e)
        {
            this.generationTimer.Interval = (int)this.generationDelay.Value;
        }
    }
}
