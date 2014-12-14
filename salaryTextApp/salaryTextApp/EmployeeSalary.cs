using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaryTextApp
{
    public partial class EmployeeSalary : Form
    {
        public EmployeeSalary()
        {
            InitializeComponent();
        }

        private int totalSalary = 0;
        private int salary = 0;
        string employeeInfofilePath="f:\\emploeeInfo.txt";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saVebutton_Click(object sender, EventArgs e)
        {
            string employeeName = naMetextBox.Text;
            string employeeID = IDtextBox.Text;
            string employeeSalary = salaRytextBox.Text;
            FileStream aFileStream = new FileStream(employeeInfofilePath, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(employeeName + "," + employeeID + "," + employeeSalary);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }

        private void ShoWbutton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(employeeInfofilePath, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            int employeeSalaryAmount = 0;
            listBox1.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string employeeInfo = aStreamReader.ReadLine();
                listBox1.Items.Add(employeeInfo);

                string[] wordStrings = employeeInfo.Split(',');

                salary = Convert.ToInt32(wordStrings[2]);
                //MessageBox.Show(wordStrings[2]);
                employeeSalaryAmount = TotalAmountSum(salary);

                totaltextbox.Text = employeeSalaryAmount.ToString();

            }
            ShoWbutton.Enabled = false;
            aStreamReader.Close();
            aFileStream.Close();
        }

        private int TotalAmountSum(int salary)
        {
            totalSalary = totalSalary + salary;
            return totalSalary;
        }
    }
}
