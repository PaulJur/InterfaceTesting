using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{ //A basic interface testing program.
    public interface IEmployeeSalary
    {
        decimal CalculateSalary();
    }

    public interface IContractorSalary
    {
        decimal CalculateContractorSalary(decimal hoursWorked);
    }
    public class FullTimeEmployee : IEmployeeSalary
    {
         private decimal MonthlySalary { get; set; }

         private decimal HourlyWage { get; set; }


        public FullTimeEmployee(decimal hourlyWage)
        {
            HourlyWage = hourlyWage;
        }

        public decimal CalculateSalary()
        {
            return MonthlySalary = HourlyWage * 160;
        }

        public decimal GetMonthlySalary()
        {
            return MonthlySalary;
        }

        public decimal GetHourlyWage()
        {
            return HourlyWage;
        }
    }
    public class PartTimeEmployee : IEmployeeSalary
    {
        private decimal MonthlySalary { get; set; }

        private decimal HourlyWage { get; set; }


        public PartTimeEmployee(decimal hourlyWage)
        {
            HourlyWage = hourlyWage;
        }

        public decimal CalculateSalary()
        {
            return MonthlySalary = HourlyWage * 80;
        }

        public decimal GetMonthlySalary()
        {
            return MonthlySalary;
        }

        public decimal GetHourlyWage()
        {
            return HourlyWage;
        }
    }
    public class Contractor: IContractorSalary
    {
        private decimal MonthlySalary { get; set; }

        private decimal HourlyWage { get; set; }

        private decimal HoursWorked { get; set; }


        public Contractor(decimal hourlyWage)
        {
            HourlyWage = hourlyWage;
        }

        public decimal CalculateContractorSalary(decimal hoursWorked)
        {
            HoursWorked = hoursWorked;
            return MonthlySalary = HourlyWage * HoursWorked;
        }

        public decimal GetMonthlySalary()
        {
            return MonthlySalary;
        }

        public decimal GetHourlyWage()
        {
            return HourlyWage;
        }

        public decimal GetHoursWorked()
        {
            return HoursWorked;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee John = new FullTimeEmployee(hourlyWage: 30);
            Console.WriteLine($"John earns {John.CalculateSalary()}\n");

            PartTimeEmployee Emily = new PartTimeEmployee(hourlyWage: 15);
            Console.WriteLine($"Emily earns {Emily.CalculateSalary()}\n");

            Contractor Tom = new Contractor(hourlyWage: 66);
            Console.WriteLine($"Tom earns {Tom.CalculateContractorSalary(50)}\n");

            Console.Write("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
