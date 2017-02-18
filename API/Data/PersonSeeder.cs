using System.Collections.Generic;
using TestApi1.Models.BusinessObjects;

namespace TestApi1.Data
{
    public  static class DataSeeder
    {
        public static void SeedPerson(ref List<Person> personData)
        {
            if (personData == null) personData = new List<Person>();
            personData.Add(new Person { PersonId = 1,FirstName = "Darryl",LastName = "Johnson", JobTitle = "Teacher"});
            personData.Add(new Person { PersonId = 2, FirstName = "James", LastName = "Hobart", JobTitle = "IT Specialist" });
            personData.Add(new Person { PersonId = 3, FirstName = "Anita", LastName = "Davids", JobTitle = "Marketing Analyst" });
            personData.Add(new Person { PersonId = 4, FirstName = "Megane", LastName = "Normand", JobTitle = "Teacher" });
            personData.Add(new Person { PersonId = 5, FirstName = "Jonny", LastName = "Greg", JobTitle = "Database Analyst" });
            personData.Add(new Person { PersonId = 6, FirstName = "Bernie", LastName = "Reynolds", JobTitle = "Journalist" });
            personData.Add(new Person { PersonId = 7, FirstName = "Rama", LastName = "Nayima", JobTitle = "Childcare Specialist" });
            personData.Add(new Person { PersonId = 8, FirstName = "Jose", LastName = "Carvallo", JobTitle = "Financial Analyst" });
            personData.Add(new Person { PersonId = 10, FirstName = "Mary", LastName = "Johnson", JobTitle = "Software Engineer" });
            personData.Add(new Person { PersonId = 11, FirstName = "Ryan", LastName = "Smith", JobTitle = "Journalist" });
            personData.Add(new Person { PersonId = 12, FirstName = "Darryl", LastName = "Normand", JobTitle = "Nurse" });
            personData.Add(new Person { PersonId = 13, FirstName = "Lamine", LastName = "Ndiaye", JobTitle = "Attorney" });
            personData.Add(new Person { PersonId = 14, FirstName = "John", LastName = "Natenssen", JobTitle = "Building Engineer" });
            personData.Add(new Person { PersonId = 15, FirstName = "Solange", LastName = "Kane", JobTitle = "IT Specialist" });
        }

        public static List<Person> Persons;
    }
}