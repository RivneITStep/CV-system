namespace CV_System_API_New.Models.ManyToManyBinders
{
    public class CityCountry
    {
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
