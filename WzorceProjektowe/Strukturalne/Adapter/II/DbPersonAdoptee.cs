using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzorceProjektowe.Strukturalne.Adapter.II
{
    public static class DbPersonAdoptee
    {
        public static Person ToPerson(DbPerson dbPerson)
        {
            return new Person { Name = dbPerson.FirstName + " " + dbPerson.FirstName, Age = DateTime.Now.Year - dbPerson.BirthDate.Year };
        }
    }
}
