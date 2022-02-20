using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryGenerator
{
    
    class BackendDev : Employee
    {
        public BackendDev()
        {
            
            FullName = "";
            Age = 0;
            Months = 0;
            Salary = 0;
            SalaryWithTax = 0;
            NetSalary = 0;
            Experience = "Junior"; 
        }


        
        public override double experienceSalary()
        {
           
            return Salary += (Salary * 0.40);
        }


       
        public override double incomeTax()
        {
            return SalaryWithTax = (Salary * 0.22);

        }



        public void Calculate()
        {
            MessageBox.Show("Calculating....");
        }

        public string toString()
        {
            {
                return "Name: " + FullName + "\n Age: " + Age + "\n Job: " + "Backend Developer" + "\n Experience: " + Experience + "\n Salary: " + Salary + "$" + "\n Income Tax: " + SalaryWithTax.ToString() + "$" + "\n Net Salary: " + NetSalary.ToString() + "$" + "\n Months: " + Months + "\n (If the Person's Senior then the salary will be higher than junior)";

            }
        }

        public void ShowInfo()
        {
            MessageBox.Show("Employee information:\n" + toString(), Experience);
        }


    }


}
