using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Input;


namespace WPF_Gui_framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PivoContext _context = new PivoContext();

        public MainWindow()
        {
            InitializeComponent();
            LoadAllPiva();
            DataContext = this;
        }

        private void LoadAllPiva()
        {
            // Use LINQ to query the database for all Piva, including eager loading for all related entities
            var query = _context.Piva
                        .Include(p => p.Stupnovitost)
                        .Include(p => p.Barva)
                        .Include(p => p.TypPiva)
                        .Include(p => p.Pivovary)
                        .ToList();

            // Update the FilteredPiva collection with the query results
            FilteredPiva.Clear();
            foreach (var pivo in query)
            {
                FilteredPiva.Add(pivo);
            }
        }

        public ObservableCollection<Pivo> FilteredPiva { get; set; } = new ObservableCollection<Pivo>();

        private void txtFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string filter = txtFilter.Text;

                var query = from p in _context.Piva
                            .Include(p => p.Stupnovitost)
                            .Include(p => p.Barva)
                            .Include(p => p.TypPiva)
                            .Include(p => p.Pivovary)
                            where p.Nazev.Contains(filter)
                                  || p.Barva.Nazev.Contains(filter)
                                  || p.TypPiva.Nazev.Contains(filter)
                                  || p.Pivovary.Nazev.Contains(filter)
                            select p;


                // Update the FilteredPiva collection with the query results
                FilteredPiva.Clear();
                foreach (var pivo in query)
                {
                    FilteredPiva.Add(pivo);
                }
            }
        }

        private void AddBeer_Click(object sender, RoutedEventArgs e)
        {
            AddPivoWindow addPivoWindow = new AddPivoWindow();
            addPivoWindow.Show();
        }
    }
}
