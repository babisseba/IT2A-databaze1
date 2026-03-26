using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace databaze
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Auto>SeznamAut { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            SeznamAut = new ObservableCollection<Auto>
            {
                new Auto { Id = 1, Znacka = "Porsche", ModelAuta = "911 GT3", RokVyroby = 2023, Karoserie = "Kupé", VykonKw = 375, Mam = false },
                new Auto { Id = 2, Znacka = "Škoda", ModelAuta = "Octavia RS", RokVyroby = 2020, Karoserie = "Kombi", VykonKw = 180, Mam = true }
            };

            dgAuta.ItemsSource = SeznamAut;
        }
    }
}