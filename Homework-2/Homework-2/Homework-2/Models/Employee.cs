using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public Employee(string name, string surname, int age, string adress)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Adress = adress;
        }
        public override string ToString()
        {
            return $"{Name} {Surname} {Age} {Adress}";
        }
    }
}
