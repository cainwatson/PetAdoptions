using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetAdoptions.Api.Models;
using PetAdoptions.Api.Data.RescueGroups;

namespace PetAdoptions.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalListingsController : ControllerBase
    {
        private readonly ILogger<AnimalListingsController> _logger;
        private readonly AnimalsService _animalsService;

        public AnimalListingsController(ILogger<AnimalListingsController> logger, AnimalsService animalsService)
        {
            _logger = logger;
            _animalsService = animalsService;
        }

        [HttpGet]
        public async Task<IEnumerable<AnimalListing>> Get(AnimalsService.Store store = AnimalsService.Store.Sample, int start = 0, int limit = 6)
        {
            var animals = await this._animalsService.GetAsync(store, start, limit);
            var animalListings = AnimalListing.fromRescueGroups(animals);

            return animalListings;
        }
    }
}
