namespace SearchingForStudents
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.searchStudentPage = new System.Windows.Forms.TabPage();
            this.richTextBox_showData = new System.Windows.Forms.RichTextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_ThirdCriteria = new System.Windows.Forms.TextBox();
            this.comboBox_SecondCriteria = new System.Windows.Forms.ComboBox();
            this.comboBox_FirstCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addStudentPage = new System.Windows.Forms.TabPage();
            this.button_AddStudent = new System.Windows.Forms.Button();
            this.textBox_class = new System.Windows.Forms.TextBox();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.test_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.searchStudentPage.SuspendLayout();
            this.addStudentPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.searchStudentPage);
            this.tabControl1.Controls.Add(this.addStudentPage);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // searchStudentPage
            // 
            this.searchStudentPage.Controls.Add(this.test_button);
            this.searchStudentPage.Controls.Add(this.richTextBox_showData);
            this.searchStudentPage.Controls.Add(this.button_Search);
            this.searchStudentPage.Controls.Add(this.textBox_ThirdCriteria);
            this.searchStudentPage.Controls.Add(this.comboBox_SecondCriteria);
            this.searchStudentPage.Controls.Add(this.comboBox_FirstCriteria);
            this.searchStudentPage.Controls.Add(this.label1);
            this.searchStudentPage.Location = new System.Drawing.Point(4, 22);
            this.searchStudentPage.Name = "searchStudentPage";
            this.searchStudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchStudentPage.Size = new System.Drawing.Size(797, 424);
            this.searchStudentPage.TabIndex = 0;
            this.searchStudentPage.Text = "Wyszukaj ucznia/uczniów";
            this.searchStudentPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox_showData
            // 
            this.richTextBox_showData.Location = new System.Drawing.Point(9, 185);
            this.richTextBox_showData.Name = "richTextBox_showData";
            this.richTextBox_showData.Size = new System.Drawing.Size(776, 231);
            this.richTextBox_showData.TabIndex = 6;
            this.richTextBox_showData.Text = "";
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(528, 135);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 5;
            this.button_Search.Text = "Szukaj";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_ThirdCriteria
            // 
            this.textBox_ThirdCriteria.Location = new System.Drawing.Point(528, 90);
            this.textBox_ThirdCriteria.Name = "textBox_ThirdCriteria";
            this.textBox_ThirdCriteria.Size = new System.Drawing.Size(124, 20);
            this.textBox_ThirdCriteria.TabIndex = 3;
            // 
            // comboBox_SecondCriteria
            // 
            this.comboBox_SecondCriteria.FormattingEnabled = true;
            this.comboBox_SecondCriteria.Items.AddRange(new object[] {
            "Rozpoczyna się od",
            "Zawiera",
            "Kończy się na"});
            this.comboBox_SecondCriteria.Location = new System.Drawing.Point(304, 90);
            this.comboBox_SecondCriteria.Name = "comboBox_SecondCriteria";
            this.comboBox_SecondCriteria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SecondCriteria.TabIndex = 2;
            // 
            // comboBox_FirstCriteria
            // 
            this.comboBox_FirstCriteria.FormattingEnabled = true;
            this.comboBox_FirstCriteria.Items.AddRange(new object[] {
            "Imię",
            "Nazwisko",
            "Klasa"});
            this.comboBox_FirstCriteria.Location = new System.Drawing.Point(111, 90);
            this.comboBox_FirstCriteria.Name = "comboBox_FirstCriteria";
            this.comboBox_FirstCriteria.Size = new System.Drawing.Size(121, 21);
            this.comboBox_FirstCriteria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wczytaj kryteria wyszukiwania";
            // 
            // addStudentPage
            // 
            this.addStudentPage.Controls.Add(this.button_AddStudent);
            this.addStudentPage.Controls.Add(this.textBox_class);
            this.addStudentPage.Controls.Add(this.textBox_surname);
            this.addStudentPage.Controls.Add(this.textBox_name);
            this.addStudentPage.Controls.Add(this.label4);
            this.addStudentPage.Controls.Add(this.label3);
            this.addStudentPage.Controls.Add(this.label2);
            this.addStudentPage.Location = new System.Drawing.Point(4, 22);
            this.addStudentPage.Name = "addStudentPage";
            this.addStudentPage.Padding = new System.Windows.Forms.Padding(3);
            this.addStudentPage.Size = new System.Drawing.Size(797, 424);
            this.addStudentPage.TabIndex = 1;
            this.addStudentPage.Text = "Dodaj ucznia";
            this.addStudentPage.UseVisualStyleBackColor = true;
            // 
            // button_AddStudent
            // 
            this.button_AddStudent.Location = new System.Drawing.Point(398, 254);
            this.button_AddStudent.Name = "button_AddStudent";
            this.button_AddStudent.Size = new System.Drawing.Size(127, 29);
            this.button_AddStudent.TabIndex = 6;
            this.button_AddStudent.Text = "Dodaj";
            this.button_AddStudent.UseVisualStyleBackColor = true;
            this.button_AddStudent.Click += new System.EventHandler(this.button_AddStudent_Click);
            // 
            // textBox_class
            // 
            this.textBox_class.Location = new System.Drawing.Point(197, 182);
            this.textBox_class.Name = "textBox_class";
            this.textBox_class.Size = new System.Drawing.Size(265, 20);
            this.textBox_class.TabIndex = 5;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(197, 115);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(265, 20);
            this.textBox_surname.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(197, 56);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(265, 20);
            this.textBox_name.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Klasa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nazwisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Imię";
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(609, 135);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(75, 23);
            this.test_button.TabIndex = 7;
            this.test_button.Text = "Test";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.searchStudentPage.ResumeLayout(false);
            this.searchStudentPage.PerformLayout();
            this.addStudentPage.ResumeLayout(false);
            this.addStudentPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage searchStudentPage;
        private System.Windows.Forms.TabPage addStudentPage;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_ThirdCriteria;
        private System.Windows.Forms.ComboBox comboBox_SecondCriteria;
        private System.Windows.Forms.ComboBox comboBox_FirstCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_AddStudent;
        private System.Windows.Forms.TextBox textBox_class;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_showData;
        private System.Windows.Forms.Button test_button;
    }
}