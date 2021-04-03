using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Adapter.II
{
    public class Client
    {

        public static void Execute()
        {
            Person person = new Person();
            person.Age = 5;
            person.Name = "Tadek Kowalski";

            DbPerson dbPerson = new DbPerson();
            dbPerson.FirstName = "Antoni";
            dbPerson.LastName = "Bowak";
            dbPerson.BirthDate = new DateTime(1999, 1, 1);

            Console.WriteLine(ClientInfo(person));

            Console.WriteLine(ClientInfo(new PersonAdapter(dbPerson)));

            Console.WriteLine(ClientInfo(DbPersonAdoptee.ToPerson(dbPerson)));

            Console.WriteLine(ClientInfo(dbPerson.AdoptToPerson()));



        }

        public static string ClientInfo(IPerson person)
        {
            return $"{person.Name}, wiek {person.Age}";
        }
    }
}
