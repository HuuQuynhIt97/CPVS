using System;

namespace CPVS_API.DTO
{
    public class UserForDetailDto
    {
        public string ID { get; set; }
        public string Username { get; set; }
        public string email { get; set; }
        public int RoleID { get; set; }
        public string CreatedDate { get; set; }
    }
}