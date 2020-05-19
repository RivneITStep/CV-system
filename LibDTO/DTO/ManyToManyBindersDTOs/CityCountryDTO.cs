namespace LibDTO.DTO.ManyToManyBindersDTOs
{
    public class CityCountryDTO
    {
        public virtual CityDTO City { get; set; }
        public virtual CountryDTO Country { get; set; }
    }
}
