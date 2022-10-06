﻿using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}