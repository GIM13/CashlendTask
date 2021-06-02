using Cashlend.Data;
using System.Collections.Generic;
using System.Linq;

namespace Cashlend.Services
{
    public class CountriesService : ICountriesService
    {
        private readonly CashlendDbContext countriesRepository;

        public CountriesService(CashlendDbContext countriesRepository)
        {
            this.countriesRepository = countriesRepository;
        }

        public IEnumerable<T> GetAll<T>()
        {
            var result = this.countriesRepository.Countries
                .AsParallel()
                .ToList();

            return (IEnumerable<T>)result;
        }

        public IEnumerable<T> SortedCountryId<T>()
        {
            return (IEnumerable<T>)this.GetAll<Country>()
                .OrderBy(x => x.CountriyId)
                .ToList();
        }

        public IEnumerable<T> SortedCountryName<T>()
        {
            return (IEnumerable<T>)this.GetAll<Country>()
                .OrderBy(x => x.CountryName)
                .ToList();
        }

        public IEnumerable<T> SortedContinent<T>()
        {
            return (IEnumerable<T>)this.GetAll<Country>()
                .OrderBy(x => x.Continent)
                .ThenBy(x => x.CountryName)
                .ToList();
        }
    }
}
