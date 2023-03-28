using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
