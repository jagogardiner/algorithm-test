using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace algorithm_test
{
    public partial class StudentListForm : Form
    {
        private SqlCommand command;
        public StudentListForm()
        {
            InitializeComponent();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (SqlConnection conn = new SqlConnection(SqlTools.connectionString))
            {
                conn.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM Students", conn);
                int rows = (int)command.ExecuteScalar();
                for (int i = 1; i < rows + 1; i++)
                {
                    command = new SqlCommand("SELECT StudentFirstName, StudentLastName FROM Students where StudentId = " + i, conn);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string first = reader[0].ToString().TrimEnd();
                            string second = reader[1].ToString().TrimEnd();
                            listBox1.Items.Add(first + " " + second);
                        }
                    }
                }
                conn.Close();
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label1.Text = "Name: "+listBox1.SelectedItem.ToString();
            string year = null;
            using(SqlTools tools = new SqlTools())
            {
                tools.reader = SqlTools.executeReader("SELECT AcademicYear.AcademicYearName FROM Students INNER JOIN AcademicYear ON Students.AcademicYearID=AcademicYear.AcademicYearID where Students.StudentId="+listBox1.SelectedIndex);
                while (tools.reader.Read())
                {
                    year = (string)tools.reader[0];
                }
            }
            label2.Text = "Academic year: " + year;
        }
    }
}
