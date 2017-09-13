using Legbiter.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legbiter.Services.Features
{
    public class QueryBikes
    {
        public class Request
        {
            public string Registration { get; set; }
            public string FrameNumber { get; set; }
            public string Saddle { get; set; }
            public string Brakes { get; set; }
            public string Color { get; set; }
            public string Shifter { get; set; }
            public StatusEnum Status { get; set; }
        }
        public class Response
        {
            public IEnumerable<Item> Items { get; set; } = Enumerable.Empty<Item>();
            public class Item
            {
                public string Registration { get; set; }
                public string FrameNumber { get; set; }
                public string Saddle { get; set; }
                public string Brakes { get; set; }
                public string Color { get; set; }
                public string Shifter { get; set; }
                public StatusEnum Status { get; set; }
            }
        }
    }
}
