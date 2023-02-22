using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class AddPhotoModel
    {
         public Guid AnimalId {get; set; } 
         public IFormFile File { get; set; }
    }
}