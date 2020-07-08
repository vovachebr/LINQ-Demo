using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Student
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public DateTime Birthday { get; set; }
		public int Age
		{
			get { return (DateTime.Now - Birthday).Days / 365; }
		}
    }
}
