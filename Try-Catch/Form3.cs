using System;
using System.Windows.Forms;
using static Try_Catch.Form1;

namespace Try_Catch
{
    public partial class Form3 : Form
    {
        StudentRepository repo = new StudentRepository();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = repo.GetAllStudents();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
