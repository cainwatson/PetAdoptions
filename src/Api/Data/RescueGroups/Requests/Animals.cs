
namespace PetAdoptions.Api.Data.RescueGroups.Requests.Animals
{
    public class PublicSearch
    {
        public class Filter {
            public string fieldName { get; set; }
            public string operation { get; set; }
            public string criteria { get; set; }
        }

        public class SearchOptions {
            public int resultStart { get; set; }
            public int resultLimit { get; set; }
            public string resultSort { get; set; }
            public string resultOrder { get; set; }
            public string calcFoundRows { get; set; }
            public Filter[] filters { get; set; }
            public string[] fields { get; set; }
        }

        public string apikey { get; set; }
        public string objectType
        {
            get
            {
                return "animals";
            }
        }
        public string objectAction
        {
            get
            {
                return "publicSearch";
            }
        }
        public SearchOptions search { get; set; }
    }
}
