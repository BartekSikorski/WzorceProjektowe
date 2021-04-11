using System;

namespace WzorceProjektowe.Strukturalne.Facade.I
{
    public class Client
    {
        public static void Execute()
        {
            var person = new Person() { FirstName = "Jan", LastName = "Kowalski", BirthDate = DateTime.Now.AddYears(-40) };
            Console.WriteLine(JsonConvertFacade.Serialize(person));
        }
    }
}