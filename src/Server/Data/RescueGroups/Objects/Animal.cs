using System;

namespace PetAdoptions.Server.Data.RescueGroups.Objects
{
    public class Animal
    {
        public string animalAdoptionFee { get; set; }
        public string animalAgeString { get; set; }
        public DateTime? animalAvailableDate { get; set; }
        public DateTime animalBirthDate { get; set; }
        public string animalBreed { get; set; }
        public string animalDescription { get; set; }
        public string animalDescriptionPlain { get; set; }
        public string animalName { get; set; }
        public string animalId { get; set; }
        public Picture[] animalPictures { get; set; }
        public string animalSpecies { get; set; }
        public string animalUrl { get; set; }

        public string Description => animalDescriptionPlain.Replace("&nbsp;", " ");
    }
}
