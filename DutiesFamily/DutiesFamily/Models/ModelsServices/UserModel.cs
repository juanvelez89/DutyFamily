using DutiesFamily.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Models.ModelsServices
{
    public class UserModel
    {
     
        /// <summary>
        /// Método para crear nuevos usuarios.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static UserDTO CreateUser(UserDTO newUser)
        {
                            
            using(DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                if(dataContext.User.Count(x=>x.Email.Trim()==newUser.Email.Trim())==0)
                {
                    var user = new User();
                    user.Email = newUser.Email;
                    user.Family = dataContext.Family.FirstOrDefault(x => x.IdFamily == newUser.IdFamily);
                    user.IdFamily = newUser.IdFamily;
                    user.Rol = dataContext.Rol.FirstOrDefault(x => x.IdRol == newUser.IdRol);
                    user.IdRol = newUser.IdRol;
                    user.Image = newUser.Image;
                    user.Password = Guid.NewGuid().ToString().Split('-').FirstOrDefault();
                    user.UserName = newUser.UserName;
                    dataContext.User.Add(user);
                    dataContext.SaveChanges();
                    newUser.Password = user.Password;
                }
                else
                {
                    newUser = null;
                }

            }

            return newUser;
        }

        /// <summary>
        /// Método para validar la existencia de un usuario.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ExistUser(string email)
        {
            var response = false;
            using (DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                if (dataContext.User.Count(x => x.Email.Trim() == email.Trim()) > 0)
                {
                    response = true;
                }

            }
            return response;
        }


    }
}