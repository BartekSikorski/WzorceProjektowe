using System;

namespace WzorceProjektowe.Strukturalne.Adapter.II
{
    public class PersonAdapter : IPerson
    {
        private DbPerson dbPerson;

        public PersonAdapter(DbPerson dbPerson)
        {
            this.dbPerson = dbPerson;
        }

        public string Name { get => $"{dbPerson.FirstName} {dbPerson.LastName}"; set => throw new System.NotImplementedException(); }
        public int Age { get => DateTime.Now.Year - dbPerson.BirthDate.Year; set => throw new System.NotImplementedException(); }
    }
}