namespace CV_System_API_New.DTO.EducationDTOs
{
    public class EducationDataDTO
    {
        public string EducationalInstitution { get; set; }
        public string Specialization { get; set; }
        public virtual YearRangeDTO YearRange { get; set; }
        public virtual EducationDTO Education { get; set; }
    }
}
