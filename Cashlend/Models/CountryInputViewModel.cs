using System.ComponentModel.DataAnnotations;

namespace Cashlend.Models
{
    public class CountryInputViewModel
    {
        [Required]
        [MaxLength(40)]
        public string CountryName { get; set; }
    }
}
