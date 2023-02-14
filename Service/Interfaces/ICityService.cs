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
    public interface ICityService
    {
        CityDTO GetById(long Id);
        IEnumerable<CityDTO> GetAll();
        IEnumerable<CityDTO> Find(Expression<Func<City, bool>> expression);
        void Add(CityDTO cityDTO);
        void AddRange(IEnumerable<CityDTO> cityDTOs);
        void Remove(CityDTO cityDTO);
        void RemoveRange(IEnumerable<CityDTO> cityDTOs);
    }
}
