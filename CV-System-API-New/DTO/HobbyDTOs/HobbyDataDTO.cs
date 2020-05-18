namespace CV_System_API_New.DTO.HobbyDTOs
{
    public class HobbyDataDTO
    {
        public string HobbyName { get; set; }
        public virtual HobbyDTO Hobby { get; set; }
    }
}
