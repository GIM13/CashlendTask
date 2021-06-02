using System.ComponentModel.DataAnnotations;

namespace Cashlend.Data
{
    public class Country
    {
        [Key]
        public int CountriyId { get; set; }

        [Required, MaxLength(40)]
        public string CountryName { get; set; }

        [Required, MaxLength(40)]
        public string Continent { get; set; }
    }
}
