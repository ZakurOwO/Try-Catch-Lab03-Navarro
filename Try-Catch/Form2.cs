using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Try_Catch
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblStudentNo.Text = StudentInformation.SetStudentNo.ToString();
            lblName.Text = StudentInformation.SetFullName;
            lblProgram.Text = StudentInformation.SetProgram;
            lblBirthday.Text = StudentInformation.SetBirthday;
            lblGender.Text = StudentInformation.SetGender;
            lblContactNo.Text = StudentInformation.SetContact.ToString();
            lblAge.Text = StudentInformation.SetAge.ToString();
        }
    }
}
