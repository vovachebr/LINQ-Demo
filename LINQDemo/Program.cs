using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        static List<Student> students = new List<Student>(){
                new Student() { Name = "Василий", LastName = "Иванов", Birthday = new DateTime(1995,5,16), Id = 1 },
                new Student() { Name = "Иван", LastName = "Егоров", Birthday = new DateTime(1993,2,23), Id = 2 },
                new Student() { Name = "Пётр", LastName = "Ефимов", Birthday = new DateTime(2005,3,23), Id = 3 },
                new Student() { Name = "Ольга", LastName = "Ершова", Birthday = new DateTime(1978,7,11), Id = 4 },
                new Student() { Name = "Алексей", LastName = "Носов", Birthday = new DateTime(1999,4,10), Id = 5 },
                new Student() { Name = "Александр", LastName = "Смирнов", Birthday = new DateTime(2001,1,30), Id = 6 },
                new Student() { Name = "Артём", LastName = "Мартынов", Birthday = new DateTime(2009,1,8), Id = 7 },
                new Student() { Name = "Пётр", LastName = "Филатов", Birthday = new DateTime(1996,7,6), Id = 8 },
                new Student() { Name = "Алексанра", LastName = "Соловьев", Birthday = new DateTime(1998,2,9), Id = 9 }
                };

        static void Main(string[] args)
        {
            //Получить все имена пользователей
            Console.WriteLine("Имена всех пользователей");
            Program.PrintNames(LinqExpressions.UserNames(students));
            Console.WriteLine();

            //Получить имена несовершеннолетних пользователей
            Console.WriteLine("Имена всех несовершеннолетних пользователей");
            Program.PrintNames(LinqExpressions.NoAdultUserNames(students));
            Console.WriteLine();

            //Посчитать сколько совершеннолетних пользователей
            Console.Write("Количество совершеннолетних:");
            Console.Write(LinqExpressions.AdultUsersCount(students));
            Console.WriteLine();

            //Получить имена и фамилии пользователей, у которых фамилия начинается на А
            char firstLetter = 'А';
            Console.WriteLine("Пользователи, у которых имя начинвается на " + firstLetter + ":");
            Program.PrintNames(LinqExpressions.UserNamesStatredLetter(students, firstLetter));

            Console.ReadKey();
        }

        public static void PrintNames(IEnumerable<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        
    }
}
