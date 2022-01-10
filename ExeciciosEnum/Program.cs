using ExeciciosEnum.Entities;
using ExeciciosEnum.Entities.Enums;
using System;
using System.Globalization;


namespace ExeciciosEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o departamento::");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter com a data:");
            Console.Write("nome ");
            string name = Console.ReadLine();

            //pedir ao usuario e converte para Enum..
            Console.Write("Level (Junior/MidLevel/Senior:");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary::");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instancia o objeto deparment construtor e inicial ela
            Department dept = new Department(deptName);
            //instancia o objeto Worker construtor
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos?");
            int n = int.Parse(Console.ReadLine());

            //for pra executa "n" vezes
            for(int i =0; i < n; i++)
            {
                Console.WriteLine($"Entre #{i} contrator ");
                Console.WriteLine("Date (DD/MM/YYYY)");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor pro horas ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());

                //instancia o objecto Hourscontract contrutor
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //adicinar o "contract" ao "Worker"...
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.WriteLine("Entre com formato mes e ano (MM/YYYY)::");
            string monthAndYear = Console.ReadLine();
            //pega a variavel monthAndYear e converte em string
            // o substring ele separa a string digitada 
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for: " + monthAndYear + " : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
