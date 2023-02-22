using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Infrastructure.Interfaces
{
    public interface IPhotoAccessor
    {
         Task<PhotoUploadResult> AddPhoto(IFormFile file);
    }
}