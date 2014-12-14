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
using CSVLib;

namespace StudentRecordUIApp
{
    public partial class StudentRecordUI : Form
    {
        public StudentRecordUI()
        {
            InitializeComponent();
        }

        private string studentRecordCSVfile = "f:\\studentRecordUI.csv";
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saVebutton_Click(object sender, EventArgs e)
        {
            string studentReg = regNotextBox.Text;
            string studentName = naMetextBox.Text;
            if (File.Exists(studentRecordCSVfile))
            {
                bool uniqueReg = Unicheker(studentReg);
                if (uniqueReg == true)
                {
                    FileStream aFileStream = new FileStream(studentRecordCSVfile, FileMode.Append);
                    CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                    List<string> aStudentRecord = new List<string>();
                    aStudentRecord.Add(studentReg);
                    aStudentRecord.Add(studentName);
                    aWriter.WriteRow(aStudentRecord);
                    aFileStream.Close();
                }
                else
                {
                    MessageBox.Show("already Registered");
                }
}
            else
                {
                FileStream aFileStream = new FileStream(studentRecordCSVfile, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aStudentRecord = new List<string>();
                aStudentRecord.Add(studentReg);
                aStudentRecord.Add(studentName);
                aWriter.WriteRow(aStudentRecord);
                aFileStream.Close();   
            }
            
            
        }

        private bool Unicheker(string studentReg)
        {
            int studentRegInt = Convert.ToInt32(studentReg);
            FileStream aFileStream = new FileStream(studentRecordCSVfile, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> astudentList = new List<string>();
            bool s = true;
            while (aReader.ReadRow(astudentList))
            {
                int regNo = Convert.ToInt32(astudentList[0]);
                if (studentRegInt == regNo)
                {
                    s = false;
                    break;
                }
                else
                {
                    s = true;
                }
            }
            aFileStream.Close();
            return s;                                           
        }

        private void Showbutton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(studentRecordCSVfile,FileMode.Open);
            CsvFileReader aReader=new CsvFileReader(aFileStream);
            List<string> astudentList=new List<string>();
            studentRecordlistBox.Items.Clear();
            while (aReader.ReadRow(astudentList))
            {
                string regNo = astudentList[0];
                string name = astudentList[1];
                studentRecordlistBox.Items.Add(regNo + "  " + name);
            }
            aFileStream.Close();
        }
    }
}
