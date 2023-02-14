using Core.Repositories;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Cities = new CityRepository(_context);
            Countiries = new CountryRepository(_context);
        }

        public ICityRepository Cities { get; private set; }
        public ICountryRepository Countiries { get; private set; }

        //Example for using repos in generic service class
        //public IGenericRepository<T> GetRepo<T>() where T : class
        //{
        //    IGenericRepository<T> repo = null;
        //    if (typeof(T) == typeof(City))
        //    {
        //        var cityRepo = new GenericRepository<City>(_context);
        //        repo = (IGenericRepository<T>)cityRepo;
        //    }
        //    else if (typeof(T) == typeof(Country))
        //    {
        //        var countryRepo = new GenericRepository<Country>(_context);
        //        repo = (IGenericRepository<T>)countryRepo;
        //    }
        //    return repo;
        //}

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
