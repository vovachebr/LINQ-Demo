using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    static class LinqExpressions
    {
        public static IEnumerable<string> UserNames(IEnumerable<Student> students)
        {
            return from student in students
                   select student.Name;
        }

        public static IEnumerable<string> NoAdultUserNames(IEnumerable<Student> students)
        {
            return from student in students
                    where student.Age < 18
                    select student.Name;
        }

        public static int AdultUsersCount(IEnumerable<Student> students)
        {
            return (from student in students
                    where student.Age >= 18
                    select student).Count();
        }

        public static IEnumerable<string> UserNamesStatredLetter(IEnumerable<Student> students, char firstLetter)
        {
            return (from student in students
                    where student.Name[0].Equals(firstLetter)
                    select student.Name);
        }
    }
}
