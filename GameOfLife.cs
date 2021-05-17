using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GameOfLife
{
    public class GameOfLife
    {
        private int above;
        private int below;
        private int left;
        private int right;

        private int zellenHoch;
        private int zellenBreit;       


        public int Above
        {
            get
            {
                return this.above;
            }
            set
            {
                this.above = value - 1;
                Check();
            }
        }
        public int Below
        {
            get
            {
                return this.below;
            }
            set
            {
                this.below = value + 1;
                Check();
            }
        }
        public int Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value - 1;
                Check();
            }
        }
        public int Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value + 1;
                Check();
            }
        }
        private void Check()
        {
            if (this.above < 0)
            {
                this.above = zellenHoch - 1;
            }
            if (this.below >= zellenHoch)
            {
                this.below = 0;
            }
            if (this.left < 0)
            {
                this.left = zellenBreit - 1;
            }
            if (this.right >= zellenBreit)
            {
                this.right = 0;
            }
        }

        public void Evolve(Feld[,] kolonie)
        {
            int[,] listeLebendige = Calculate_Cells(kolonie);
            Set_Status(kolonie, listeLebendige);
        }

        private int[,] Calculate_Cells(Feld[,] kolonie)
        {
            int[,] zellen = new int[zellenHoch, zellenBreit];
            for (int i = 0; i < zellenHoch; i++)
            {
                for (int j = 0; j < zellenBreit; j++)
                {
                    Above = i;
                    Below = i;
                    Left = j;
                    Right = j;
                    
                    if (kolonie[Above, Left].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[Below, Right].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[Below, j].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[i, Left].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[Below, Left].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[i, Right].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[Above, Right].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[Above, j].Status)
                    {
                        zellen[i, j]++;
                    }
                }
            }
            return zellen;
        }

        private void Set_Status(Feld[,] kolonie, int[,] zellen)
        {
        for (int i = 0; i < zellenHoch; i++)
            {
                for (int j = 0; j < zellenBreit; j++)
                {
                    if (kolonie[i,j].Status)
                    {
                        if (zellen[i,j] < 2 || zellen[i, j] > 3)
                        {
                            kolonie[i, j].Status = false;
                        }

                    } else if (zellen[i,j] == 3)
                    {
                        kolonie[i, j].Status = true;
                    }

                }
            } 
        }

        public GameOfLife(int zellenHoch, int zellenBreit)
        {
            this.zellenHoch = zellenHoch;
            this.zellenBreit = zellenBreit;
        }
    }
}
