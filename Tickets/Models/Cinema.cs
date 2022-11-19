﻿using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        // relationships
        public List<Movie> Movies { get; set; }
    }
}
