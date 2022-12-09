
using System;

namespace Person_Data_Management
{
    internal class PersonRepository
    {
        public static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "jhon", "12 Main strret new york NY", 15));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main ct new york NY", 25));
            listPersonInCity.Add(new Person("203456878", "Elon", "14 Main strret new york NY", 35));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main strret new york NY", 45));
            listPersonInCity.Add(new Person("203456880", "SAM", "345 Main Ave Dayton OH", 55));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 CranBrook road new york NY", 65));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st new york NY", 65));
            listPersonInCity.Add(new Person("203456883", "Mac", "126 Province Ave Baltimore NY", 85));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave Baltimore NY", 95));
        }
        public static void Retriving_Top_Two_Records_For_Age_LessThan_Sixty(List<Person> listPersonInCity)
        {
            foreach (Person person in listPersonInCity.FindAll(e => e.Age < 60).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge : " + person.Age);
            }
        }
    }
}
