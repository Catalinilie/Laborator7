using System;
using DataLayer;

namespace BusinessLayer
{
    public class POIRepository:IPOIRepository
    {
        POIContext _context;

        public POIRepository(POIContext context)
        {
            _context = context;
        }


        public void Create(POI poi)
        {
            _context.POIs.Add(poi);
            _context.SaveChanges();
        }


        public void Delete(POI poi)
        {
            _context.POIs.Remove(poi);
            _context.SaveChanges();
        }

        public void Edit(POI poi)
        {
            throw new NotImplementedException();
        }

        public City GetCity()
        {
            return new City("Oras1", "asd", 1, 1);
        }
     
    }
}
