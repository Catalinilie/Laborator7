using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class City
    {

        public City(string name, string description, double latitude, double longitude)
        {
            Id = new Guid();
            Name = name;
            Description = description;
            Latitude = latitude;
            Longitude = longitude;
            POIs = new List<POI>();
        }
        public Guid Id { get; private set; }

        [StringLength(150, MinimumLength = 50)]
        public String Name { get; private set; }

        public String Description { get; private set; }

        public Double Latitude { get; private set; }

        public Double Longitude { get; private set; }

        public List<POI> POIs { get; private set; }

        public POI GetPOIById(Guid id)
        {
            return (new POI("POI", "Poi description"));
        }

    }
}
