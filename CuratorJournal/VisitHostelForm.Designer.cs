namespace CuratorJournal
{
    partial class VisitHostelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitHostelForm));
            this.bAddMeeting = new System.Windows.Forms.Button();
            this.panelMeeting = new System.Windows.Forms.Panel();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSaveStudent = new System.Windows.Forms.Button();
            this.lStudent = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dateTimePickerAttendance = new System.Windows.Forms.DateTimePicker();
            this.dgvMeeting = new System.Windows.Forms.DataGridView();
            this.lTitle = new System.Windows.Forms.Label();
            this.panelMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddMeeting
            // 
            this.bAddMeeting.Image = ((System.Drawing.Image)(resources.GetObject("bAddMeeting.Image")));
            this.bAddMeeting.Location = new System.Drawing.Point(4, 64);
            this.bAddMeeting.Name = "bAddMeeting";
            this.bAddMeeting.Size = new System.Drawing.Size(43, 23);
            this.bAddMeeting.TabIndex = 44;
            this.bAddMeeting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddMeeting.UseVisualStyleBackColor = true;
            // 
            // panelMeeting
            // 
            this.panelMeeting.Controls.Add(this.bDelete);
            this.panelMeeting.Controls.Add(this.bSaveStudent);
            this.panelMeeting.Controls.Add(this.lStudent);
            this.panelMeeting.Controls.Add(this.lDate);
            this.panelMeeting.Controls.Add(this.dgvStudent);
            this.panelMeeting.Controls.Add(this.dateTimePickerAttendance);
            this.panelMeeting.Location = new System.Drawing.Point(282, 64);
            this.panelMeeting.Name = "panelMeeting";
            this.panelMeeting.Size = new System.Drawing.Size(292, 459);
            this.panelMeeting.TabIndex = 43;
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
            // lStudent
            // 
            this.lStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStudent.AutoSize = true;
            this.lStudent.Location = new System.Drawing.Point(10, 148);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(137, 13);
            this.lStudent.TabIndex = 36;
            this.lStudent.Text = "Отсутствующие студенты";
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
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(13, 164);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudent.Size = new System.Drawing.Size(241, 284);
            this.dgvStudent.TabIndex = 37;
            // 
            // dateTimePickerAttendance
            // 
            this.dateTimePickerAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAttendance.Location = new System.Drawing.Point(125, 9);
            this.dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            this.dateTimePickerAttendance.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerAttendance.TabIndex = 4;
            // 
            // dgvMeeting
            // 
            this.dgvMeeting.AllowUserToAddRows = false;
            this.dgvMeeting.AllowUserToDeleteRows = false;
            this.dgvMeeting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMeeting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeeting.Location = new System.Drawing.Point(53, 64);
            this.dgvMeeting.Name = "dgvMeeting";
            this.dgvMeeting.ReadOnly = true;
            this.dgvMeeting.RowHeadersVisible = false;
            this.dgvMeeting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvMeeting.Size = new System.Drawing.Size(210, 210);
            this.dgvMeeting.TabIndex = 42;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(41, 11);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(495, 28);
            this.lTitle.TabIndex = 41;
            this.lTitle.Text = "Проверка посещаемости занятий студентами";
            // 
            // VisitHostelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.bAddMeeting);
            this.Controls.Add(this.panelMeeting);
            this.Controls.Add(this.dgvMeeting);
            this.Controls.Add(this.lTitle);
            this.Name = "VisitHostelForm";
            this.Text = "VisitHostelForm";
            this.panelMeeting.ResumeLayout(false);
            this.panelMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddMeeting;
        private System.Windows.Forms.Panel panelMeeting;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSaveStudent;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DateTimePicker dateTimePickerAttendance;
        private System.Windows.Forms.DataGridView dgvMeeting;
        private System.Windows.Forms.Label lTitle;
    }
}