using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryGenerator
{
    //Yusuf Karagol
    class Designer :Employee
    {
        public Designer()
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
           
            return Salary += (Salary * 0.45);
        }


        
        public override double incomeTax()
        {
            return SalaryWithTax = (Salary * 0.20);

        }



        public void Calculate()
        {
            MessageBox.Show("Calculating....");
        }

        public string toString()
        {
            {
                return "Name: " + FullName + "\n Age: " + Age + "\n Job: " + "UI UX Designer" + "\n Experience: " + Experience + "\n Salary: " + Salary + "$" + "\n Income Tax: " + SalaryWithTax.ToString() + "$" + "\n Net Salary: " + NetSalary.ToString() + "$" + "\n Months: " + Months + "\n (If the Person's Senior then the salary will be higher than junior)";

            }
        }

        public void ShowInfo()
        {
            MessageBox.Show("Employee information:\n" + toString(), Experience);
        }


    }


}
