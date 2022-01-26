using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4.Models
{
    public class MovieResponse
    {
        [Key]
        [Required]

        public int MovieId { get; set; }

        [Required]

        public string Category { get; set; }

        [Required]

        public string Title { get; set; }

        [Required]

        public string Year { get; set; }

        [Required]

        public string Director { get; set; }

        [Required]

        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lentto { get; set; }

        [MaxLength(20)]

        public string Notes { get; set; }
    }
}
