using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace ProgramEmployee
{
    class Program
    {
        static void Main()
        {
            List<Employee> employee = new List<Employee>();
            Employee empl;
            Random rnd = new Random();
            string[] Name = new string[] { "Павел", "Иван", "Максим", "Евгений", "Андрей", "Даниил"};
            string[] SecondName = new string[] { "Иванов", "Петров", "Павленко", "Макалич", "Браду"};
            string[] Patronymic = new string[] { "Петрович", "Никитич", "Андреевич", "Михайлович", "Иванович"};
            string[] Department = new string[] { "Отдел снабжения", "Отдел сбыта", "Плановый отдел" };
            int[] Number = new int[15];
            int element, count = 0;
            int answer; string answer2;

            while (true)
            {
                try
                {
                    for (int i = 0; i < 15; i++)
                    {
                        count = 1;
                        do
                        {
                            element = rnd.Next(101, 116);
                            if (!Number.Contains(element))
                            {
                                empl = new Employee(i + 1, Name[rnd.Next(0, 6)], SecondName[rnd.Next(0, 5)], Patronymic[rnd.Next(0, 5)], Department[rnd.Next(0, 3)], element);
                                employee.Add(empl);
                                Number[i] = element;
                                count = 0;
                            }
                        }
                        while (count == 1);
                    }

                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                    foreach (Employee x in employee)
                    {
                        x.GetInfo();
                    }
                    Console.WriteLine();
                    
                    Console.Write("Сортировка по какому номеру столбца? \nОтвет: ");
                    answer = Int32.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1: employee.Sort((a, b) => a.ID.CompareTo(b.ID)); break;
                        case 2: employee.Sort((a, b) => a.SecondName.CompareTo(b.SecondName)); break;
                        case 3: employee.Sort((a, b) => a.Name.CompareTo(b.Name)); break;
                        case 4: employee.Sort((a, b) => a.Patronymic.CompareTo(b.Patronymic)); break;
                        case 5: employee.Sort((a, b) => a.Department.CompareTo(b.Department)); break;
                        case 6: employee.Sort((a, b) => a.Number.CompareTo(b.Number)); break;
                    }
                    Console.WriteLine();
                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                    foreach (Employee x in employee)
                    {
                        x.GetInfo();
                    }
                    Console.WriteLine();

                    Console.WriteLine("Группировка по отделу:");
                    var EmployeeGroups = from Empl in employee
                                         group Empl by Empl.Department;
                    foreach (IGrouping<string, Employee> group in EmployeeGroups)
                    {
                        Console.WriteLine("{0}: {1} чел.", group.Key, group.ToList().Count);
                        Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                        foreach (Employee employeeGroups in group)
                        {
                            employeeGroups.GetInfo();
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    
                    // Не помню задание, что именно должен вводить пользователь, чтобы вывелась информация о рабочем
                    // Дал выбор пользователю, по каким данным искать рабочего
                    Console.WriteLine("Выберите, какие данные рабочего вы помните, чтобы вывести всю информацию о нем: ");
                    Console.Write("1. ID\n2. SecondName\n3. Name\n4. Patronymic\n5. Department\n6. Number\nОтвет: ");
                    answer = Int32.Parse(Console.ReadLine());
                    switch (answer)
                    {
                        case 1: Console.Write("Введите Id рабочего: ");
                                answer = Int32.Parse(Console.ReadLine());
                                List<Employee> ID = employee.Where(x => x.ID.Equals(answer)).ToList();
                                Console.WriteLine("Рабочий с таким Id существует? - " + (ID.Count > 0));
                                if (ID.Count > 0)
                                {
                                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                                    foreach (Employee e in ID)
                                    {
                                        if (e.ID == answer)
                                            e.GetInfo();
                                    }
                                }
                                break;
                        case 2: Console.Write("Введите фамилию рабочего: ");
                                answer2 = Console.ReadLine();
                                List<Employee> secondName = employee.Where(x => x.SecondName.ToLower().Equals(answer2.ToLower())).ToList();
                                Console.WriteLine("Рабочий с такой фамилией существует? - " + (secondName.Count > 0));
                                if (secondName.Count > 0)
                                {
                                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                                    foreach (Employee e in secondName)
                                    {
                                        if (e.SecondName.ToLower() == answer2.ToLower())
                                            e.GetInfo();
                                    }
                                }
                                break;
                        case 3: Console.Write("Введите имя рабочего: ");
                                answer2 = Console.ReadLine();
                                List<Employee> name = employee.Where(x => x.Name.ToLower().Equals(answer2.ToLower())).ToList();
                                Console.WriteLine("Рабочий с таким именем существует? - " + (name.Count > 0));
                                if (name.Count > 0)
                                {
                                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                                    foreach (Employee e in name)
                                    {
                                        if (e.Name.ToLower() == answer2.ToLower())
                                            e.GetInfo();
                                    }
                                }
                                break;
                        case 4: Console.Write("Введите отчество рабочего: ");
                                answer2 = Console.ReadLine();
                                List<Employee> patronymic = employee.Where(x => x.Patronymic.ToLower().Equals(answer2.ToLower())).ToList();
                                Console.WriteLine("Рабочий с таким отчеством существует? - " + (patronymic.Count > 0));
                                if (patronymic.Count > 0)
                                {
                                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                                    foreach (Employee e in patronymic)
                                    {
                                        if (e.Patronymic.ToLower() == answer2.ToLower())
                                            e.GetInfo();
                                    }
                                }
                                break;
                        case 5: Console.Write("Введите отдел рабочего: ");
                                answer2 = Console.ReadLine();
                                List<Employee> department = employee.Where(x => x.Department.ToLower().Equals(answer2.ToLower())).ToList();
                                Console.WriteLine("Рабочий в таком отделе существует? - " + (department.Count > 0));
                                if (department.Count > 0)
                                {
                                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                                    foreach (Employee e in department)
                                    {
                                        if (e.Department.ToLower() == answer2.ToLower())
                                            e.GetInfo();
                                    }
                                }
                                break;
                        case 6: Console.Write("Введите номер телефона рабочего: ");
                                answer = Int32.Parse(Console.ReadLine());
                                List<Employee> number = employee.Where(x => x.Number.Equals(answer)).ToList();
                                Console.WriteLine("Рабочий с таким номером телефона существует? - " + (number.Count > 0));
                                if (number.Count > 0)
                                {
                                    Console.WriteLine("ID    Фамилия        Имя       Отчество         Отдел      Номер телефона");
                                    foreach (Employee e in number)
                                    {
                                        if (e.Number == answer)
                                            e.GetInfo();
                                    }
                                }
                                break;
                    }
                    Console.WriteLine();

                    Console.WriteLine("Хотите повторить?\n1 - Да;\nДругое число - Нет");
                    int s = int.Parse(Console.ReadLine());
                    if (s == 1)
                    {
                        Console.Clear();
                        Main();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                    Main();
                }
            }
        }
    }
}
