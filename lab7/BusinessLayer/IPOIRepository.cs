using DataLayer;

namespace BusinessLayer
{
    public interface IPOIRepository
    {
        void Create(POI poi);
        void Edit(POI poi);
        void Delete(POI poi);
        City GetCity();
    }
}
