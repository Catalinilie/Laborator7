using DataLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class Repository:IRepository
    {
        CityContext _context;

        public Repository(CityContext context)
        {
            _context = context;
        }


        public void Create(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }


        public void Delete(City city)
        {
            _context.Cities.Remove(city);
            _context.SaveChanges();
        }

        public void Edit(City city)
        {
            throw new NotImplementedException();
        }

        public City GetById(Guid id)
        {
            return new City("Oras1", "asd", 1, 1);
        }
        
    }
}
