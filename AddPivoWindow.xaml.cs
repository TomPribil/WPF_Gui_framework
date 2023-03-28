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

namespace WPF_Gui_framework
{
    /// <summary>
    /// Interaction logic for AddPivoWindow.xaml
    /// </summary>
    public partial class AddPivoWindow : Window


    {
        //public Pivo NewPivo { get; set; }
        //public AddPivoWindow()
        //{
        //    InitializeComponent();
        //    _context = new PivoContext();
        //}
        //private void FillComboBoxes()
        //{
        //    // Fill the Stupnovitost ComboBox
        //    var stupne = _context.Stupnovitosti.ToList();
        //    cboStupnovitost.ItemsSource = stupne;
        //    cboStupnovitost.DisplayMemberPath = "Nazev";
        //    cboStupnovitost.SelectedValuePath = "Id";

        //    // Fill the Barva ComboBox
        //    var barvy = _context.Barvy.ToList();
        //    cboBarva.ItemsSource = barvy;
        //    cboBarva.DisplayMemberPath = "Nazev";
        //    cboBarva.SelectedValuePath = "Id";

        //    // Fill the TypPiva ComboBox
        //    var typy = _context.TypyPiv.ToList();
        //    cboTypPiva.ItemsSource = typy;
        //    cboTypPiva.DisplayMemberPath = "Nazev";
        //    cboTypPiva.SelectedValuePath = "Id";

        //    // Fill the Pivovary ComboBox
        //    var pivovary = _context.Pivovary.ToList();
        //    cboPivovar.ItemsSource = pivovary;
        //    cboPivovar.DisplayMemberPath = "Nazev";
        //    cboPivovar.SelectedValuePath = "Id";
        //}
        //private void btnSave_Click(object sender, RoutedEventArgs e)
        //{
        //    // Create a new Pivo object with the user's input
        //    var pivo = new Pivo
        //    {
        //        Nazev = txtNazev.Text,
        //        IBU = (int)numIBU.Value,
        //        Obsah_alkoholu = (double)numObsahAlkoholu.Value,
        //        StupnovitostId = (int)cboStupnovitost.SelectedValue,
        //        BarvaId = (int)cboBarva.SelectedValue,
        //        TypPivaId = (int)cboTypPiva.SelectedValue,
        //        PivovarId = (int)cboPivovar.SelectedValue
        //    };

        //    // Add the new Pivo object to the database
        //    _context.Piva.Add(pivo);
        //    _context.SaveChanges();

        //    // Close the window
        //    Close();
        //}
    }
}
