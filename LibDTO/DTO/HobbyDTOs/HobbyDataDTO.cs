namespace LibDTO.DTO.HobbyDTOs
{
    public class HobbyDataDTO
    {
        public string HobbyName { get; set; }
        public virtual HobbyDTO Hobby { get; set; }
    }
}
