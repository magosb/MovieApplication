using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MagsAzureApp.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 3)]
        [Required(ErrorMessage = "Genre must be specified")]
        public string Title { get; set; }
        [StringLength(60, MinimumLength = 0)]
        public string Producer { get; set; }
        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }
        [StringLength(600)]
        public string Genre { get; set; }
        public byte[] Image { get; set; }
        public string ImagePath { get; set; }
        public string TrailerID { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        [Range(0, 10, ErrorMessage = "Ratinge must be between 1 and 10")]
        public decimal Rating { get; set; }
    }

  public class AzureMoviesDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}