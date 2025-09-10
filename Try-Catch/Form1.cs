using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Try_Catch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /////return methods 
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }




        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            try
            {
                StudentInformation.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMIddleInitial.Text);
                StudentInformation.SetStudentNo = (int)StudentNumber(txtStudentNo.Text);
                StudentInformation.SetProgram = cbPrograms.Text;
                StudentInformation.SetGender = cbGender.Text;
                StudentInformation.SetContact = (int)ContactNo(txtContactNo.Text);
                StudentInformation.SetAge = Age(txtAge.Text);
                StudentInformation.SetBirthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                Form2 frm = new Form2();
                frm.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Error: " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Null Error: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Index Error: " + ex.Message);
            }
        }
           
        
        



        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]{
                     "BS Information Technology",
                     "BS Computer Science",
                     "BS Information Systems",
                     "BS in Accountancy",
                     "BS in Hospitality Management",
                     "BS in Tourism Management"
                     };
            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

        }

        private void txtStudentNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPrograms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMIddleInitial_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
