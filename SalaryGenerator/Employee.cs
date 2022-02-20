using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryGenerator
{

       

    public abstract class Employee
    {

        private int months;
        private double salary;
        private double salaryWithTax;
        private double netSalary;
        private string experience;
        private string fullName;
        private int age;


       
       
        public double Salary { get => salary; set => salary = value; }
        public string Experience { get => experience; set => experience = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public int Age { get => age; set => age = value; }
        public double NetSalary { get => this.netSalary; set => this.netSalary = value; }
        public double SalaryWithTax { get => salaryWithTax; set => salaryWithTax = value; }
        public int Months { get => months; set => months = value; }


       
        public virtual double incomeTax()
        {
            return SalaryWithTax = (Salary * 0.14 );
        }

       
        public virtual double experienceSalary() 
        {
            return Salary += (Salary * 0.45);
        }

        public double calculateNetSalary() 
        {
            return NetSalary = ((Salary) - SalaryWithTax) ;
        }

    



    }
}
