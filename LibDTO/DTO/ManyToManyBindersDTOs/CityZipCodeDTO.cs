namespace LibDTO.DTO.ManyToManyBindersDTOs
{
    public class CityZipCodeDTO
    {
        public virtual CityDTO City { get; set; }
        public virtual ZipCodeDTO ZipCode { get; set; }
    }
}
