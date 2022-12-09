
namespace Person_Data_Management
{
    internal class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;

        public Person(string ssn, string name, string address, int age)
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
