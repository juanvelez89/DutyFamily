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
    public class RolController : ApiController
    {
        [HttpGet]
        public ResponseDto<List<RolDto>> GetRol()
        {
            var response = new ResponseDto<List<RolDto>>();
            try
            {
                response.Data = RolModel.GetRoles();
                if (response.Data.Count > 0)
                {
                    response.header.Message = ResponseMessages.SuccessMessage.Message;
                    response.header.Code = ResponseMessages.SuccessMessage.Code;
                }
                else
                {
                    response.header.Message = ResponseMessages.NotFoundRegister.Message;
                    response.header.Code = ResponseMessages.NotFoundRegister.Code;
                }
            }
            catch
            {
                response.header.Message = ResponseMessages.ServerError.Message;
                response.header.Code = ResponseMessages.ServerError.Code;
            }

            return response;
        }
    }
}