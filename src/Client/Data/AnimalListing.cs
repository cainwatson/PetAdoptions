using System;

namespace PetAdoptions.Client.Data
{
    public class AnimalListing
    {
        public string AdoptionFee { get; set; }
        public string AgeString { get; set; }
        public DateTime BirthDate { get; set; }
        public string Breed { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string[] PictureUrls { get; set; }
        public string Species { get; set; }
    }
}
