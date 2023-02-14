using Domain.Entities;
using Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface ICountryService
    {
        CountryDTO GetById(long Id);
        IEnumerable<CountryDTO> GetAll();
        IEnumerable<CountryDTO> Find(Expression<Func<Country, bool>> expression);
        void Add(CountryDTO countryDTO);
        void AddRange(IEnumerable<CountryDTO> countryDTOs);
        void Remove(CountryDTO countryDTO);
        void RemoveRange(IEnumerable<CountryDTO> countryDTOs);
    }
}
