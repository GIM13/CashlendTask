using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Data
{
    public class Country
    {
        public int CountryId { get; set; }

        [Required,MaxLength(40)]
        public string CountryName { get; set; }

        [Required,MaxLength(40)]
        public string Continent { get; set; }
    }
}
