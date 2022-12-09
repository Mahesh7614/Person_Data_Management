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
            PersonRepository.CheckFor_Name_Present_InList_Or_Not(listPersonsInCity, "Smith");
            PersonRepository.Retrive_Records_For_Age_GreaterThan_Sixty(listPersonsInCity);
        }
    }
}