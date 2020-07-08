using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    static class LinqChain
    {
        public static IEnumerable<string> UserNames(IEnumerable<Student> students)
        {
            return students.Select((s) => s.Name);
        }

        public static IEnumerable<string> NoAdultUserNames(IEnumerable<Student> students)
        {
            return students.Where(s => s.Age < 18).Select((s) => s.Name);
        }

        public static int AdultUsersCount(IEnumerable<Student> students)
        {
            return (students.Where(s => s.Age >= 18).Count());
        }

        public static IEnumerable<string> UserNamesStatredLetter(IEnumerable<Student> students, char firstLetter)
        {
            return students.Where(s => s.Name[0].Equals(firstLetter)).Select((s) => s.Name);
        }
    }
}
