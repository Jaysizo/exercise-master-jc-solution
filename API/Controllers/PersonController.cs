using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestApi1.Models.BusinessObjects;
using TestApi1.Services.Abstract;
using TestApi1.Services.Concrete;

namespace TestApi1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    public class PersonController : ApiController
    {
        IPersonService _personService;

        public PersonController()
        {
            // Instantiating in the controller but would use an DI/IoC container like Ninject 
            // to handle dependency injection 


            _personService = new PersonService(); 
        }


        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            var persons = _personService.GetAll()
                                        .ToList();
            return persons;
        }

        // GET: api/Person/5
        public HttpResponseMessage GetPersonById (int personid)
        {
            var person = _personService.GetById(personid);
            if (person == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            return Request.CreateResponse(HttpStatusCode.OK, person);
        }

        // POST: api/Person
        public HttpResponseMessage Post([FromBody]Person person)
        {
            try
            {
                if (person != null && ModelState.IsValid)
                {
                    if (person.PersonId > 0)
                    {
                        var updatedPerson = _personService.Update(person);
                        if (updatedPerson == null) return Request.CreateResponse(HttpStatusCode.NotFound);
                        return Request.CreateResponse(HttpStatusCode.OK, updatedPerson);
                    }
                }
            }
            catch (Exception)
            {
                //Log Exception or have an actionable item here
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest);
        }
    }
}