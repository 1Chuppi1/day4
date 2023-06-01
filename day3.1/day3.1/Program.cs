using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3._1
{

    class Program
    {
        // Метод для поиска сотрудника с минимальной зарплатой в определенном отделе
        static Employee GetEmployeeWithMinSalary(Employee[] employees, int department)
        {
            Employee result = null;
            double minSalary = double.MaxValue;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department && employee.Salary < minSalary)
                {
                    result = employee;
                    minSalary = employee.Salary;
                }
            }
            return result;
        }

        // Метод для поиска сотрудника с максимальной зарплатой в определенном отделе
        static Employee GetEmployeeWithMaxSalary(Employee[] employees, int department)
        {
            Employee result = null;
            double maxSalary = double.MinValue;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department && employee.Salary > maxSalary)
                {
                    result = employee;
                    maxSalary = employee.Salary;
                }
            }
            return result;
        }

        // Метод для расчета средней зарплаты в определенном отделе
        static double GetAverageSalary(Employee[] employees, int department)
        {
            int count = 0;
            double sum = 0;
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    sum += employee.Salary;
                    count++;
                }
            }
            return sum / count;
        }

        // Метод для индексации зарплаты всех сотрудников определенного отдела на определенный процент
        static void IndexSalary(Employee[] employees, int department, double percent)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    employee.Salary *= (1 + percent / 100);
                }
            }
        }

        // Метод для печати всех сотрудников определенного отдела
        static void PrintEmployees(Employee[] employees, int department)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Department == department)
                {
                    Console.WriteLine("Имя: " + employee.FullName + ", Зарплата: " + employee.Salary);
                }
            }
        }
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажмите Enter, чтобы узнать номера заданий.");
                Console.ReadLine();
                Console.WriteLine("1.Общая зарплата сотрудников.");
                Console.WriteLine("2.Минимальная и максимальна зарплата. ");
                Console.WriteLine("3.Средняя зарплата. ");
                Console.WriteLine("4.Кол-во сотрудников. ");
                Console.WriteLine("5.Список всех сотрудников. ");
                Console.WriteLine("6.Изменение зарплаты под процент.");
                Console.WriteLine("7.Минимальная, максимальная и средняя зарплата по отделам. ");
                Console.WriteLine("8.Зарплата менее 1500 или зарплата более или равна 1500. ");
                Console.WriteLine("");
                Console.WriteLine("Если вы выбрали задание для проверки: Нажмите Enter");
                Console.ReadLine();
                Console.Clear();

                Employee.AddEmployee(new Employee("Иван Иванов", 1, 10200));
                Employee.AddEmployee(new Employee("Ииииии Ааааа", 2, 10060));
                Employee.AddEmployee(new Employee("Кур Кума", 3, 1000));
                Employee.AddEmployee(new Employee("Жи Ест", 4, 10400));
                Employee.AddEmployee(new Employee("Уа Га", 5, 10100));
                Employee.AddEmployee(new Employee("Пупа Пипа", 6, 15000));
                Employee.AddEmployee(new Employee("Ест Жи", 7, 10600));

                Console.Write("Введите номер задания от 1 до 8: ");
                int zad = int.Parse(Console.ReadLine());
                switch (zad)
                {
                    case 1:
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Общая зарплата сотрудников: ");
                        Console.WriteLine("Total Salary: {0}", Employee.GetTotalSalary());
                        Console.WriteLine("==========================================================");
                        break;
                    case 2:
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Минимальная и максимальна зарплата:");
                        Console.WriteLine("Employee with Min Salary: {0}", Employee.GetEmployeeWithMinSalary().FullName);
                        Console.WriteLine("Employee with Max Salary: {0}", Employee.GetEmployeeWithMaxSalary().FullName);
                        Console.WriteLine("==========================================================");
                        break;
                    case 3:
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Средняя зарплата сотрудников: {0}", Employee.GetAvgSalary());
                        Console.WriteLine("==========================================================");
                        break;
                    case 4:
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Кол-во сотрудников: ");
                        Console.WriteLine("Number of Employees: {0}", Employee.GetNumOfEmployees());
                        Console.WriteLine("==========================================================");
                        break;
                    case 5:
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Список всех сотрудников: ");
                        Console.WriteLine("All Full Names:");
                        Employee.PrintAllFullNames();
                        Console.WriteLine("==========================================================");
                        break;
                    case 6:
                        Console.WriteLine("==========================================================");
                        // Создаем массив сотрудников
                        Employee[] employees1 = new Employee[]
                        {
                    new Employee("Иван Иванов", 1000),
                    new Employee("Петр Петров", 2000),
                    new Employee("Сидор Сидоров", 3000)
                        };

                        // Получаем процент изменения зарплаты от пользователя
                        Console.Write("Введите процент изменения зарплаты: ");
                        int percentage = int.Parse(Console.ReadLine());

                        // Изменяем зарплату у всех сотрудников
                        foreach (Employee emp in employees1)
                        {
                            emp.IncreaseSalary(percentage);
                            Console.WriteLine(emp.ToString());
                        }
                        Console.WriteLine("==========================================================");
                        Console.ReadKey();
                        break;

                    case 7:
                        // Создаем массив сотрудников
                        Employee[] employees = new Employee[]
                        {
                        new Employee("Иван Иванов",1, 10200),
                        new Employee("Ииииии Ааааа",2, 10060),
                        new Employee("Кур Кума",3, 1000),
                        new Employee("Жи Ест",4, 10400),
                        new Employee("Уа Га",5, 10100),
                        new Employee("Пупа Пипа",6, 15000),
                        new Employee("Ест Жи",7, 10600),

                        };
                        Console.WriteLine("==========================================================");
                        // Считываем номер отдела
                        Console.Write("Введите номер отдела (1-5): ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine("==========================================================");
                        // Вызываем нужный метод в зависимости от номера отдела
                        switch (number)
                        {
                            case 1:
                                Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 1).FullName);
                                Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 1).FullName);
                                Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 1));
                                Console.Write("Введите процент индексации зарплаты: ");
                                double percent = double.Parse(Console.ReadLine());
                                IndexSalary(employees, 1, percent);
                                PrintEmployees(employees, 1);
                                Console.WriteLine("==========================================================");
                                break;
                            case 2:
                                Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 2).FullName);
                                Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 2).FullName);
                                Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 2));
                                Console.Write("Введите процент индексации зарплаты: ");
                                percent = double.Parse(Console.ReadLine());
                                IndexSalary(employees, 2, percent);
                                PrintEmployees(employees, 2);
                                Console.WriteLine("==========================================================");
                                break;
                            case 3:
                                Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 3).FullName);
                                Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 3).FullName);
                                Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 3));
                                Console.Write("Введите процент индексации зарплаты: ");
                                percent = double.Parse(Console.ReadLine());
                                IndexSalary(employees, 3, percent);
                                PrintEmployees(employees, 3);
                                Console.WriteLine("==========================================================");
                                break;
                            case 4:
                                Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 4).FullName);
                                Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 4).FullName);
                                Console.WriteLine("Средняя зарплата вотделе: " + GetAverageSalary(employees, 4));
                                Console.Write("Введите процент индексации зарплаты: ");
                                percent = double.Parse(Console.ReadLine());
                                IndexSalary(employees, 4, percent);
                                PrintEmployees(employees, 4);
                                Console.WriteLine("==========================================================");
                                break;
                            case 5:
                                Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 5).FullName);
                                Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 5).FullName);
                                Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 5));
                                Console.Write("Введите процент индексации зарплаты: ");
                                percent = double.Parse(Console.ReadLine());
                                IndexSalary(employees, 5, percent);
                                PrintEmployees(employees, 5);
                                Console.WriteLine("==========================================================");
                                break;
                            default:
                                Console.WriteLine("Неверный номер отдела");
                                break;
                        }
                        break;

                    case 8:

                        // Создаем массив сотрудников
                        Employee[] employees2 = new Employee[]
                        {
                        new Employee("Иван Иванов",1, 200),
                        new Employee("Ииииии Ааааа",2, 1060),
                        new Employee("Кур Кума",3, 1000),
                        new Employee("Жи Ест",4, 10400),
                        new Employee("Уа Га",5, 10100),
                        new Employee("Пупа Пипа",6, 15000),
                        new Employee("Ест Жи",7, 10600),

                        };
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Сотрудники у которых зарплата больше или равна 1500.");
                        double inputSalary = 1500;
                        foreach (Employee employee in employees2)
                        {
                            if (employee.Salary >= inputSalary)
                            {

                                Console.WriteLine($"ID: {employee.Department}, ФИО: {employee.FullName}, Зарплата: {employee.Salary}");
                            }
                        }
                        Console.WriteLine("==========================================================");
                        Console.WriteLine($"Сотрудники со зарплатой менее 1500.");
                        foreach (Employee employee in employees2)
                        {
                            if (employee.Salary < inputSalary)
                            {

                                Console.WriteLine($"ID: {employee.Department}, ФИО: {employee.FullName}, Зарплата: {employee.Salary}");
                            }
                        }
                        Console.WriteLine("==========================================================");
                        break;

                    default:
                        Console.WriteLine("Неверный номер задания");
                        break;
                }
                Console.WriteLine("Вы хотите вернуться к началу? (y/n)");
                string nach = (Console.ReadLine());
                if (nach == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            }
            
        }
    }
}