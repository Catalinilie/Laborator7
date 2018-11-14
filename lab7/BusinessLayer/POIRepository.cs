using System;
using System.Collections.Generic;
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

        public List<POI> GetPOIs()
        {
            List<POI> list = new List<POI>(10);
            list.Add(new POI("POI1","Description of POI 1"));
            return list;
        }
     
    }
}
