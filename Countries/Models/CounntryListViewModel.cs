using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Models
{
    public class CounntryListViewModel
    {
        public IEnumerable<CountryViewModel> AllCountries { get; set; }
    }
}
