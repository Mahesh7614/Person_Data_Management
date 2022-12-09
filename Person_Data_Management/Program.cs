namespace Person_Data_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            PersonRepository.AddRecords(listPersonsInCity);
        }
    }
}