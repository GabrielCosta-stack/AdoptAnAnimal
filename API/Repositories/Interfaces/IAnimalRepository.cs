using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Core;
using API.Entities;

namespace API.Repositories.Interfaces
{
    public interface IAnimalRepository : IGenericRepository<Animal>
    {
        Task<Result<List<Animal>>> GetAllAnimals();

        Task<Animal> GetAnimalById(Guid id);
        
    }
}