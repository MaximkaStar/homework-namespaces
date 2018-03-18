using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class StaticMethods
    {
        public static string GetPeopleInfo(Unique people)
        {
            string infoPeople = "Name: " + people.GetName() + "Surname: " + people.GetSurname() + "National: " + people.GetNational();
            return infoPeople;
        }
    }
}
