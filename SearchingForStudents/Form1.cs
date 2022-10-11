using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchingForStudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class User
        {
            private string _username = "admin";
            private string _password = "Qwerty1@34";
            
            public string Username { get => _username; }
            public string Password { get => _password; }
        }

        (Image, string)[] imagesWithCodes =
            {
                (SearchingForStudents.Properties.Resources._1, "mxyxw"),
                (SearchingForStudents.Properties.Resources._2, "b5nmm"),
                (SearchingForStudents.Properties.Resources._3, "74853"),
                (SearchingForStudents.Properties.Resources._4, "cg5dd"),
                (SearchingForStudents.Properties.Resources._5, "x3deb"),
                (SearchingForStudents.Properties.Resources._6, "befbd"),
                (SearchingForStudents.Properties.Resources._7, "c7gb3")
            };

        int correctImgWithCode = 0;

        private void linkChangePic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            var rand = new Random();
            var los = rand.Next(imagesWithCodes.Length);
            pictureBox_CodePic.Image = imagesWithCodes[los].Item1;
            correctImgWithCode = los;
            
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            if (textBox_Code.Text == imagesWithCodes[correctImgWithCode].Item2 && textBox_UserName.Text == user.Username
                && textBox_Pass.Text == user.Password)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Closed += (s, args) => this.Close();
                form2.Show();

            }
            else MessageBox.Show("Bad Data or Empty Form");
        }

        private void log_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
