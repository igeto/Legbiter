using Dapper;
using Legbiter.Core.Models;
using Legbiter.Services.Features;
using Marten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Legbiter.Web.Api
{
    [RoutePrefix("api/bike")]
    public class BikeController : ApiController
    {
        static IDocumentStore store = DocumentStore.For(x =>
        {
            x.Connection("database=legbiter;host=localhost;port=5432;user id=postgres;password=postgrespass;");
        });
        [HttpPost]
        [Route("")]
        public Task<RegisterBike.Response> PostBike([FromBody] RegisterBike.Request request)
        {
            Guid id;
            using (var session = store.OpenSession())
            {
                var bike = Bike.Create(request.FrameNumber);
                session.Store(bike);
                id = bike.Id;
                session.SaveChanges();
            }
            return Task.FromResult(new RegisterBike.Response() { Id = id });
        }

        [HttpGet]
        [Route("")]
        public async Task<QueryBikes.Response> GetBikes()
        {
            var response = new QueryBikes.Response();
            using (var session = store.OpenSession())
            {
                response.Items = session.Query<Bike>()
                    .Select(x => new QueryBikes.Response.Item()
                    {
                        Registration = x.Registration,
                        Brakes = x.Brakes,
                        Color = x.Color,
                        FrameNumber = x.FrameNumber,
                        Saddle = x.Saddle,
                        Shifter = x.Shifter,
                        Status = x.Status
                    })
                .ToList();
                return response;
            }
        }
    }
}
