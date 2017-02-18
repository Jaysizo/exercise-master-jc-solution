using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApi1.Data;
using TestApi1.Models.BusinessObjects;
using TestApi1.Services.Abstract;

namespace TestApi1.Services.Concrete
{
    public class PersonService : IPersonService
    {
        IEnumerable<Person>  _personList;
        public PersonService()
        {
            _personList = DataSeeder.Persons;
        }
        public IEnumerable<Person> GetAll()
        {
            return _personList;  // _personList.Take(2).ToList();
        }

        public Person GetById (int personId)
        {
            Person personToRetrieve = new Person();
            if (personId <= 0)
                return null;
            else
            {
                var person = GetAll().Where(p => p.PersonId == personId)
                                     .SingleOrDefault();
                return person;
            }
        }

        public IEnumerable<Person> GetByName (string name)
        {
            if (string.IsNullOrEmpty(name))
                return null;
            else
            {
                var persons = GetAll().Where(p => p.FirstName != null && p.FirstName.ToLower() == name.ToLower()
                                                || p.LastName != null && p.LastName.ToLower() == name.ToLower());
                return persons;
                                    
            } 
        }

        public Person Update(Person person)
        {
            if (person != null && person.PersonId > 0)
            {
                var item = GetById(person.PersonId);
                if (item == null) return null;
                else
                {
                    //Update the value based on person object passed, then persist the value with a SAVE in data store.
                    item.FirstName = person.FirstName;
                    item.LastName = person.LastName;
                    item.JobTitle = person.JobTitle;
                    return item;
                }
            }
            else
                return null;
        }
    }
}