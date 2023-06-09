﻿using Microsoft.EntityFrameworkCore;
using WPF_Gui_framework.Tabulky;

namespace WPF_Gui_framework
{
    internal class PivoContext : DbContext
    {
        public DbSet<Barva> Barva { get; set; }
        public DbSet<Kraj> Kraj { get; set; }
        public DbSet<Mesto> Mesta { get; set; }
        public DbSet<Pivo> Piva { get; set; }
        public DbSet<Pivovary> Pivovary { get; set; }
        public DbSet<Stupnovitost> Stupnovitost { get; set; }
        public DbSet<TypPiva> TypPiva{ get; set; }
        public object Stupnovitosti { get; internal set; }
        public object Barvy { get; internal set; }
        public object TypyPiva { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=pivovary;UID=root;PASSWORD=password;");
        }
    }

}
