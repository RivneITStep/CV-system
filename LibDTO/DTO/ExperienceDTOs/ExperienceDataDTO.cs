namespace LibDTO.DTO.ExperienceDTOs
{
    public class ExperienceDataDTO
    {
        public string PlaceName { get; set; }
        public virtual YearRangeDTO YearRange { get; set; }
        public virtual ExperienceDTO Experience { get; set; }
    }
}
