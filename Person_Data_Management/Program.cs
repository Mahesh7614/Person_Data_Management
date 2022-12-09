namespace Person_Data_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            PersonRepository.AddRecords(listPersonsInCity);
            PersonRepository.Retriving_Top_Two_Records_For_Age_LessThan_Sixty(listPersonsInCity);
            PersonRepository.CheckingForTeenagerPersons(listPersonsInCity);
            PersonRepository.Retrive_Average_Age(listPersonsInCity);
        }
    }
}