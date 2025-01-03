﻿using Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repositories
{
    public interface ICountryRepo: IGenericRepo<Country>
    {
        IEnumerable<Country> GetAll();


    }
}
