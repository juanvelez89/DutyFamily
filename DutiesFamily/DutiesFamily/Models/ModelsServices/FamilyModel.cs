using DutiesFamily.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Models.ModelsServices
{
    public class FamilyModel
    {
        /// <summary>
        /// Método para validar que la familia exista.
        /// </summary>
        /// <param name="FamilyName"></param>
        /// <returns></returns>
        public FamilyDto ValidateFamily(string FamilyName, string password)
        {
            var family = new FamilyDto();
            using (DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                if (dataContext.Family.Count(x => x.FamilyName.Trim().Equals(FamilyName.Trim()) && x.Password.Equals(password)) > 0)
                {
                    var familyQuery = dataContext.Family
                        .FirstOrDefault(x => x.FamilyName.Trim().Equals(FamilyName.Trim()) && x.Password.Equals(password));
                    family.FamilyName = familyQuery.FamilyName;
                    family.Image = familyQuery.Image;
                    family.IdFamily = familyQuery.IdFamily;
                }
                else
                    family = null;
            }
            return family;
        }

        /// <summary>
        /// Método para verificar que la familia este registrada.
        /// </summary>
        /// <param name="familyName"></param>
        /// <returns></returns>
        public FamilyDto ExistFamily(string familyName)
        {
            var family = new FamilyDto();
            using (DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                if (dataContext.Family.Count(x => x.FamilyName.Trim().Equals(familyName.Trim())) > 0)
                {
                    var familyQuery = dataContext.Family
                        .FirstOrDefault(x => x.FamilyName.Trim().Equals(familyName.Trim()));
                    family.FamilyName = familyQuery.FamilyName;
                    family.Image = familyQuery.Image;
                    family.IdFamily = familyQuery.IdFamily;
                }
                else
                    family = null;
            }

            return family;
        }
 
        /// <summary>
        /// Método para registrar familia.
        /// </summary>
        /// <param name="family"></param>
        /// <returns></returns>
        public FamilyDto RegisterFamily(FamilyDto family)
        {
            using(DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                var familyCreated = new Family();
                familyCreated.FamilyName = family.FamilyName;
                familyCreated.Image = family.Image;
                familyCreated.Password = family.Password;
                dataContext.Family.Add(familyCreated);
                dataContext.SaveChanges();
                family.IdFamily = familyCreated.IdFamily;
            }
            return family;
        }
    }
}