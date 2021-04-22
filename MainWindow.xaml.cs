using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPF_GameOfLife
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int anzahlZellenHoch;
        public static int anzahlZellenBreit;
        public double generationenDauer;
        public Feld [,] zellen;
        public Dictionary<Rectangle, Feld> rectStatusPaar;
        public DispatcherTimer generationenTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            generationenTimer.Interval = TimeSpan.FromSeconds(generationenDauer);
            generationenTimer.Tick += GenerationenTimer_Tick;
            lbl_Infotext.Content = "Welcome to \nGame of Life! \nRules etc:\nw.wiki/3CWR";
        }

        private void GenerationenTimer_Tick(object sender, EventArgs e)
        {
            btn_Next.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }
        private void btn_Create_Click(object sender, RoutedEventArgs e)
        {
            rectStatusPaar = new Dictionary<Rectangle, Feld>();
            bool isParsableHoch = Int32.TryParse(tbx_ZellenHoch.Text, out int eingabeHoch);
            bool isParsableBreit = Int32.TryParse(tbx_ZellenBreit.Text, out int eingabeBreit);

            if ((isParsableHoch && (eingabeHoch < 51 && eingabeHoch > 2)) && (isParsableBreit && (eingabeBreit < 51 && eingabeBreit > 2)))
            {
                anzahlZellenHoch = eingabeHoch;
                anzahlZellenBreit = eingabeBreit;
                zellen = new Feld [anzahlZellenHoch, anzahlZellenBreit];
                for (int i = 0; i < anzahlZellenHoch; i++)
                {
                    for (int j = 0; j < anzahlZellenBreit; j++)
                    {
                        Feld zelle = new Feld(new Rectangle(), false);
                        zelle.Status = false;
                        zelle.Shape.Width = cnv_Spielfeld.ActualWidth / anzahlZellenBreit;
                        zelle.Shape.Height = cnv_Spielfeld.ActualHeight / anzahlZellenHoch;
                        zelle.Shape.Stroke = Brushes.Gray;
                        zelle.Shape.StrokeThickness = 0.5;
                        zelle.Shape.Fill = Brushes.White;                        
                        cnv_Spielfeld.Children.Add(zelle.Shape);
                        Canvas.SetLeft(zelle.Shape, j * cnv_Spielfeld.ActualWidth / anzahlZellenBreit);
                        Canvas.SetTop(zelle.Shape, i * cnv_Spielfeld.ActualHeight / anzahlZellenHoch);
                        zelle.Shape.MouseDown += Zelle_MouseDown;
                        rectStatusPaar.Add(zelle.Shape, zelle);
                        zellen[i, j] = zelle;
                    }
                }
                btn_Next.IsEnabled = true;
                btn_Reset.IsEnabled = true;
                btn_Start.IsEnabled = true;
                btn_Stop.IsEnabled = true;
                btn_Random.IsEnabled = true;
                lbl_Infotext.Content = "Playing field \nwas created.";
            }
            else
            {
                lbl_Infotext.Content = "Please enter a \nnumber 3-50.";
            }
        }

        private void Zelle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbl_Infotext.Content = "";

            if (((Rectangle)sender).Fill == Brushes.White)
            {
                ((Rectangle)sender).Fill = Brushes.Black;
                rectStatusPaar[(Rectangle)sender].Status = true;

            } else
            {
                ((Rectangle)sender).Fill = Brushes.White;
                rectStatusPaar[(Rectangle)sender].Status = false;
            }
        }

        private void btn_Next_Click(object sender, RoutedEventArgs e)
        {
            btn_Create.IsEnabled = false;
            GameOfLife generation = new GameOfLife();
            generation.Evolve(zellen, anzahlZellenHoch, anzahlZellenBreit);
        }

        private void btn_Start_Click(object sender, RoutedEventArgs e)
        {
            generationenTimer.Start();
            lbl_Infotext.Content = "The game is \nrunning \nautomtically.";
            btn_Create.IsEnabled = false;
            btn_Random.IsEnabled = false;
        }

        private void btn_Stop_Click(object sender, RoutedEventArgs e)
        {
            generationenTimer.Stop();
            lbl_Infotext.Content = "The game was \nstopped.";
            btn_Random.IsEnabled = true;
            btn_Create.IsEnabled = true;
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            generationenTimer.Stop();
            foreach (Feld zelle in zellen)
            {
                zelle.Status = false;
            }
            lbl_Infotext.Content = "The game was \nreset.";
            btn_Create.IsEnabled = true;
            btn_Random.IsEnabled = true;
            tbx_ZellenBreit.IsEnabled = true;
            tbx_ZellenHoch.IsEnabled = true;
        }

        private void btn_Random_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            foreach (Feld zelle in zellen)
            {
                if (rand.NextDouble() < 0.5)
                    zelle.Status = true;
                else
                    zelle.Status = false;
            }

            lbl_Infotext.Content = "Living colonies\nplaced at\nrandom.";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            generationenDauer = e.NewValue;
            generationenTimer.Interval = TimeSpan.FromSeconds(generationenDauer);          
        }
    }
}
