using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Shapes;

namespace WPF_GameOfLife
{
    [TestClass]
    class GameOfLifeTests
    {
        [TestMethod]
        public void TestSetStatus_2x2_ToteZellen()
        {
            //Arrange
            GameOfLife gol = new GameOfLife();
            int breite = 2;
            int hoehe = 2;
            Feld [,] feld = new Feld[hoehe, breite];
            for (int i = 0; i < hoehe; i++)
            {
                for (int j = 0; j < breite; j++) {
                    feld[i, j] = new Feld(new Rectangle(), false);
                    String a = feld[i,j].Shape.ToString();
                }
            }
            int[,] soll = { {}, {},  }; //gewünschstes Ergebnis der Methode

            //Act
            int[,] test = gol.Calculate_Cells(feld, hoehe, breite);

            //Assert
            Assert.AreEqual(soll, test);
        }
        /*
        [TestMethod]
        public void TestSetStatus_2x2_LebendeZellen()
        {
            //Arrange
            GameOfLife gol = new GameOfLife();
            int breite = 2;
            int hoehe = 2;
            Feld [,] feld = new Feld[hoehe, breite];
            for (int i = 0; i < hoehe; i++)
            {
                for (int j = 0; j < breite; j++) {
                    feld[i, j] = new Feld(new Rectangle(), true);
                    Console.Write("{0}", feld[i, j]);
                }
            }
            int[,] soll = { {}, { } }; //gewünschstes Ergebnis der Methode

            //Act
            int[,] test = gol.Calculate_Cells(feld, hoehe, breite);

            //Assert
            Assert.AreEqual(soll, test);
        }*/
    }
}
