﻿namespace CV_System_API_New.DTO
{
    public class LoginDataDTO
    {
        public int CVSystemUserId { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; }
        public virtual CVSystemUserDTO CVSystemUser { get; set; }
    }
}
