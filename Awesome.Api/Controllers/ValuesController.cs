using Awesome.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Awesome.Api.Controllers
{   
    public class ValuesController : ApiController
    {
        ValuesContext context = new ValuesContext();

        // GET api/values
        public IEnumerable<Value> Get()
        {
            return context.Values.ToList();
        }

        // GET api/values/5

        public IHttpActionResult Get(Guid id)
        {

            bool isFound = context.Values.Any(v => v.Id == id);
            if (isFound)
            {
                return Ok(context.Values.Single(v => v.Id == id));
            }

            return NotFound();
        }

        // POST api/values
        public void Post([FromBody]Value value)
        {
            context.Values.Add(value);
            context.SaveChanges();
        }

        // PUT api/values/5
        public void Put(Guid id, [FromBody]Value value)
        {
            Value found = context.Values.Single(v => v.Id == id);
            found.Name = value.Name;
            context.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(Guid id)
        {
            Value found = context.Values.Single(v => v.Id == id);
            context.Values.Remove(found);
            context.SaveChanges();
        }
    }
}
