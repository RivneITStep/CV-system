﻿namespace CV_System_API_New.DTO.ManyToManyBindersDTOs
{
    public class AddressPersonalDataDTO
    {
        public virtual AddressDTO Address { get; set; }
        public virtual PersonalDataDTO PersonalData { get; set; }
    }
}
