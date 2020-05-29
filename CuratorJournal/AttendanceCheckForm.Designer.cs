namespace CuratorJournal
{
    partial class AttendanceCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceCheck));
            this.lTitle = new System.Windows.Forms.Label();
            this.dgvMeeting = new System.Windows.Forms.DataGridView();
            this.panelMeeting = new System.Windows.Forms.Panel();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSaveStudent = new System.Windows.Forms.Button();
            this.lDescr = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lStudent = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbDecision = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTimePickerAttendance = new System.Windows.Forms.DateTimePicker();
            this.bAddMeeting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).BeginInit();
            this.panelMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(49, -4);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(495, 28);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "Проверка посещаемости занятий студентами";
            // 
            // dgvMeeting
            // 
            this.dgvMeeting.AllowUserToAddRows = false;
            this.dgvMeeting.AllowUserToDeleteRows = false;
            this.dgvMeeting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeeting.Location = new System.Drawing.Point(34, 40);
            this.dgvMeeting.Name = "dgvMeeting";
            this.dgvMeeting.ReadOnly = true;
            this.dgvMeeting.RowHeadersVisible = false;
            this.dgvMeeting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMeeting.Size = new System.Drawing.Size(445, 150);
            this.dgvMeeting.TabIndex = 33;
            // 
            // panelMeeting
            // 
            this.panelMeeting.Controls.Add(this.bDelete);
            this.panelMeeting.Controls.Add(this.bSaveStudent);
            this.panelMeeting.Controls.Add(this.lDescr);
            this.panelMeeting.Controls.Add(this.dgvStudent);
            this.panelMeeting.Controls.Add(this.lStudent);
            this.panelMeeting.Controls.Add(this.lQuestion);
            this.panelMeeting.Controls.Add(this.tbQuestion);
            this.panelMeeting.Controls.Add(this.tbDecision);
            this.panelMeeting.Controls.Add(this.lDate);
            this.panelMeeting.Controls.Add(this.dateTimePickerAttendance);
            this.panelMeeting.Location = new System.Drawing.Point(34, 208);
            this.panelMeeting.Name = "panelMeeting";
            this.panelMeeting.Size = new System.Drawing.Size(510, 595);
            this.panelMeeting.TabIndex = 34;
            this.panelMeeting.Visible = false;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(3, 540);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(133, 43);
            this.bDelete.TabIndex = 39;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            // 
            // bSaveStudent
            // 
            this.bSaveStudent.Location = new System.Drawing.Point(3, 491);
            this.bSaveStudent.Name = "bSaveStudent";
            this.bSaveStudent.Size = new System.Drawing.Size(133, 43);
            this.bSaveStudent.TabIndex = 38;
            this.bSaveStudent.Text = "Сохранить";
            this.bSaveStudent.UseVisualStyleBackColor = true;
            // 
            // lDescr
            // 
            this.lDescr.AutoSize = true;
            this.lDescr.Location = new System.Drawing.Point(248, 116);
            this.lDescr.Name = "lDescr";
            this.lDescr.Size = new System.Drawing.Size(103, 13);
            this.lDescr.TabIndex = 9;
            this.lDescr.Text = "Принятое решение";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(142, 197);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudent.Size = new System.Drawing.Size(345, 391);
            this.dgvStudent.TabIndex = 37;
            // 
            // lStudent
            // 
            this.lStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStudent.AutoSize = true;
            this.lStudent.Location = new System.Drawing.Point(6, 197);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(137, 13);
            this.lStudent.TabIndex = 36;
            this.lStudent.Text = "Отсутствующие студенты";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(3, 116);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(129, 13);
            this.lQuestion.TabIndex = 8;
            this.lQuestion.Text = "Вопрос для обсуждения";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 132);
            this.tbQuestion.MaxLength = 300;
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(236, 59);
            this.tbQuestion.TabIndex = 7;
            // 
            // tbDecision
            // 
            this.tbDecision.Location = new System.Drawing.Point(251, 132);
            this.tbDecision.MaxLength = 300;
            this.tbDecision.Multiline = true;
            this.tbDecision.Name = "tbDecision";
            this.tbDecision.Size = new System.Drawing.Size(236, 59);
            this.tbDecision.TabIndex = 6;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(6, 15);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(96, 13);
            this.lDate.TabIndex = 5;
            this.lDate.Text = "Дата проведения";
            // 
            // dateTimePickerAttendance
            // 
            this.dateTimePickerAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAttendance.Location = new System.Drawing.Point(125, 9);
            this.dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            this.dateTimePickerAttendance.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerAttendance.TabIndex = 4;
            // 
            // bAddMeeting
            // 
            this.bAddMeeting.Image = ((System.Drawing.Image)(resources.GetObject("bAddMeeting.Image")));
            this.bAddMeeting.Location = new System.Drawing.Point(501, 40);
            this.bAddMeeting.Name = "bAddMeeting";
            this.bAddMeeting.Size = new System.Drawing.Size(43, 23);
            this.bAddMeeting.TabIndex = 40;
            this.bAddMeeting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddMeeting.UseVisualStyleBackColor = true;
            // 
            // AttendanceCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(611, 509);
            this.Controls.Add(this.bAddMeeting);
            this.Controls.Add(this.panelMeeting);
            this.Controls.Add(this.dgvMeeting);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AttendanceCheck";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).EndInit();
            this.panelMeeting.ResumeLayout(false);
            this.panelMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.DataGridView dgvMeeting;
        private System.Windows.Forms.Panel panelMeeting;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAttendance;
        private System.Windows.Forms.Label lDescr;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbDecision;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button bSaveStudent;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bAddMeeting;
    }
}
