using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace filmy.Models
{
    [Table("Film")]
    public class Film
    {
        [Key]
        private long id;
        [Display(Name = "Nazwa")]
        private string nazwa;
        [Display(Name = "Typ")]
        private string typ;
        [Display(Name = "Gatunek")]
        private string gatunek;
        [Display(Name = "Reżyseria")]
        private string rezyseria;
        [Display(Name = "Scenariusz")]
        private string scenariusz;
        [Display(Name = "Produkcja")]
        private string produkcja;
        [Display(Name = "Premiera")]
        private string premiera;

        public class FilmDB : DbContext
        {
            public DbSet<Film> Filmy { get; set; }
        }
    }
}