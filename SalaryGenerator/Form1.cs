using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            MessageBox.Show("Salary Generator is an app to calculate salaries,taxes,net incomes(yearly, monthly) for all Employees \n this software helps IT Companies to calculate those complicated calculations!","Salary Generator");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (checkSoftware.Checked)
            {
             
                SoftwareEngineer sEngineer = new SoftwareEngineer();

                int months = Convert.ToInt32(monthsBox.Text);
                sEngineer.Months = months;

                string name = fullnameBox.Text;
                sEngineer.FullName = name;

                int age = Convert.ToInt32(ageBox.Text);
                sEngineer.Age = age;

                double salary = Convert.ToDouble(salaryBox.Text);
                sEngineer.Salary = sEngineer.Months * salary; 


                if (checkJunior.Checked)
                {
                    sEngineer.Experience = "Junior";

                    sEngineer.incomeTax();

                    sEngineer.calculateNetSalary();

                    //Functions

                    sEngineer.Calculate();

                    sEngineer.ShowInfo();



                }
                else if (checkSenior.Checked)
                {
                    sEngineer.Experience = "Senior";

                    sEngineer.experienceSalary();

                    sEngineer.incomeTax();

                    sEngineer.calculateNetSalary();

                   

                    sEngineer.Calculate();

                    sEngineer.ShowInfo();
                }
                else
                {
                    MessageBox.Show("Error, YOU MUST HAVE CHOOSE AT LEAST ONE");
                }

            }
            else if(checkDesigner.Checked)
                {
                

                Designer designer = new Designer();

                    int months = Convert.ToInt32(monthsBox.Text);
                    designer.Months = months;

                    string name = fullnameBox.Text;
                    designer.FullName = name;

                    int age = Convert.ToInt32(ageBox.Text);
                    designer.Age = age;

                    double salary = Convert.ToDouble(salaryBox.Text);
                    designer.Salary = designer.Months * salary; 


                     if (checkJunior.Checked)
                    {
                        //IF JUNIOR
                        designer.Experience = "Junior";

                        designer.incomeTax();

                        designer.calculateNetSalary();

                        

                        designer.Calculate();

                        designer.ShowInfo();



                    }
                    else if (checkSenior.Checked)
                    {
                        
                        designer.Experience = "Senior";

                        designer.experienceSalary();

                        designer.incomeTax();

                        designer.calculateNetSalary();

                        

                        designer.Calculate();

                        designer.ShowInfo();
                    }
                    else
                    {
                        MessageBox.Show("Error, YOU MUST HAVE CHOOSE AT LEAST ONE");
                    }

                }
            
            else if (checkBackend.Checked)
                {
                

                BackendDev backend  = new BackendDev();

                    int months = Convert.ToInt32(monthsBox.Text);
                    backend.Months = months;

                    string name = fullnameBox.Text;
                backend.FullName = name;

                    int age = Convert.ToInt32(ageBox.Text);
                backend.Age = age;

                    double salary = Convert.ToDouble(salaryBox.Text);
                backend.Salary = backend.Months * salary;


                    if (checkJunior.Checked)
                    {
                    backend.Experience = "Junior";

                    backend.incomeTax();

                    backend.calculateNetSalary();

                    

                    backend.Calculate();

                    backend.ShowInfo();



                    }
                    else if (checkSenior.Checked)
                    {
                    backend.Experience = "Senior";

                    backend.experienceSalary();

                    backend.incomeTax();

                    backend.calculateNetSalary();

                    

                    backend.Calculate();

                    backend.ShowInfo();
                    }
                    else
                    {
                        MessageBox.Show("Error, YOU MUST HAVE CHOOSE AT LEAST ONE");
                    }

                }
            else
            {
                MessageBox.Show("Error, YOU MUST HAVE CHOOSE AT LEAST ONE");
            }
            






            }
    }
}
