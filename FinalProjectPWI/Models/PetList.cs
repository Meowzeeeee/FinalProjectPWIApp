using System.ComponentModel.DataAnnotations;

namespace FinalProjectPWI.Models
{
    public class PetList
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Owner's Name")]
        [DataType(DataType.Text)]
        public string? OwnerName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Pet's Name")]
        [DataType(DataType.Text)]
        public string? PetName { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Pet's Type")]
        [DataType(DataType.Text)]
        public string? PetType { get; set; }

        [Required]
        [MaxLength(150)]
        [Display(Name = "Pet's Breed")]
        [DataType(DataType.Text)]
        public string? PetBreed { get; set; }
    }
}
