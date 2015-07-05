using DutiesFamily.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Models.ModelsServices
{
    public class DutyModel
    {
        /// <summary>
        /// Método para consultar las tareas creadas por la familia.
        /// </summary>
        /// <param name="idFamily"></param>
        /// <returns></returns>
        public List<DutyDto> GetDutiesFamily(int idFamily)
        {
            var duties = new List<DutyDto>();
            using (DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                foreach (var item in dataContext.Duty.Where(x=>x.IdFamily==idFamily).ToList())
                {
                    var duty = new DutyDto();
                    duty.IdDuty = item.IdDuty;
                    duty.IdFamily = item.IdFamily;
                    duty.DutyName = item.DutyName;
                    duties.Add(duty);
                }
            }
            return duties;
        }

        /// <summary>
        /// Método para crear tareas asignadas a la familia.
        /// </summary>
        /// <param name="duty"></param>
        /// <returns></returns>
        public DutyDto CreateDuty(DutyDto duty)
        {
            using (DutiesFamilyEntities dataContext = new DutiesFamilyEntities())
            {
                var dutyCreated = new Duty();
                dutyCreated.DutyName = duty.DutyName;
                dutyCreated.IdFamily = duty.IdFamily;
                dataContext.Duty.Add(dutyCreated);
                dataContext.SaveChanges();
            }
            return duty;
        }

    }
}