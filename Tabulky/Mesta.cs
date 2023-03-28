using System.ComponentModel.DataAnnotations;
using WPF_Gui_framework.Tabulky;

namespace WPF_Gui_framework
{
    public class Mesto
    {
        [Key]
        public int Id_mesta { get; set; }
        public string Nazev { get; set; }
        public int Id_kraje { get; set; }

        public virtual Kraj Kraj { get; set; }
    }
}
