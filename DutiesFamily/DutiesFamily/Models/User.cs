//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DutiesFamily.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public long IdUser { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public long IdFamily { get; set; }
        public int IdRol { get; set; }
    
        public virtual Family Family { get; set; }
        public virtual Rol Rol { get; set; }
    }
}