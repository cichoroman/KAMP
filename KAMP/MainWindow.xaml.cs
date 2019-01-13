using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using Microsoft.Win32;

namespace KAMP
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Utwor> ListaUtworow = null;
        public MainWindow()
        {
            InitializeComponent();
            InitBinding();
        }
        private void InitBinding()
        {
            ListaUtworow = new List<Utwor>();
            ListaUtworow.Add(new Utwor(1, "The XX","Angels", "C:/KAMP/The XX/01 - The XX - Angels.mp3", "Coexist","C:/KAMP/okladka2.jpg"));
            ListaUtworow.Add(new Utwor(2, "The XX", "Chained", "C:/KAMP/The XX/02 - The XX - Chained.mp3", "Coexist", "C:/KAMP/okladka2.jpg"));
            ListaUtworow.Add(new Utwor(3, "The XX", "Fiction", "C:/KAMP/The XX/03 - The XX - Fiction.mp3", "Coexist", "C:/KAMP/okladka2.jpg"));
            ListaUtworow.Add(new Utwor(4, "The XX", "Try", "C:/KAMP/The XX/04 - The XX - Try.mp3", "Coexist", "C:/KAMP/okladka2.jpg"));
            ListaUtworow.Add(new Utwor(5, "J Cole", "Love Yourz", "C:/KAMP/2014/12 Love Yourz.mp3", "2014 Forest Hills Drive", "C:/KAMP/okladka.jpg"));
            listBox.ItemsSource = ListaUtworow;
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            Element.Play();

        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Element.Stop();
        }
        private void Pause_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Element.Pause();
        }

        private void Previous_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Element.Position = Element.Position - TimeSpan.FromSeconds(10);
        }

        private void Next_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Element.Position = Element.Position + TimeSpan.FromSeconds(10);
        }

        private void listBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Element.Play();
        }


    }
    public class Utwor
    {
        public int id { get; set; }
        public String Autor { get; set; }
        public String Tytul { get; set;}

        public String url { get; set; }

        public String Album { get; set; }

        public String Okladka { get; set; }
        public Utwor(int sid, string sAutor, string sTytul, String surl, String sAlbum, String sOkladka)
        {
            id = sid;
            Autor = sAutor;
            Tytul = sTytul;
            url = surl;
            Album = sAlbum;
            Okladka = sOkladka;
        }
    }
}
