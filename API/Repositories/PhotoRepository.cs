using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Persistence;
using API.Repositories.Common;
using API.Repositories.Interfaces;

namespace API.Repositories
{
    public class PhotoRepository : GenericRepository<Photo>, IPhotoRepository
    {
        public PhotoRepository(DataContext context) : base(context)
        {
        }

       
    }
}