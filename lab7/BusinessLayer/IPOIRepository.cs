using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
  public interface IPOIRepository
    {
        void Create(POI poi);
        void Edit(POI poi);
        void Delete(POI poi);
        List<POI> GetPOIs();
    }
}
