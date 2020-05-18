namespace CV_System_API_New.DTO
{
    public class ErrorViewModelDTO
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
