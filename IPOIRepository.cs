using DataLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
  public interface IPOIRepository
    {
        void Create(POI poi);
        void Edit(Guid id, POI poi);
        void Delete(POI poi);
        List<POI> GetPOIs();
        POI GetById(Guid poi_id);
    }
}
