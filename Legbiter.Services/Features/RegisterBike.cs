using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legbiter.Services.Features
{
    public class RegisterBike
    {
        public class Request
        {
            public string FrameNumber { get; set; }
        }
        public class Response
        {
            public Guid Id { get; set; }
        }

    }
}
