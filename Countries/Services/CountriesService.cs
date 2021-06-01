using Countries.Data;
using Countries.Data.Countries.Models;
using Countries.Services.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Countries.Services
{
    public class CountriesService 
    {
        private readonly CountriesDbContext countriesDb;

        public CountriesService(CountriesDbContext countriesDb)
        {
            this.countriesDb = countriesDb;
        }

        public List<Country> AllCountries()
        {
            return this.countriesDb.Countries
                .ToList();
        }

        public List<Country> SortId()
        {
            return this
                .AllCountries()
                .OrderBy(x => x.CountryId)
                .ToList();
        }

        public List<Country> SortName()
        {
            return this
                .AllCountries()
                .OrderBy(x => x.CountryName)
                .ToList();
        }

        public List<Country> SortContinent()
        {
            return this
                .AllCountries()
                .OrderBy(x => x.Continent)
                .ThenBy(x => x.CountryName)
                .ToList();
        }

        public Country FilterOnName(string name)
        {
            return this
                .AllCountries()
                .Where(x => x.CountryName == name)
                .FirstOrDefault();
        }
    }
}
