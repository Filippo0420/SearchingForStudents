﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SearchingForStudents
{
    internal class StudentDAO
    {
        public void connectToDatabase()
        {
            
        }

        public void create(Student student)
        {
            String str = "Server=localhost\\SQLEXPRESS2019;Integrated Security=True;Database=StudentsDatabase";

            SqlConnection con = new SqlConnection(str);

            String query = $"INSERT INTO Students (Name, Surname, Class) VALUES ({student.Name}, {student.Surname}, {student.Class})";

            //SqlCommand cmd = new SqlCommand(query, con);

            con.Open();

            DataSet ds = new DataSet();

            MessageBox.Show("connected with sql server");

            con.Close();


        }

        public List<Student> select()
        {
            List<Student> students = new List<Student>();




            return students;
        }
    }
}
