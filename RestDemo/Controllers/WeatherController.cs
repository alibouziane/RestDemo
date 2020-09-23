using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestDemo.Models;

namespace RestDemo.Controllers
{
    public class WeatherController : ApiController
    {
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInfos = new List<WeatherInfo>();
            for (var i = 0; i < 10; i++)
            {
                weatherInfos.Add(new WeatherInfo()
                {
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.UtcNow
                });
            }
            return weatherInfos;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo()
            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.UtcNow
            };
        }

        //    // POST: api/Weather
        //    public void Post([FromBody]string value)
        //    {
        //    }

        //    // PUT: api/Weather/5
        //    public void Put(int id, [FromBody]string value)
        //    {
        //    }

        //    // DELETE: api/Weather/5
        //    public void Delete(int id)
        //    {
        //    }
    }
}
