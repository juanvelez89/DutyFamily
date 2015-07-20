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
                var user = new User();
                user.Email = newUser.Email;
                user.IdFamily = newUser.IdFamily;
                user.IdRol = newUser.IdRol;
                user.Image = newUser.Image;
                user.UserName = newUser.UserName;
                dataContext.User.Add(user);
                dataContext.SaveChanges();

            }

            return newUser;
        }
    }
}