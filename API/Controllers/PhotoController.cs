using API.Core;
using API.Entities;
using API.Infrastructure.Interfaces;
using API.Models;
using API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PhotoController : BaseApiController
    {
        private readonly IAnimalRepository _animalRepository;
        private readonly IPhotoAccessor _photoAccessor;

        public PhotoController(
            IAnimalRepository animalRepository,
            IPhotoAccessor photoAccessor
            )
        {
            _photoAccessor = photoAccessor;
            _animalRepository = animalRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm] AddPhotoModel formBody)
        {
            var animal = await _animalRepository.GetAnimalById(formBody.AnimalId);
            if(animal == null) 
                return HandleResult(Result<Photo>.Failure("Animal not found"));

            var photoUploadResult = await _photoAccessor.AddPhoto(formBody.File);

            if(photoUploadResult == null)
                return HandleResult(Result<Photo>.Failure("Photo upload Failed"));

            var photo = new Photo{
                Url = photoUploadResult.Url,
                PublicId = photoUploadResult.PublicId
            };

            if(!animal.Photos.Any(x => x.IsMain))
                 photo.IsMain = true;

            animal.Photos.Add(photo);

            var result = await _animalRepository.SaveAllAsync();

            if(result) return HandleResult(Result<Photo>.Success(photo));

            return HandleResult(Result<Photo>.Failure("Problem adding photo"));
        }
    }
}