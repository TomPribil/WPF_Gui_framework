using System.ComponentModel.DataAnnotations;

namespace WPF_Gui_framework.Tabulky
{
    public class TypPiva
    {
        [Key]
        public int Id_typu { get; set; }
        public string Nazev { get; set; }
    }
}
