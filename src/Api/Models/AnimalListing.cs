using System;
using System.Linq;
using System.Collections.Generic;
using PetAdoptions.Api.Data.RescueGroups.Objects;
using AutoMapper;

namespace PetAdoptions.Api.Models.AnimalListing
{
    public class AnimalListing
    {
        public string AdoptionFee { get; set; }
        public string AgeString { get; set; }
        public DateTime? AvailableDate { get; set; }
        public DateTime BirthDate { get; set; }
        public string Breed { get; set; }
        public string Description => DescriptionPlain.Replace("&nbsp;", " ");
        public string DescriptionPlain { get; set; }
        public string DescriptionHtml { get; set; }
        public string Name { get; set; }
        public Picture[] Pictures { get; set; }
        public string[] PictureUrls => Pictures.Select(picture => picture.urlSecureFullsize).ToArray();
        public string RescueGroupsId { get; set; }
        public string Species { get; set; }
        public string Url { get; set; }

        private static MapperConfiguration RescueGroupsMapperConfig = new MapperConfiguration(config =>
        {
          config.ReplaceMemberName("animalAdoptionFee", "AdoptionFee");
          config.ReplaceMemberName("animalAgeString", "AgeString");
          config.ReplaceMemberName("animalAvailableDate", "AvailableDate");
          config.ReplaceMemberName("animalBirthDate", "BirthDate");
          config.ReplaceMemberName("animalBreed", "Breed");
          config.ReplaceMemberName("animalDescriptionPlain", "DescriptionPlain");
          config.ReplaceMemberName("animalDescriptionHtml", "DescriptionHtml");
          config.ReplaceMemberName("animalName", "Name");
          config.ReplaceMemberName("animalId", "RescueGroupsId");
          config.ReplaceMemberName("animalPictures", "Pictures");
          config.ReplaceMemberName("animalSpecies", "Species");
          config.ReplaceMemberName("animalUrl", "Url");
          config.CreateMap<Animal, AnimalListing>();
        });
        private static Mapper RescueGroupsMapper = new Mapper(RescueGroupsMapperConfig);

        public static AnimalListing fromRescueGroups(Animal animal)
        {
            return RescueGroupsMapper.Map<AnimalListing>(animal);
        }

        public static IEnumerable<AnimalListing> fromRescueGroups(IEnumerable<Animal> animals)
        {
            return RescueGroupsMapper.Map<IEnumerable<Animal>, IEnumerable<AnimalListing>>(animals);
        }
    }
}
