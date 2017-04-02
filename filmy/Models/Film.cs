using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace filmy.Models
{
    [Table("Film")]
    public class Film
    {
        [Key]
        public long id { get; set; }

        [Display(Name = "Tytuł")]
        public string tytul { get; set; }

        [Display(Name = "Typ")]
        public string typ { get; set; }

        [Display(Name = "Gatunek")]
        public string gatunek { get; set; }

        [Display(Name = "Reżyseria")]
        public string rezyseria { get; set; }

        [Display(Name = "Scenariusz")]
        public string scenariusz { get; set; }

        [Display(Name = "Produkcja")]
        public string produkcja { get; set; }

        [Display(Name = "Premiera")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime premiera { get; set; }

        public class FilmDBContext : DbContext
        {
            public DbSet<Film> Filmy { get; set; }
        }
    }
}