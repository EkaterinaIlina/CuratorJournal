namespace CuratorJournal
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.bEnter = new System.Windows.Forms.Button();
            this.linkLReg = new System.Windows.Forms.LinkLabel();
            this.lTitle = new System.Windows.Forms.Label();
            this.linkLabelRecovery = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(12, 57);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(38, 13);
            this.lLogin.TabIndex = 0;
            this.lLogin.Text = "Логин";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(12, 84);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(45, 13);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(93, 54);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(178, 20);
            this.tbLogin.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(93, 81);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(178, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // bEnter
            // 
            this.bEnter.Location = new System.Drawing.Point(15, 122);
            this.bEnter.Name = "bEnter";
            this.bEnter.Size = new System.Drawing.Size(75, 23);
            this.bEnter.TabIndex = 4;
            this.bEnter.Text = "Войти";
            this.bEnter.UseVisualStyleBackColor = true;
            this.bEnter.Click += new System.EventHandler(this.bEnter_Click);
            // 
            // linkLReg
            // 
            this.linkLReg.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLReg.AutoSize = true;
            this.linkLReg.Location = new System.Drawing.Point(109, 127);
            this.linkLReg.Name = "linkLReg";
            this.linkLReg.Size = new System.Drawing.Size(72, 13);
            this.linkLReg.TabIndex = 5;
            this.linkLReg.TabStop = true;
            this.linkLReg.Text = "Регистрация";
            this.linkLReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLReg_LinkClicked);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Baskerville Old Face", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(35, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(236, 34);
            this.lTitle.TabIndex = 19;
            this.lTitle.Text = "Вход в систему";
            // 
            // linkLabelRecovery
            // 
            this.linkLabelRecovery.ActiveLinkColor = System.Drawing.Color.Blue;
            this.linkLabelRecovery.AutoSize = true;
            this.linkLabelRecovery.Location = new System.Drawing.Point(193, 127);
            this.linkLabelRecovery.Name = "linkLabelRecovery";
            this.linkLabelRecovery.Size = new System.Drawing.Size(91, 13);
            this.linkLabelRecovery.TabIndex = 20;
            this.linkLabelRecovery.TabStop = true;
            this.linkLabelRecovery.Text = "Забыли пароль?";
            this.linkLabelRecovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRecovery_LinkClicked);
            // 
            // Authorization
            // 
            this.AcceptButton = this.bEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 157);
            this.Controls.Add(this.linkLabelRecovery);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.linkLReg);
            this.Controls.Add(this.bEnter);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.lLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button bEnter;
        private System.Windows.Forms.LinkLabel linkLReg;
        private System.Windows.Forms.Label lTitle; 
        private System.Windows.Forms.LinkLabel linkLabelRecovery;
    }
}

