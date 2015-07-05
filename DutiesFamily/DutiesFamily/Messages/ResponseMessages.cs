using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Messages
{
    public class ResponseMessages
    {
        /// <summary>
        /// clase para mensaje exitoso.
        /// </summary>
        public static class SuccessMessage
        {
            public static string Message
            {
                get
                {
                    return  "Respuesta exitosa";
                }
            }

            public static int Code
            {
                get
                {
                    return 200;
                }
            }
        }

        /// <summary>
        /// clase para mensaje de registro debe ser único.
        /// </summary>
        public static class RepeatedRegister
        {
            public static string Message
            {
                get
                {
                    return "Ya fue encontrada la información";
                }
            }

            public static int Code
            {
                get
                {
                    return 409;
                }
            }
        }

        /// <summary>
        /// clase para registro no encontrado
        /// </summary>
        public static class NotFoundRegister
        {
            public static string Message
            {
                get
                {
                    return "No se encuentra la información";
                }
            }

            public static int Code
            {
                get
                {
                    return 404;
                }
            }
        }

        /// <summary>
        /// clase para usuario o contraseña invalida.
        /// </summary>
        public static class InvalidUser
        {
            public static string Message
            {
                get
                {
                    return "Contraseña invalida";
                }
            }

            public static int Code
            {
                get
                {
                    return 405;
                }
            }
        }
    }
}