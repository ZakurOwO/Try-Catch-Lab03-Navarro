using System;
using System.Windows.Forms;
using static Try_Catch.Form1;

namespace Try_Catch
{
    public partial class Form2 : Form
    {
        StudentRepository repo = new StudentRepository();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
         
            lblStudentNo.Text = StudentInformation.SetStudentNo.ToString();
            lblName.Text = StudentInformation.SetFullName;
            lblProgram.Text = StudentInformation.SetProgram;
            lblBirthday.Text = StudentInformation.SetBirthday;
            lblGender.Text = StudentInformation.SetGender;
            lblContactNo.Text = StudentInformation.SetContact.ToString();
            lblAge.Text = StudentInformation.SetAge.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                
                repo.AddStudent(
                    StudentInformation.SetStudentNo,
                    StudentInformation.SetFullName,
                    StudentInformation.SetProgram,
                    StudentInformation.SetGender,
                    StudentInformation.SetContact,
                    StudentInformation.SetAge,
                    DateTime.Parse(StudentInformation.SetBirthday)
                );

                MessageBox.Show("Student registered successfully!");

               
                Form3 frm3 = new Form3();
                frm3.ShowDialog();

               
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving student: " + ex.Message);
            }
        }
    }
}
