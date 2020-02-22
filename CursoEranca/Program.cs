using System;
using System.Collections.Generic;
using CursoEranca.Entities;
using System.Globalization;

namespace CursoEranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                //intepolação{i}
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name:  ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per Hour: ");
                double valuePerHouer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (ch == 'y' || ch == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name, hours, valuePerHouer, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours,valuePerHouer));
                }
                Console.WriteLine();
                Console.WriteLine("PAYMENTS: ");
                foreach (Employee emp in list)
                {
                    Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
