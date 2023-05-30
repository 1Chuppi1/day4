using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3._1
{

    class Program
    {

        //метод, который принимает число в качестве параметра и выводит в консоль всех сотрудников с зарплатой меньше данного числа
        static void PrintEmployeesWithSalaryLessThan(Employee[] employees2, double salary)
        {
            foreach (Employee employee in employees2)
            {
                if (employee.Salary < salary)
                {
                    Console.WriteLine($"ID: {employee.Id}, ФИО: {employee.FullName}, Зарплата: {employee.Salary}");
                }
            }
        }

        //метод для вывода всех сотрудников с зарплатой больше (или равно) данного числа:
        static void PrintEmployeesWithSalaryGreaterThan(int salary, Employee[] employees2)
        {
            foreach (Employee employee in employees2)
            {
                if (employee.Salary >= salary)
                {
                    Console.WriteLine($"ID: {employee.ID}, ФИО: {employee.FullName}, Зарплата: {employee.Salary}");
                }
            }
        }

         static void PrintEmployeesWithSalaryGreaterThan(double inputSalary)
        {
            Console.WriteLine($"");
        }

        private static void PrintEmployeesWithSalaryLessThan(double inputSalary)
        {
            Console.WriteLine($"");
        }






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


            Employee.AddEmployee(new Employee("блоб джоб", 1, 1000));
            Employee.AddEmployee(new Employee("Курл Чарл", 2, 2000));
            Employee.AddEmployee(new Employee("Хлоп Чек", 3, 3000));
            Employee.AddEmployee(new Employee("Оля Лун", 4, 4000));
            Employee.AddEmployee(new Employee("Вон Там", 5, 5000));

            Console.Write("Введите номер задания от 1 до 7: ");
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
                case 6:
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
                    // Считываем номер отдела
                    Console.Write("Введите номер отдела (1-5): ");
                    int number = int.Parse(Console.ReadLine());

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
                            break;
                        case 2:
                            Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 2).FullName);
                            Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 2).FullName);
                            Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 2));
                            Console.Write("Введите процент индексации зарплаты: ");
                            percent = double.Parse(Console.ReadLine());
                            IndexSalary(employees, 2, percent);
                            PrintEmployees(employees, 2);
                            break;
                        case 3:
                            Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 3).FullName);
                            Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 3).FullName);
                            Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 3));
                            Console.Write("Введите процент индексации зарплаты: ");
                            percent = double.Parse(Console.ReadLine());
                            IndexSalary(employees, 3, percent);
                            PrintEmployees(employees, 3);
                            break;
                        case 4:
                            Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 4).FullName);
                            Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 4).FullName);
                            Console.WriteLine("Средняя зарплата вотделе: " + GetAverageSalary(employees, 4));
                            Console.Write("Введите процент индексации зарплаты: ");
                            percent = double.Parse(Console.ReadLine());
                            IndexSalary(employees, 4, percent);
                            PrintEmployees(employees, 4);
                            break;
                        case 5:
                            Console.WriteLine("Сотрудник с минимальной зарплатой: " + GetEmployeeWithMinSalary(employees, 5).FullName);
                            Console.WriteLine("Сотрудник с максимальной зарплатой: " + GetEmployeeWithMaxSalary(employees, 5).FullName);
                            Console.WriteLine("Средняя зарплата в отделе: " + GetAverageSalary(employees, 5));
                            Console.Write("Введите процент индексации зарплаты: ");
                            percent = double.Parse(Console.ReadLine());
                            IndexSalary(employees, 5, percent);
                            PrintEmployees(employees, 5);
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

                    double inputSalary = 1500;
                    Console.WriteLine($"Сотрудники со зарплатой меньше {inputSalary}:");
                    PrintEmployeesWithSalaryLessThan(inputSalary);

                    Console.WriteLine($"Сотрудники со зарплатой больше или равно {inputSalary}:");
                    PrintEmployeesWithSalaryGreaterThan(inputSalary);
                    break;
            }


            Console.ReadKey();

        }

        
    }

}