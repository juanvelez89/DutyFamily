using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Dto
{
    public class UserDTO
    {
        public long IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public long IdFamily { get; set; }
        public int IdRol { get; set; }
    }
}