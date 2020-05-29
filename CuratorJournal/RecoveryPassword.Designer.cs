namespace CuratorJournal
{
    partial class RecoveryPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryPassword));
            this.panelRecovery = new System.Windows.Forms.Panel();
            this.lQuestion = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.buttonOnward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.lAnswer = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.bOnwardCheck = new System.Windows.Forms.Button();
            this.panelRecovery.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRecovery
            // 
            this.panelRecovery.Controls.Add(this.bOnwardCheck);
            this.panelRecovery.Controls.Add(this.tbAnswer);
            this.panelRecovery.Controls.Add(this.lAnswer);
            this.panelRecovery.Controls.Add(this.tbQuestion);
            this.panelRecovery.Controls.Add(this.lQuestion);
            this.panelRecovery.Location = new System.Drawing.Point(203, 0);
            this.panelRecovery.Name = "panelRecovery";
            this.panelRecovery.Size = new System.Drawing.Size(223, 227);
            this.panelRecovery.TabIndex = 0;
            this.panelRecovery.Visible = false;
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(3, 12);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(190, 13);
            this.lQuestion.TabIndex = 2;
            this.lQuestion.Text = "Вопрос для восстановления пароля";
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Location = new System.Drawing.Point(21, 63);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(155, 13);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Введите логин пользователя";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(7, 93);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(182, 20);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // buttonOnward
            // 
            this.buttonOnward.Location = new System.Drawing.Point(114, 138);
            this.buttonOnward.Name = "buttonOnward";
            this.buttonOnward.Size = new System.Drawing.Size(75, 23);
            this.buttonOnward.TabIndex = 3;
            this.buttonOnward.Text = "Далее";
            this.buttonOnward.UseVisualStyleBackColor = true;
            this.buttonOnward.Click += new System.EventHandler(this.buttonOnward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(7, 138);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Baskerville Old Face", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(37, 12);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(124, 36);
            this.lTitle.TabIndex = 20;
            this.lTitle.Text = "Восстановление \r\n      пароля       \r\n";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 28);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(207, 72);
            this.tbQuestion.TabIndex = 3;
            // 
            // lAnswer
            // 
            this.lAnswer.AutoSize = true;
            this.lAnswer.Location = new System.Drawing.Point(3, 103);
            this.lAnswer.Name = "lAnswer";
            this.lAnswer.Size = new System.Drawing.Size(91, 13);
            this.lAnswer.TabIndex = 4;
            this.lAnswer.Text = "Ответ на вопрос";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(6, 119);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(207, 68);
            this.tbAnswer.TabIndex = 21;
            // 
            // bOnwardCheck
            // 
            this.bOnwardCheck.Location = new System.Drawing.Point(138, 195);
            this.bOnwardCheck.Name = "bOnwardCheck";
            this.bOnwardCheck.Size = new System.Drawing.Size(75, 23);
            this.bOnwardCheck.TabIndex = 22;
            this.bOnwardCheck.Text = "Далее";
            this.bOnwardCheck.UseVisualStyleBackColor = true;
            this.bOnwardCheck.Click += new System.EventHandler(this.bOnwardCheck_Click);
            // 
            // RecoveryPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 230);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOnward);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.panelRecovery);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RecoveryPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelRecovery.ResumeLayout(false);
            this.panelRecovery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRecovery;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button buttonOnward;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lAnswer;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Button bOnwardCheck;
    }
}