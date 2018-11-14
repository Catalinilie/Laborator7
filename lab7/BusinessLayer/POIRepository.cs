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

        public void Edit(Guid id, POI poi)
        {
            POI poii = new POI(id, poi.Name, poi.Description);
            POI pooi = this._context.POIs.Find(id);
            this._context.POIs.Remove(pooi);
            this._context.POIs.Add(poii);
            this._context.SaveChanges();
        }

        public POI GetById(Guid poi_id)
        {
            POI poi = _context.POIs.Find(poi_id);
            return poi;
        }

        public City GetCity()
        {
            return new City("Oras1", "asd", 1, 1);
        }
     
    }
}
