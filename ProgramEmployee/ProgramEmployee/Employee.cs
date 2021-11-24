using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramEmployee
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string Patronymic { get; set; }
        public string Department { get; set; }
        public int Number { get; set; }

        public Employee(int id, string name, string secondName, string patronymic, string department, int number)
        {
            ID = id;
            Name = name;
            SecondName = secondName;
            Patronymic = patronymic;
            Department = department;
            Number = number;
        }

        public void GetInfo()
        {
            Console.Write("{0,-5}", ID);
            Console.Write("{0,8} {1,11} {2,13}", SecondName, Name, Patronymic);
            Console.Write("{0,18}", Department);
            Console.WriteLine("{0,10}", Number);
        }
    }
}
