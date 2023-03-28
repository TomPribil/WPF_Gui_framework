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
using System.Windows.Shapes;
using WPF_Gui_framework.Tabulky;

namespace WPF_Gui_framework
{

    public partial class AddPivoWindow : Window


    {
        private PivoContext _context;

        public Pivo NewPivo { get; set; }
        public AddPivoWindow()
        {
            InitializeComponent();
            _context = new PivoContext();
            FillComboBoxes();
        }
        private void FillComboBoxes()
        {

            cbStupnovitost.ItemsSource = _context.Stupnovitost.ToList();
            cbStupnovitost.DisplayMemberPath = "Nazev";
            cbStupnovitost.SelectedValuePath = "Id_stupne";


            cbBarva.ItemsSource = _context.Barva.ToList();
            cbBarva.DisplayMemberPath = "Nazev";
            cbBarva.SelectedValuePath = "Id_barvy";


            cbTypPiva.ItemsSource = _context.TypPiva.ToList();
            cbTypPiva.DisplayMemberPath = "Nazev";
            cbTypPiva.SelectedValuePath = "Id_typu";

            cbPivovar.ItemsSource = _context.Pivovary.ToList();
            cbPivovar.DisplayMemberPath = "Nazev";
            cbPivovar.SelectedValuePath = "Id_pivovaru";
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNazev.Text) || string.IsNullOrEmpty(txtIBU.Text) || string.IsNullOrEmpty(txtObsahAlkoholu.Text) ||
                cbStupnovitost.SelectedValue == null || cbBarva.SelectedValue == null || 
                cbTypPiva.SelectedValue == null || cbPivovar.SelectedValue == null)
            {
                MessageBox.Show("Před odesláním musíte vyplnit všechny informace!");
                return;
            }

            var pivo = new Pivo
            {
                Nazev = txtNazev.Text,
                IBU = int.Parse(txtIBU.Text),
                Obsah_alkoholu = decimal.Parse(txtObsahAlkoholu.Text),
                Id_stupne = (int)cbStupnovitost.SelectedValue,
                Id_barvy = (int)cbBarva.SelectedValue,
                Id_typu = (int)cbTypPiva.SelectedValue,
                Id_pivovaru = (int)cbPivovar.SelectedValue
            };

            _context.Piva.Add(pivo);
            _context.SaveChanges();

            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
