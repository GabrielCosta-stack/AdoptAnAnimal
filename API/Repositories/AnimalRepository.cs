using API.Core;
using API.Entities;
using API.Persistence;
using API.Repositories.Common;
using API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AnimalRepository : GenericRepository<Animal>, IAnimalRepository
    {
        public AnimalRepository(DataContext context) : base(context)
        {
        }

        public async Task<Result<List<Animal>>> GetAllAnimals()
        {
            return Result<List<Animal>>.Success(await GetAll().ToListAsync());
        }
    }
}