using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApi1.Models.BusinessObjects;

namespace TestApi1.Services.Abstract
{
    //Interface to be implemented to get and update data
    //It is usually built in a different layer but since the scope of this demoo is fairly small
    //We decided to leave it in the same project, but different folder (Services/Abstract) 

    public interface IPersonService
    {
        /// <summary>
        /// Returns a list of Persons 
        /// </summary>
        /// <returns>IEnumerable<Person></returns>
        IEnumerable<Person> GetAll();

        /// <summary>
        /// Returns a single person object given the personId
        /// </summary>
        /// <param name="personId"></param>
        /// <returns>Person</returns>
        Person GetById(int personId);

        /// <summary>
        /// Returns a list of persons given the name (either first or last name)
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Person</returns>
        IEnumerable<Person> GetByName (string name);

        /// <summary>
        /// Returns an integer which is the updated PersonId
        /// or 0 if update is not successful
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        Person Update(Person person);
    }
}
