using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SearchingForStudents.Form1;
using static System.Net.Mime.MediaTypeNames;

namespace SearchingForStudents
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string[] readFile(string textFile)
        {  
            string[] lines = File.ReadAllLines(textFile);
            return lines;
        }

        public void writeFile(string textFile, string text)
        {
            using (StreamWriter sw = new StreamWriter(textFile, true))
            {
                sw.WriteLine(text);
            }
        }

        public bool checkContains(string allWord, string partWord, int optionNum)
        {
            string regex;
            switch (optionNum)
            {
                case 0:     // startsWith
                    regex = $"^{partWord}.+$";
                    break;
                case 1:     // contains
                    regex = $"^\\w*{partWord}\\w*$";
                    break;
                case 2:     // endsWith
                    regex = $"^.+{partWord}$";
                    break;
                default:
                    regex = "";
                    break;
            }
            Regex rx = new Regex(regex,
            RegexOptions.Compiled | RegexOptions.IgnoreCase);

            return rx.IsMatch(allWord);
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string searchedNames = "";
            int namePart = comboBox_FirstCriteria.SelectedIndex;
            int optionNum = comboBox_SecondCriteria.SelectedIndex;
            string path = "C:\\Users\\student\\Source\\Repos\\Filippo0420\\SearchingForStudents\\SearchingForStudents\\Data\\uczen.txt";
            string[] names = readFile(path);
            foreach(string name in names){
                string toCheck = name.Split(' ')[namePart];
                if (checkContains(toCheck, textBox_ThirdCriteria.Text, optionNum)) searchedNames += $"{name}\n";
            }
            richTextBox_showData.Text = searchedNames;
        }

        private void button_AddStudent_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\student\\Source\\Repos\\Filippo0420\\SearchingForStudents\\SearchingForStudents\\Data\\uczen.txt";

            writeFile(path, $"{textBox_name.Text} {textBox_surname.Text} {textBox_class.Text}");
            MessageBox.Show("Dodano");
        }

        private void test_button_Click(object sender, EventArgs e)
        {
            StudentDAO dao = new StudentDAO();
            Student student = new Student
            {
                Id = 1,
                Name = "Kacper",
                Surname = "Pawlak",
                Class = "4Pr"
            };
            dao.students.Add(student);
            try
            {
                dao.openConn();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
