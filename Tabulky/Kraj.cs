﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Gui_framework.Tabulky
{
    public class Kraj
    {
        [Key]
        public int Id_kraje { get; set; }
        public string Nazev { get; set; }
    }
}
