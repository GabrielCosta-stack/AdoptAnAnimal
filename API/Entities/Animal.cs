using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Animal
    {
        public Guid Id { get; set; }

        public Specie Specie { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string CountryOfBirth { get; set; }

        public float Weight { get; set; }

         public ICollection<Photo> Photos {get; set;}

        public DateTime BirthDate { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}