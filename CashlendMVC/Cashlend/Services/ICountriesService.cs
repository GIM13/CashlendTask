using System.Collections.Generic;

namespace Cashlend.Services
{
   public interface ICountriesService
    {
        IEnumerable<T> GetAll<T>();

        IEnumerable<T> SortedCountryId<T>();

        IEnumerable<T> SortedCountryName<T>();

        IEnumerable<T> SortedContinent<T>();
    }
}
