﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using MathNet.Numerics;

namespace algorithm_test
{
    public partial class Form1 : Form
    {
        // to-do work out actual weights
        readonly Dictionary<string, double> Grades = new Dictionary<string, double>()
        {
            ["A*"] = 10.0,
            ["A"] = 8.0,
            ["B"] = 7.0,
            ["C"] = 6.0,
            ["D"] = 5.0,
            ["E"] = 3.5,
            ["U"] = 1.5
        };

        public Form1()
        {
            InitializeComponent();
        }

        double[] calculateCoefficient()
        {
            List<double> HomeworkResults = new List<double>();
            List<double> MockResults = new List<double>();
            List<double> MTGResults = new List<double>();
            List<double> FinalResults = new List<double>();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nysad\source\repos\algorithm-test\algorithm-test\Database1.mdf;Integrated Security=True";
                conn.Open();
                SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM Results", conn);
                int row = (int)comm.ExecuteScalar();
                for (int i = 1; i < row+1; i++)
                {
                    SqlCommand comm2 = new SqlCommand("SELECT HWResult, MockResult, MTGResult, FinalResult FROM Results where ResultID = "+i, conn);
                    using (SqlDataReader reader = comm2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            HomeworkResults.Add(Grades[reader[0].ToString().TrimEnd()]);
                            MockResults.Add(Grades[reader[1].ToString().TrimEnd()]);
                            MTGResults.Add(Grades[reader[2].ToString().TrimEnd()]);
                            FinalResults.Add(Grades[reader[3].ToString().TrimEnd()]);
                        }
                    }
                }
                conn.Close();
            }
            double[][] x = new double[HomeworkResults.Count][];
            // populate x
            for(int i = 0; i < HomeworkResults.Count; i++)
            {
                x[i] = new double[3];
            }
            double[] y = new double[FinalResults.Count];
            Console.WriteLine(HomeworkResults.Count);
            Console.WriteLine(HomeworkResults[1]);
            for (int i = 0; i < HomeworkResults.Count; i++)
            {
                x[i][0] = HomeworkResults[i];
                x[i][1] = MockResults[i];
                x[i][2] = MTGResults[i];
                y[i] = FinalResults[i];
            }
            return Fit.MultiDim(x, y, intercept: true);
            //return null;
        }

        double calculateGrade(double[] grades)
        {
            // get p
            double[] p = calculateCoefficient();
            // just checking coeff values to make sure
            Debug.WriteLine(p.Length);
            Debug.WriteLine(p[0]);
            Debug.WriteLine(p[1]);
            Debug.WriteLine(p[2]);
            Debug.WriteLine(p[3]);
            // using that y = algoritm, p[0] is always the constant
            double predict = p[0] + p[1] * grades[0] + p[2] * grades[1] + p[3] * grades[2];
            Debug.WriteLine(predict);
            return predict;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gradeLetter;
            double[] grades = { 0, 0, 0 };
            try
            {
                grades[0] = Grades[homeworkBox.Text];
                grades[1] = Grades[mockBox.Text];
                grades[2] = Grades[mtgBox.Text];
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessageBox.Show("Please make sure you have inputted results into your grade boxes.");
            }
            double grade = calculateGrade(grades);
            //more ugly rounding code?
            if (grade > 8.5)
            {
                gradeLetter = "A*";
            }
            else if (grade > 7.5)
            {
                gradeLetter = "A";
            }
            else if (grade > 6.5)
            {
                gradeLetter = "B";
            }
            else if (grade > 5.5)
            {
                gradeLetter = "C";
            }
            else if (grade > 4.5)
            {
                gradeLetter = "D";
            }
            else if (grade > 3.0)
            {
                gradeLetter = "E";
            }
            else
            {
                gradeLetter = "U";
            }
            gradeLabel.Text = "Predicted grade: " + gradeLetter;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calculateCoefficient();
        }
    }
}