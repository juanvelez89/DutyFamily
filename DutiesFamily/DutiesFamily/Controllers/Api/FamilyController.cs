using DutiesFamily.Dto;
using DutiesFamily.Messages;
using DutiesFamily.Models.ModelsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DutiesFamily.Controllers.Api
{
    public class FamilyController : ApiController
    {
        // POST api/<controller>
        [HttpPost]
        public ResponseDto<FamilyDto> Login(FamilyDto family)
        {

            ResponseDto<FamilyDto> response = new ResponseDto<FamilyDto>();
            FamilyModel familyModel = new FamilyModel();
            if(familyModel.ExistFamily(family.FamilyName)!=null)
            {
                if (familyModel.ValidateFamily(family.FamilyName, family.Password) != null)
                {
                    response.header.Message = ResponseMessages.SuccessMessage.Message;
                    response.header.Code = ResponseMessages.SuccessMessage.Code;
                    response.Data = familyModel.ValidateFamily(family.FamilyName, family.Password);
                }
                else
                {
                    response.header.Message = ResponseMessages.InvalidUser.Message;
                    response.header.Code = ResponseMessages.InvalidUser.Code;
                }
            }
            else
            {
                response.header.Message = ResponseMessages.NotFoundRegister.Message;
                response.header.Code = ResponseMessages.NotFoundRegister.Code;
            }

            return response;
        }


        // POST api/<controller>
        [HttpPost]
        public ResponseDto<FamilyDto> RegisterFamily(FamilyDto family)
        {
            ResponseDto<FamilyDto> response = new ResponseDto<FamilyDto>();
            FamilyModel familyModel = new FamilyModel();
            if(familyModel.ExistFamily(family.FamilyName)==null)
            {
                response.Data = familyModel.RegisterFamily(family);
                response.header.Message = ResponseMessages.SuccessMessage.Message;
                response.header.Code = ResponseMessages.SuccessMessage.Code;
            }
            else
            {
                response.header.Message = ResponseMessages.RepeatedRegister.Message;
                response.header.Code = ResponseMessages.RepeatedRegister.Code;
            }

            return response;
        }


    }
}