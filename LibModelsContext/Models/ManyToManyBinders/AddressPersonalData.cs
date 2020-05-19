namespace LibModelsContext.Models.ManyToManyBinders
{
    public class AddressPersonalData
    {
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public int PersonalDataId { get; set; }
        public virtual PersonalData PersonalData { get; set; }
    }
}
