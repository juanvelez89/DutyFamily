using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Dto
{
    /// <summary>
    /// Estructura de datos de las entidades familia.
    /// </summary>
    public class FamilyDto
    {
        public long IdFamily { get; set; }
        public string FamilyName { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
    }
}