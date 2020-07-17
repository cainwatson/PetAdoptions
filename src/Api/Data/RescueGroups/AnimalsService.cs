using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using PetAdoptions.Api.Data.RescueGroups.Objects;

namespace PetAdoptions.Api.Data.RescueGroups
{
    public class AnimalsService
    {
        public enum Store
        {
          Sample,
          Api,
        }

        private readonly IHttpClientFactory _clientFactory;

        public AnimalsService(IHttpClientFactory httpClientFactory)
        {
            _clientFactory = httpClientFactory ?? throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<List<Animal>> GetAsync(Store store, int start, int limit)
        {
            var responseBody = await get(store, start, limit);
            var responseJson = JObject.Parse(responseBody);
            var results = responseJson["data"].Values();

            var animals = new List<Animal>();
            foreach (JToken result in results)
            {
                var animal = result.ToObject<Animal>();
                animals.Add(animal);
            }

            return animals;
        }

        private Task<string> get(Store store, int start, int limit)
        {
            switch (store)
            {
                case Store.Api:
                    return this.getFromApi(start, limit);

                case Store.Sample:
                default:
                    return this.getFromSample();
            }
        }

        private async Task<string> getFromApi(int start, int limit)
        {
            var client = _clientFactory.CreateClient("rescuegroups");

            var filters = new Requests.Animals.PublicSearch.Filter[]
            {
                new Requests.Animals.PublicSearch.Filter
                {
                    fieldName = "animalStatus",
                    operation = "equal",
                    criteria = "Available",
                },
            };
            var fields = new string[] {
                "animalAdoptionFee",
                "animalAgeString",
                "animalAvailableDate",
                "animalBirthDate",
                "animalBreed",
                "animalDescription",
                "animalDescriptionPlain",
                "animalFoundDate",
                "animalLocation",
                "animalLocationCitystate",
                "animalName",
                "animalPictures",
                "animalPrimaryBreed",
                "animalSpecies",
                "animalSummary",
                "animalUrl",
                "animalVideos",
                "animalVideoUrls",
                "locationUrl",
                "locationPostalcode",
            };
            var payload = new RescueGroups.Requests.Animals.PublicSearch
            {
                apikey = Environment.GetEnvironmentVariable("RESCUE_GROUPS_API_KEY"),
                search = new RescueGroups.Requests.Animals.PublicSearch.SearchOptions
                {
                    resultStart = start,
                    resultLimit = limit,
                    resultSort = "animalID",
                    resultOrder = "asc",
                    calcFoundRows = "Yes",
                    filters = filters,
                    fields = fields,
                },
            };

            var payloadJson = JsonSerializer.Serialize(payload);
            var payloadString = new StringContent(payloadJson, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("/http/v2.json", payloadString);
            var responseBody = await response.Content.ReadAsStringAsync();

            return responseBody;
        }

        private async Task<string> getFromSample()
        {
            var json = await File.ReadAllTextAsync("Data/RescueGroups/Sample/animal-listings.json");

            return json;
        }
    }
}
