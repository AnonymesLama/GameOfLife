using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_GameOfLife
{
    class GameOfLife
    {        
        public void Evolve(Feld[,] kolonie, int anzahlZellenHoch, int anzahlZellenBreit)
        {
            int[,] listeLebendige = new int[anzahlZellenHoch, anzahlZellenBreit];

            for (int i = 0; i < anzahlZellenHoch; i++)
            {
                for (int j = 0; j < anzahlZellenBreit; j++)
                {
                    int above = i - 1;
                    int below = i + 1;
                    int left = j - 1;
                    int right = j + 1;

                    if (above < 0)
                    {
                        above = anzahlZellenHoch - 1;
                    }
                    if (below >= anzahlZellenHoch)
                    {
                        below = 0;
                    }
                    if (left < 0)
                    {
                        left = anzahlZellenBreit - 1;
                    }
                    if (right >= anzahlZellenBreit)
                    {
                        right = 0;
                    }

                    if (kolonie[above,left].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[below, right].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[below, j].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[i, left].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[below, left].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[i, right].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[above, right].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                    if (kolonie[above, j].Status)
                    {
                        listeLebendige[i, j]++;
                    }
                }
            }

            for (int i = 0; i < anzahlZellenHoch; i++)
            {
                for (int j = 0; j < anzahlZellenBreit; j++)
                {
                    if (kolonie[i,j].Status)
                    {
                        if (listeLebendige[i,j] < 2 || listeLebendige[i, j] > 3)
                        {
                            kolonie[i, j].Status = false;
                        }
                    } 
                    else if (listeLebendige[i,j] == 3)
                    {
                        kolonie[i, j].Status = true;
                    }
                }
            } 

        }
    }
}
