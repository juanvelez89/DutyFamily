using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Dto
{
    /// <summary>
    /// Estructura de datos de la entidad de tareas.
    /// </summary>
    public class DutyDto
    {
        public long IdDuty { get; set; }
        public string DutyName { get; set; }
        public long IdFamily { get; set; }
    }
}