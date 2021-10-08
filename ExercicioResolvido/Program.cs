using System;
using System.Collections.Generic;
using ExercicioResolvido.Entitites;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine($"\nEmployee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char typeOfEmployee = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(typeOfEmployee == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("\nPAYMENTS: ");
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name} - U${employee.Payment():F2}");
            }
        }
    }
}
