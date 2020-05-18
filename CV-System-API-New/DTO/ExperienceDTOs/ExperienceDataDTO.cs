namespace CV_System_API_New.DTO.ExperienceDTOs
{
    public class ExperienceDataDTO
    {
        public string PlaceName { get; set; }
        public virtual YearRangeDTO YearRange { get; set; }
        public virtual ExperienceDTO Experience { get; set; }
    }
}
