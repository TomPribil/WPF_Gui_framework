using System.ComponentModel.DataAnnotations;

namespace WPF_Gui_framework.Tabulky
{
    public class Barva
    {
        [Key]
        public int Id_barvy { get; set; }
        public string Nazev { get; set; }
    }
}
