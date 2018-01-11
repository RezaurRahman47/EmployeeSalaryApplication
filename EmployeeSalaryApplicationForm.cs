using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApplication
{
    public partial class EmployeeSalaryApplicationForm : Form
    {
        public EmployeeSalaryApplicationForm()
        {
            InitializeComponent();
        }

        Employee employee1 = new Employee();
        Salary newSalary = new Salary();

        private void saveButton_Click(object sender, EventArgs e)
        {
            

                employee1.employeeId = Convert.ToInt32(employeeIdTextBox.Text);
                employee1.employeeName = employeeNameTextBox.Text;
                employee1.enmloyeeEmail = emailTextBox.Text;

                newSalary.employeeBasicSalary = Convert.ToDouble(basicSalaryTextBox.Text);
                newSalary.medicalAllownceOnBasic = Convert.ToDouble(medicalAllownceTextBox.Text);
                newSalary.conveyanceOnBasic = Convert.ToDouble(conveyanceTextBox.Text);

                employeeIdTextBox.Clear();
                employeeNameTextBox.Clear();
                emailTextBox.Clear();
                basicSalaryTextBox.Clear();
                medicalAllownceTextBox.Clear();
                conveyanceTextBox.Clear();

                MessageBox.Show("Save Successfully..!!!");

        }



        private void incrementButton_Click(object sender, EventArgs e)
        {
            newSalary.IncrementOnBasic(Convert.ToDouble(incrementTextBox.Text));

            incrementTextBox.Clear();
        }



        private void showButton_Click(object sender, EventArgs e)
        {
            noOfIncrementextBox.Text = newSalary.numberOfIncrement.ToString();
            showBasicTextBox.Text = newSalary.employeeBasicSalary.ToString();
            showMedicalTextBox.Text = newSalary.MedicalAmountOnBasic().ToString();
            showConveyanceTextBox.Text = newSalary.ConveyanceAmountOnBasic().ToString();
            totalTextBox.Text = newSalary.TotalSalary().ToString();
        }
    }
}
