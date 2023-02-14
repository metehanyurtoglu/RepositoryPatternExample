using AutoMapper.Internal.Mappers;
using Domain.Entities;
using Domain.Interfaces;
using Service.DTOs;
using Service.Interfaces;
using Service.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class CountryService : ICountryService
    {
        private IUnitOfWork _unitOfWork;

        public CountryService(IUnitOfWork unitofWork)
        {
            _unitOfWork = unitofWork;
        }

        public CountryDTO GetById(long Id)
        {
            var country = _unitOfWork.Countiries.GetById(Id);

            return ObjectMapper.Mapper.Map<CountryDTO>(country);
        }

        public IEnumerable<CountryDTO> GetAll()
        {
            var countiries = (IEnumerable<CountryDTO>)_unitOfWork.Countiries.GetAll();

            return countiries;
        }

        public IEnumerable<CountryDTO> Find(Expression<Func<Country, bool>> expression)
        {
            var countries = (IEnumerable<CountryDTO>)_unitOfWork.Countiries.Find(expression).ToList();

            return countries;
        }

        public void Add(CountryDTO countryDTO)
        {
            var country = ObjectMapper.Mapper.Map<Country>(countryDTO);

            _unitOfWork.Countiries.Add(country);

            _unitOfWork.Complete();
        }

        public void AddRange(IEnumerable<CountryDTO> countryDTOs)
        {
            var countries = ObjectMapper.Mapper.Map<IList<Country>>(countryDTOs);

            _unitOfWork.Countiries.AddRange(countries);

            _unitOfWork.Complete();
        }

        public void Remove(CountryDTO countryDTO)
        {
            var country = ObjectMapper.Mapper.Map<Country>(countryDTO);

            _unitOfWork.Countiries.Remove(country);

            _unitOfWork.Complete();
        }

        public void RemoveRange(IEnumerable<CountryDTO> countryDTOs)
        {
            var countries = ObjectMapper.Mapper.Map<IList<Country>>(countryDTOs);

            _unitOfWork.Countiries.RemoveRange(countries);

            _unitOfWork.Complete();
        }
    }
}
