using System.ComponentModel.DataAnnotations;

namespace WPF_Gui_framework.Tabulky
{
    public class Kraj
    {
        [Key]
        public int Id_kraje { get; set; }
        public string Nazev { get; set; }
    }
}
