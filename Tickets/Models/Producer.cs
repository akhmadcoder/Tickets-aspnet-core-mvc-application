using System.ComponentModel.DataAnnotations;
using Tickets.Data.Base;

namespace Tickets.Models
{
    public class Producer: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required]
        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
