using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GradeForm.connectionString))
            {
                conn.Open();
                command = new SqlCommand("SELECT COUNT(*) FROM Students", conn);
                int rows = (int)command.ExecuteScalar();
                for (int i = 1; i < rows+1; i++)
                {
                    command = new SqlCommand("SELECT StudentFirstName, StudentLastName FROM Students where StudentId = "+i , conn);
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
            }
        }
    }
}
