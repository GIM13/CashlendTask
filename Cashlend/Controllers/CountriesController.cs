using Cashlend.Data;
using Cashlend.Models;
using Cashlend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cashlend.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountriesService countriesService;

        public CountriesController(
            ICountriesService countriesService,
            List<Country> countryRepository)
        {
            this.countriesService = countriesService;
        }

        public IActionResult Index()
        {
            var countries = this.countriesService.GetAll<CountryViewModel>();
            var model = new CountriesListViewModel { Countries = countries };
            return this.View(model);
        }

        public IActionResult SearchCountriy()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult SearchCountriy(CountryInputViewModel input)
        {
            if (this.countriesService
                .GetAll<CountryViewModel>()
                .Any(x => x.CountryName == input.CountryName)
                || input.CountryName.Length < 2
                || input.CountryName.Length > 40)
            {
                return this.View("IncorrectInput");
            }

            var model = this.countriesService
                .GetAll<CountryViewModel>()
                .Where(x => x.CountryName == input.CountryName)
                .FirstOrDefault();

            return this.View("FoundCountry", model);
        }
    }
}
