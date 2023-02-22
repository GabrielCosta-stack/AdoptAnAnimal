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
        private readonly DataContext _context;

        public AnimalRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Result<List<Animal>>> GetAllAnimals()
        {
            return Result<List<Animal>>
            .Success(await GetAll().Include(p => p.Photos).ToListAsync());
        }

        public async Task<Animal> GetAnimalById(Guid id)
        {
            return await _context.Animals
            .Include(p => p.Photos)
            .Where(a => a.Id == id)
            .FirstOrDefaultAsync();
        }

       
    }
}