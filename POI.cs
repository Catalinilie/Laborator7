using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class POI
    {
        public POI(string name, string description)
        {
            Id = new Guid();
            Name = name;
            Description = description;
        }

        public POI(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Guid Id { get; private set; }

        [StringLength(150, MinimumLength = 50)]
        public String Name { get; private set; }

        public String Description { get; private set; }

        public City city { get; private set; }

    }
}
