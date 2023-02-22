using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class AnimalController : BaseApiController
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAnimals()
        {
            return HandleResult(await _animalRepository.GetAllAnimals());
        }
    }
}