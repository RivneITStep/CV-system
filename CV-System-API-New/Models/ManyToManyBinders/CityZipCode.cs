﻿namespace CV_System_API_New.Models.ManyToManyBinders
{
    public class CityZipCode
    {
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int ZipCodeId { get; set; }
        public virtual ZipCode ZipCode { get; set; }
    }
}
