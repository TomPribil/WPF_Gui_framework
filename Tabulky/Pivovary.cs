using System.ComponentModel.DataAnnotations;

namespace WPF_Gui_framework
{
    public class Pivovary
    {
        [Key]
        public int Id_pivovaru { get; set; }
        public string Nazev { get; set; }
        public int Id_mesta { get; set; }
        public string Web { get; set; }
        public string Adresa { get; set; }
    }
}

