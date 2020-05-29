namespace CuratorJournal
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lPathr = new System.Windows.Forms.Label();
            this.lPosition = new System.Windows.Forms.Label();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbPathr = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.bRegistration = new System.Windows.Forms.Button();
            this.lPrim = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.lQueation = new System.Windows.Forms.Label();
            this.lAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(119, 228);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(189, 20);
            this.tbPassword.TabIndex = 5;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(119, 200);
            this.tbLogin.MaxLength = 25;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(189, 20);
            this.tbLogin.TabIndex = 4;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(25, 231);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(55, 13);
            this.lPassword.TabIndex = 5;
            this.lPassword.Text = "Пароль  *";
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(25, 203);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(48, 13);
            this.lLogin.TabIndex = 4;
            this.lLogin.Text = "Логин  *";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(25, 116);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(39, 13);
            this.lName.TabIndex = 8;
            this.lName.Text = "Имя  *";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(25, 87);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(66, 13);
            this.lSurname.TabIndex = 9;
            this.lSurname.Text = "Фамилия  *";
            // 
            // lPathr
            // 
            this.lPathr.AutoSize = true;
            this.lPathr.Location = new System.Drawing.Point(25, 145);
            this.lPathr.Name = "lPathr";
            this.lPathr.Size = new System.Drawing.Size(54, 13);
            this.lPathr.TabIndex = 10;
            this.lPathr.Text = "Отчество";
            // 
            // lPosition
            // 
            this.lPosition.AutoSize = true;
            this.lPosition.Location = new System.Drawing.Point(25, 174);
            this.lPosition.Name = "lPosition";
            this.lPosition.Size = new System.Drawing.Size(75, 13);
            this.lPosition.TabIndex = 11;
            this.lPosition.Text = "Должность  *";
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(119, 171);
            this.tbPosition.MaxLength = 150;
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(189, 20);
            this.tbPosition.TabIndex = 3;
            // 
            // tbPathr
            // 
            this.tbPathr.Location = new System.Drawing.Point(119, 142);
            this.tbPathr.MaxLength = 50;
            this.tbPathr.Name = "tbPathr";
            this.tbPathr.Size = new System.Drawing.Size(189, 20);
            this.tbPathr.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(119, 113);
            this.tbName.MaxLength = 50;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(189, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(119, 84);
            this.tbSurname.MaxLength = 50;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(189, 20);
            this.tbSurname.TabIndex = 0;
            // 
            // bRegistration
            // 
            this.bRegistration.Location = new System.Drawing.Point(232, 277);
            this.bRegistration.Name = "bRegistration";
            this.bRegistration.Size = new System.Drawing.Size(120, 23);
            this.bRegistration.TabIndex = 16;
            this.bRegistration.Text = "Зарегистрировать";
            this.bRegistration.UseVisualStyleBackColor = true;
            this.bRegistration.Click += new System.EventHandler(this.bRegistration_Click);
            // 
            // lPrim
            // 
            this.lPrim.AutoSize = true;
            this.lPrim.Location = new System.Drawing.Point(423, 24);
            this.lPrim.Name = "lPrim";
            this.lPrim.Size = new System.Drawing.Size(169, 13);
            this.lPrim.TabIndex = 17;
            this.lPrim.Text = "* - обязательно для заполнения";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(23, 13);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(373, 28);
            this.lTitle.TabIndex = 18;
            this.lTitle.Text = "Регистрация нового пользователя";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(314, 75);
            this.tbQuestion.MaxLength = 150;
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(306, 84);
            this.tbQuestion.TabIndex = 19;
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(314, 183);
            this.tbAnswer.MaxLength = 150;
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(306, 77);
            this.tbAnswer.TabIndex = 20;
            // 
            // lQueation
            // 
            this.lQueation.AutoSize = true;
            this.lQueation.Location = new System.Drawing.Point(311, 53);
            this.lQueation.Name = "lQueation";
            this.lQueation.Size = new System.Drawing.Size(200, 13);
            this.lQueation.TabIndex = 21;
            this.lQueation.Text = "Вопрос для восстановления пароля  *";
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Location = new System.Drawing.Point(311, 167);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(101, 13);
            this.lAnswer.TabIndex = 22;
            this.lAnswer.Text = "Ответ на вопрос  *";
            // 
            // Registration
            // 
            this.AcceptButton = this.bRegistration;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 312);
            this.Controls.Add(this.lAnswer);
            this.Controls.Add(this.lQueation);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lPrim);
            this.Controls.Add(this.bRegistration);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbPathr);
            this.Controls.Add(this.tbPosition);
            this.Controls.Add(this.lPosition);
            this.Controls.Add(this.lPathr);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lPathr;
        private System.Windows.Forms.Label lPosition;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbPathr;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Button bRegistration;
        private System.Windows.Forms.Label lPrim;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label lQueation;
        private System.Windows.Forms.Label lAnswer;
    }
}