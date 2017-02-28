using System;
using System.Text;
using TestApi1.Models.BusinessObjects;
using System.Diagnostics;

namespace TestApi1.Helpers
{
    public static class ConsoleHelper
    {       
        public static void LogToConsole (Person updatedPerson)
        {          
            if(updatedPerson != null)
            {
                StringBuilder messageBuilder = new StringBuilder("The updated Person object has the following values: ");
                messageBuilder.Append(Environment.NewLine);
                messageBuilder.Append("Person Id: ").Append(updatedPerson.PersonId).Append(Environment.NewLine);
                messageBuilder.Append("First Name: ").Append(updatedPerson.FirstName).Append(Environment.NewLine);
                messageBuilder.Append("Last Name: ").Append(updatedPerson.LastName).Append(Environment.NewLine);
                messageBuilder.Append("Job Title: ").Append(updatedPerson.JobTitle).Append(Environment.NewLine);
                Debug.WriteLine(messageBuilder.ToString());
            }
        }
    }
}