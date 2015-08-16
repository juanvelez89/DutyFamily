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
    public class UsersController : ApiController
    {
        [HttpPost]
        public ResponseDto<UserDTO> CreateUser(UserDTO newUser) {
            var response = new ResponseDto<UserDTO>();
            try
            {
                if (!UserModel.ExistUser(newUser.Email))
                {
                    response.Data = UserModel.CreateUser(newUser);
                    response.header.Message = ResponseMessages.SuccessMessage.Message;
                    response.header.Code = ResponseMessages.SuccessMessage.Code;
                }
                else
                {
                    response.header.Message = ResponseMessages.RepeatedRegister.Message;
                    response.header.Code = ResponseMessages.RepeatedRegister.Code;
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