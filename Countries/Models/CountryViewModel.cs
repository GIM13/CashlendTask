using System;
using System.ComponentModel.DataAnnotations;

namespace Countries.Models
{
    public class CountryViewModel
    {
        public int CountryId { get; set; }

        [Required, MaxLength(40)]
        public string CountryName { get; set; }

        [Required, MaxLength(40)]
        public string Continent { get; set; }
    }
}
