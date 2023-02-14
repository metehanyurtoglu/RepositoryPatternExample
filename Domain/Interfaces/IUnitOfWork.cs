﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();

        ICityRepository Cities { get; }
        ICountryRepository Countiries { get; }
    }
}
