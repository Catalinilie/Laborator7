using System;
using System.ComponentModel.DataAnnotations;

namespace lab7.Models
{
    public class CityModel
    {
        public Guid Id { get; private set; }

        [StringLength(150, MinimumLength = 50)]
        public String Name { get; private set; }

        public String Description { get; private set; }

        public Double Latitude { get; private set; }

        public Double Longitude { get; private set; }
    }
}
