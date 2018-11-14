using System;
using System.ComponentModel.DataAnnotations;

namespace lab7.Models
{
    public class POIModel
    {
        [StringLength(150, MinimumLength = 50)]
        public String Name { get; private set; }

        [StringLength(500)]
        public String Description { get; private set; }
    }
}
