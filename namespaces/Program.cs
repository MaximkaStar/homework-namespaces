using People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTarget();
            SecondTarget();
            ReadLine();
        }
        public static void FirstTarget()
        {
            Unique people = new Unique();
            string infoPeople = People.Unique.GetPeopleInfo(people);
            WriteLine(people);
        }
        public static void SecondTarget()
        {
            WriteLine("Name: - {0} Surname - {1}, National - {2}", StaticMethods.name, StaticMethods.surname, StaticMethods.national);
        }
    }
}
