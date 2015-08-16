using DutiesFamily.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Models.ModelsServices
{
    public class RolModel
    {
        /// <summary>
        /// Método para crear un nuevo Rol
        /// </summary>
        /// <param name="newRol"></param>
        /// <returns></returns>
        public static RolDto CreateRol(RolDto newRol)
        {
            return newRol;
        }

        /// <summary>
        /// Método para consultar un nuevo Rol
        /// </summary>
        /// <returns></returns>
        public static List<RolDto> GetRoles()
        {
            var roles = new List<RolDto>();
            using (DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                foreach (var item in dataContext.Rol.ToList())
                {
                    var rol = new RolDto();
                    rol.IdRol = item.IdRol;
                    rol.RolName = item.RolName;
                    roles.Add(rol);
                }
            }
            return roles;
        }
    }
}