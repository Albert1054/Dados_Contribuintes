using System;
using System.Collections.Generic;
using System.Globalization;
using MetodosAbstratos.Entities;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();
            Console.Write("Enter number the tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char res = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(res == 'i' || res == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new Individual(name,income,expenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int number = int.Parse(Console.ReadLine());
                    list.Add(new Company(name,income,number));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach(Taxpayer tp in list)
            {
                Console.WriteLine(tp);
                sum += tp.TaxValue();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
