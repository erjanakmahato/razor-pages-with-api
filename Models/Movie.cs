using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPageMovie.Models
{
    public class Movie
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(60,MinimumLength =5)]
        public string Title { get; set; }
  
        [Display(Name ="Release Year"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Genre { get; set; }
        public decimal Price { get; set; }
        [Required]
        [StringLength(5)]
        public string Rating { get; set; }
    }
}
