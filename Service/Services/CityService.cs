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
    public class CityService : ICityService
    {
        private IUnitOfWork _unitOfWork;

        public CityService(IUnitOfWork unitofWork)
        {
            _unitOfWork = unitofWork;
        }

        public CityDTO GetById(long Id)
        {
            var city = _unitOfWork.Cities.GetById(Id);

            return ObjectMapper.Mapper.Map<CityDTO>(city);
        }

        public IEnumerable<CityDTO> GetAll()
        {
            var cities = (IEnumerable<CityDTO>)_unitOfWork.Cities.GetAll();

            return cities;
        }

        public IEnumerable<CityDTO> Find(Expression<Func<City, bool>> expression)
        {
            var cities = (IEnumerable<CityDTO>)_unitOfWork.Cities.Find(expression).ToList();

            return cities;
        }

        public void Add(CityDTO cityDTO)
        {
            var city = ObjectMapper.Mapper.Map<City>(cityDTO);

            _unitOfWork.Cities.Add(city);

            _unitOfWork.Complete();
        }

        public void AddRange(IEnumerable<CityDTO> cityDTOs)
        {
            var cities = ObjectMapper.Mapper.Map<IList<City>>(cityDTOs);

            _unitOfWork.Cities.AddRange(cities);

            _unitOfWork.Complete();
        }

        public void Remove(CityDTO cityDTO)
        {
            var city = ObjectMapper.Mapper.Map<City>(cityDTO);

            _unitOfWork.Cities.Remove(city);

            _unitOfWork.Complete();
        }

        public void RemoveRange(IEnumerable<CityDTO> cityDTOs)
        {
            var cities = ObjectMapper.Mapper.Map<IList<City>>(cityDTOs);

            _unitOfWork.Cities.RemoveRange(cities);

            _unitOfWork.Complete();
        }
    }
}
