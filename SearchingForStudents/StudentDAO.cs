using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingForStudents
{
    internal class StudentDAO
    {
        public List<Student> students = new List<Student>();
        SqlConnection conn = new SqlConnection("user id=root;" +
                                       "password=;server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=baza; " +
                                       "connection timeout=30");

        public void openConn()
        {
            conn.Open();
        }
    }
}
