using System.ComponentModel.DataAnnotations;

namespace RatingApp.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public string Title { get; set; }

        [MaxLength(100, ErrorMessage = "Only 100 characters are allowed.")]
        public string Description { get; set; }

        public DateTime Created { get; set; }


        [Required]
        [Range(0,5)]
        public int Stars { get; set; }


    }
}
