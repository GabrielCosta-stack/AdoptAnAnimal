using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.Interfaces
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}