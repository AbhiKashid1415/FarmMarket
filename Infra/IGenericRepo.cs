﻿using Infra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public interface IGenericRepo<T>where T:class
    {
        List<T> GetAll();
        T GetById(Int64 id);
        void Add(T rec);
        void Delete(Int64 id);
        void Update(T rec);
        List<StateVM> GetStatesByCountryID(long CountryID);
    }
}
