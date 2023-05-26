using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3._1
{
    
        class Program
        {
            static void Main(string[] args)
            {
            
                Employee.AddEmployee(new Employee("блоб джоб", 1, 1000));
                Employee.AddEmployee(new Employee("Курл Чарл", 2, 2000));
                Employee.AddEmployee(new Employee("Хлоп Чек", 3, 3000));
                Employee.AddEmployee(new Employee("Оля Лун", 4, 4000));
                Employee.AddEmployee(new Employee("Вон Там", 5, 5000));
                Employee.PrintAllEmployees();
                Console.Write("Введите номер задания от 1 до 5: ");
                int zad = int.Parse(Console.ReadLine());
                switch (zad)
                {
                    case 1:
                        Console.WriteLine("Общая зарплата сотрудников: ");
                        Console.WriteLine("Total Salary: {0}", Employee.GetTotalSalary());
                        break;
                    case 2:
                        Console.WriteLine("Минимальная и максимальна зарплата:");
                        Console.WriteLine("Employee with Min Salary: {0}", Employee.GetEmployeeWithMinSalary().FullName);
                        Console.WriteLine("Employee with Max Salary: {0}", Employee.GetEmployeeWithMaxSalary().FullName);
                        break;
                    case 3:
                        Console.WriteLine("Средняя зарплата: ");
                        Console.WriteLine("Average Salary: {0}", Employee.GetAvgSalary());
                        break;
                    case 4:
                        Console.WriteLine("Кол-во сотрудников: ");
                        Console.WriteLine("Number of Employees: {0}", Employee.GetNumOfEmployees());
                        break;
                    case 5:
                        Console.WriteLine("Список всех сотрудников: ");
                        Console.WriteLine("All Full Names:");
                        break;
                }
                Employee.PrintAllFullNames();

                Console.ReadKey();
                
            }
        }

}
