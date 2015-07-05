using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DutiesFamily.Dto
{
    public class ResponseDto <T> where T: new()
    {
        public class Header {
            public int Code { get; set; }
            public string Message { get; set; }
        }

        private Header _header;
        public Header header {
            get
            {
                if(_header == null)
                {
                    _header  = new Header();

                }
                return _header;
            }

            set
            {
                _header = value;
            }
        }
        public T Data { get; set; }
    }
}