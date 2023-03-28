using System.ComponentModel.DataAnnotations;

namespace WPF_Gui_framework.Tabulky
{
    public class Stupnovitost
    {
        [Key]
        public int Id_stupne { get; set; }
        public string Nazev { get; set; }
    }
}
