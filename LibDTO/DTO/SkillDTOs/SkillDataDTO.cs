namespace LibDTO.DTO.SkillDTOs
{
    public class SkillDataDTO
    {
        public string SkillDataName { get; set; }
        public string SkillLevel { get; set; }
        public virtual SkillDTO Skill { get; set; }
    }
}
