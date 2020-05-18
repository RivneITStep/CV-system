namespace CV_System_API_New.DTO.CommunicationDTOs
{
    public class CommunicationDataDTO
    {
        public string CommunicationDataName { get; set; }
        public string CommunicationDataContent { get; set; }
        public virtual CommunicationDTO Communication { get; set; }
    }
}
