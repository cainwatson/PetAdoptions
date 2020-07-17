using System;

namespace PetAdoptions.Server.Data.RescueGroups.Objects
{
    public class Image
    {
        public string type { get; set; }
        public string fileSize { get; set; }
        public string resolutionX { get; set; }
        public string resolutionY { get; set; }
        public string url { get; set; }
    }

    public class Picture
    {
        public string mediaID { get; set; }
        public string mediaOrder { get; set; }
        public DateTime lastUpdated { get; set; }
        public string fileSize { get; set; }
        public string resolutionX { get; set; }
        public string resolutionY { get; set; }
        public string fileNameFullsize { get; set; }
        public string fileNameThumbnail { get; set; }
        public string urlSecureFullsize { get; set; }
        public string urlSecureThumbnail { get; set; }
        public string urlInsecureFullsize { get; set; }
        public string urlInsecureThumbnail { get; set; }
        public Image original { get; set; }
        public Image large { get; set; }
        public Image small { get; set; }
    }
}
