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
        
        public GameOfLife(int zellenHoch, int zellenBreit)
        {
            this.zellenHoch = zellenHoch;
            this.zellenBreit = zellenBreit;
        }
        
        public int getAbove()
        {
            return this.above;
        }

        public int getBelow()
        {
            return this.below;
        }

        public int getLeft()
        {
            return this.left;
        }

        public int getRight()
        {
            return this.right;
        }
        public void Evolve(Feld[,] kolonie)
        {
            int[,] listeLebendige = Calculate_Cells(kolonie);
            Set_Status(kolonie, listeLebendige);
        }

        public int[,] Calculate_Cells(Feld[,] kolonie)
        {
            int[,] zellen = new int[zellenHoch, zellenBreit];
            for (int i = 0; i < zellenHoch; i++)
            {
                for (int j = 0; j < zellenBreit; j++)
                {
                    this.above = i - 1;
                    this.below = i + 1;
                    this.left = j - 1;
                    this.right = j + 1;

                    check();
                    
                    if (kolonie[above,left].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[below, right].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[below, j].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[i, left].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[below, left].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[i, right].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[above, right].Status)
                    {
                        zellen[i, j]++;
                    }
                    if (kolonie[above, j].Status)
                    {
                        zellen[i, j]++;
                    }
                }
            }
            return zellen;
        }

        public void Set_Status(Feld[,] kolonie, int[,] zellen)
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

        public void check()
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
    }
}
