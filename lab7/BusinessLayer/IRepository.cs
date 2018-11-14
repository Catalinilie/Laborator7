﻿using DataLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IRepository
    {
        void Create(City city);
        void Edit(City city);
        void Delete(City city);
        City GetById(Guid id);
    }
}
