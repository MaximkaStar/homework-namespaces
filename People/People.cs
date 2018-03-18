using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class Unique
    {
        private string name;
        private string surname;
        private string national;

        public Unique()
        {
            name = "Aiden";
            surname = "Pearse";
            national = "American";
        }

        public string GetName()
        {
            return name;
        }
        public static string GetPeopleInfo(Unique people)
        {
            throw new NotImplementedException();
        }
        public string GetSurname()
        {
            return surname;
        }
        public string GetNational()
        {
            return national;
        }
    }
}
