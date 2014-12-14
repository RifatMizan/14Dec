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

namespace AddressBookApp
{
    public partial class AddressBook : Form
    {
        private string addressBookfilePath = "E:\\addressBook.csv";

        public AddressBook()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            string personName = nametextBox.Text;
            string personContact = contacttextBox.Text;
            string personEmail = emailtextBox.Text;
            if (File.Exists(addressBookfilePath))
            {
                FileStream aFileStream = new FileStream(addressBookfilePath, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> anAddressBook = new List<string>();
                anAddressBook.Add(personName);
                anAddressBook.Add(personContact);
                anAddressBook.Add(personEmail);
                aWriter.WriteRow(anAddressBook);
                aFileStream.Close();
            }
            else
            {
                FileStream aFileStream = new FileStream(addressBookfilePath, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> anAddressBook = new List<string>();
                anAddressBook.Add(personName);
                anAddressBook.Add(personContact);
                anAddressBook.Add(personEmail);
                aWriter.WriteRow(anAddressBook);
                aFileStream.Close();
            }
        }


        private void Showbutton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(addressBookfilePath, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> anaddressBook = new List<string>();
            listBox1.Items.Clear();
            while (aReader.ReadRow(anaddressBook))
            {
                string personsName = anaddressBook[0];
                string personsContactNo = anaddressBook[1];
                string personsEmail = anaddressBook[2];
                listBox1.Items.Add(personsName + "  " + personsContactNo + " " + personsEmail);
            }
            aFileStream.Close();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            string name = nametextBox.Text.ToLower();
            string searchByName = searchtextBox.Text.ToLower();
            FileStream aFileStream = new FileStream(addressBookfilePath, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> anaddressBook = new List<string>();
            listBox1.Items.Clear();
            if (nameradioButton.Checked)
            {
                while (aReader.ReadRow(anaddressBook))
                {

                    string studentRegNo = anaddressBook[0].ToLower();
                    int i = studentRegNo.IndexOf(searchByName);
                    if (i == -1)
                    {
                        continue;
                    }
                    else
                    {
                        string d = studentRegNo;
                        if (d != "")
                        {
                            listBox1.Items.Add(d);
                        }
                    }

                }
                aFileStream.Close();
                if (contactradioButton.Checked)
                {
                    while (aReader.ReadRow(anaddressBook))
                    {

                        string studentRegNo = anaddressBook[1];
                        int i = studentRegNo.IndexOf(searchByName);
                        if (i == -1)
                        {
                            continue;
                        }
                        else
                        {
                            string d = studentRegNo.Substring(i);
                            if (d != "")
                            {
                                listBox1.Items.Add(d);
                            }
                        }

                    }
                    aFileStream.Close();
                }
                if (emailradioButton.Checked)
                {
                    int aaa = 0;
                    while (aReader.ReadRow(anaddressBook))
                    {

                        string studentRegNo = anaddressBook[2];
                        int i = studentRegNo.IndexOf(searchByName);
                        if (i == -1)
                        {
                            aaa = 1;
                            continue;
                        }
                        else
                        {
                            string d = studentRegNo;
                            if (d != "")
                            {
                                listBox1.Items.Add(d);
                            }
                        }

                    }
                    aFileStream.Close();
                }
            }
        }
    }
}
