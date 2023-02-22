using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities.Interfaces;

namespace API.Entities
{
    public class Photo : IEntity
    {
        public Guid Id { get; set; }

        public string PublicId { get; set; }

        public string Url { get; set; }
        public bool IsMain { get; set; }
    }
}