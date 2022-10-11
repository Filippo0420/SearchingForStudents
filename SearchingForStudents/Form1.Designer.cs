namespace SearchingForStudents
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.textBox_Code = new System.Windows.Forms.TextBox();
            this.pictureBox_CodePic = new System.Windows.Forms.PictureBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.linkChangePic = new System.Windows.Forms.LinkLabel();
            this.log_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CodePic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Użytkownik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weryfikacja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(326, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wypisz znaki które widzisz na poniższym obrazku aby kontynuować";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(175, 66);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(183, 20);
            this.textBox_UserName.TabIndex = 4;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(175, 111);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(183, 20);
            this.textBox_Pass.TabIndex = 5;
            // 
            // textBox_Code
            // 
            this.textBox_Code.Location = new System.Drawing.Point(175, 234);
            this.textBox_Code.Name = "textBox_Code";
            this.textBox_Code.Size = new System.Drawing.Size(183, 20);
            this.textBox_Code.TabIndex = 6;
            // 
            // pictureBox_CodePic
            // 
            this.pictureBox_CodePic.Image = global::SearchingForStudents.Properties.Resources._1;
            this.pictureBox_CodePic.Location = new System.Drawing.Point(42, 234);
            this.pictureBox_CodePic.Name = "pictureBox_CodePic";
            this.pictureBox_CodePic.Size = new System.Drawing.Size(100, 32);
            this.pictureBox_CodePic.TabIndex = 7;
            this.pictureBox_CodePic.TabStop = false;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(323, 314);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(75, 23);
            this.button_LogIn.TabIndex = 8;
            this.button_LogIn.Text = "Zatwierdź";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // linkChangePic
            // 
            this.linkChangePic.AutoSize = true;
            this.linkChangePic.LinkColor = System.Drawing.Color.Black;
            this.linkChangePic.Location = new System.Drawing.Point(172, 271);
            this.linkChangePic.Name = "linkChangePic";
            this.linkChangePic.Size = new System.Drawing.Size(56, 13);
            this.linkChangePic.TabIndex = 9;
            this.linkChangePic.TabStop = true;
            this.linkChangePic.Text = "losuj nowy";
            this.linkChangePic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangePic_LinkClicked);
            // 
            // log_button
            // 
            this.log_button.Location = new System.Drawing.Point(66, 313);
            this.log_button.Name = "log_button";
            this.log_button.Size = new System.Drawing.Size(75, 23);
            this.log_button.TabIndex = 10;
            this.log_button.Text = "Log in";
            this.log_button.UseVisualStyleBackColor = true;
            this.log_button.Click += new System.EventHandler(this.log_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 380);
            this.Controls.Add(this.log_button);
            this.Controls.Add(this.linkChangePic);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.pictureBox_CodePic);
            this.Controls.Add(this.textBox_Code);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sekretariat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CodePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.TextBox textBox_Code;
        private System.Windows.Forms.PictureBox pictureBox_CodePic;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.LinkLabel linkChangePic;
        private System.Windows.Forms.Button log_button;
    }
}

