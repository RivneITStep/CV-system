namespace LibDTO.DTO
{
    public class CountryDTO
    {
        public string CountryName { get; set; }
        public virtual ZipCodeDTO ZipCode { get; set; }
    }
}
