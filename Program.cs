using System;
using System.Security.Cryptography.X509Certificates;

namespace LambdaExpressionDemo
{
    class program
    {
        private static readonly List<Person> listPersonsInCity;

        static void Main(string[] args)
        {
            // UC 1:create list and insert record;
            List<Person> list = new List<Person>();
            AddRecords(listPersonsInCity);
        }
        // uc 1
        private static void AddRecords(List<Person> listPersonsInCity)
        {
            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAm", "13 Main Street, Newyork, Ny", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, DN", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Wiston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltinore, NY", 85));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltinore, NY", 95));
            foreach (Person person in listPersonsInCity)
            {
                Console.WriteLine("SSN : {0} Name : {1} Address : {2} Age : {3} ", person.SSN, person.Name, person.Address, person.Age);
            }
        }
        // uc2
        private static void Retrieving_TopTwoRecord_ForAgeIs_LessThenSixty(List<Person> listPersonsInCity)
        {
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name :" + person.Name + "\t\tAge:" + person.Age);
            }
        }
        // uc 3
        private static void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            if (listPersonsInCity.Any(e => (e.Age >= 13 && e.Age < 19)))
            {
                Console.WriteLine("Yes , We have some teen-agers in the list");
            }
        }
        // uc4
        private static void CheckingForAverageAge(List<Person> listPersonsIncity)
        {
            if (listPersonsInCity.Average(e => (e.Age +=( e.Age))/2 ) > 0)
            {
                Console.WriteLine("Average age");
            }
        }
    }
}

       