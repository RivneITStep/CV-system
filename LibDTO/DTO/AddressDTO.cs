namespace LibDTO.DTO
{
    public class AddressDTO
    {
        public string Street { get; set; }
        public int? HouseNumber { get; set; }
        public virtual CityDTO City { get; set; }
        public virtual ZipCodeDTO ZipCode { get; set; }
    }
}
