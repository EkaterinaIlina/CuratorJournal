namespace CuratorJournal
{
    partial class AttendanceCheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceCheckForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.bAddAttendance = new System.Windows.Forms.Button();
            this.dateTimePickerAttendance = new System.Windows.Forms.DateTimePicker();
            this.lDate = new System.Windows.Forms.Label();
            this.lStudent = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.bSaveStudent = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.comboBoxDiscpline = new System.Windows.Forms.ComboBox();
            this.comboBoxOccup = new System.Windows.Forms.ComboBox();
            this.textBoxFullNamePrep = new System.Windows.Forms.TextBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelOccup = new System.Windows.Forms.Label();
            this.labelFullNamePrep = new System.Windows.Forms.Label();
            this.panelAttendance = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panelAttendance.SuspendLayout();
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
            // dgvAttendance
            // 
            this.dgvAttendance.AllowUserToAddRows = false;
            this.dgvAttendance.AllowUserToDeleteRows = false;
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(34, 40);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.ReadOnly = true;
            this.dgvAttendance.RowHeadersVisible = false;
            this.dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAttendance.Size = new System.Drawing.Size(445, 150);
            this.dgvAttendance.TabIndex = 33;
            this.dgvAttendance.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAttendance_CellMouseClick);
            // 
            // bAddAttendance
            // 
            this.bAddAttendance.Image = ((System.Drawing.Image)(resources.GetObject("bAddAttendance.Image")));
            this.bAddAttendance.Location = new System.Drawing.Point(501, 40);
            this.bAddAttendance.Name = "bAddAttendance";
            this.bAddAttendance.Size = new System.Drawing.Size(43, 23);
            this.bAddAttendance.TabIndex = 40;
            this.bAddAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddAttendance.UseVisualStyleBackColor = true;
            this.bAddAttendance.Click += new System.EventHandler(this.bAddAttendance_Click);
            // 
            // dateTimePickerAttendance
            // 
            this.dateTimePickerAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAttendance.Location = new System.Drawing.Point(142, 9);
            this.dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            this.dateTimePickerAttendance.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerAttendance.TabIndex = 4;
            this.dateTimePickerAttendance.ValueChanged += new System.EventHandler(this.dateTimePickerAttendance_ValueChanged);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(3, 15);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(96, 13);
            this.lDate.TabIndex = 5;
            this.lDate.Text = "Дата проведения";
            // 
            // lStudent
            // 
            this.lStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStudent.AutoSize = true;
            this.lStudent.Location = new System.Drawing.Point(3, 116);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(137, 13);
            this.lStudent.TabIndex = 36;
            this.lStudent.Text = "Отсутствующие студенты";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(142, 116);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudent.Size = new System.Drawing.Size(345, 391);
            this.dgvStudent.TabIndex = 37;
            // 
            // bSaveStudent
            // 
            this.bSaveStudent.Location = new System.Drawing.Point(3, 415);
            this.bSaveStudent.Name = "bSaveStudent";
            this.bSaveStudent.Size = new System.Drawing.Size(133, 43);
            this.bSaveStudent.TabIndex = 38;
            this.bSaveStudent.Text = "Сохранить";
            this.bSaveStudent.UseVisualStyleBackColor = true;
            this.bSaveStudent.Click += new System.EventHandler(this.bSaveStudent_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(3, 464);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(133, 43);
            this.bDelete.TabIndex = 39;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // comboBoxDiscpline
            // 
            this.comboBoxDiscpline.FormattingEnabled = true;
            this.comboBoxDiscpline.Location = new System.Drawing.Point(142, 35);
            this.comboBoxDiscpline.MaxLength = 25;
            this.comboBoxDiscpline.Name = "comboBoxDiscpline";
            this.comboBoxDiscpline.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDiscpline.TabIndex = 41;
            this.comboBoxDiscpline.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscpline_SelectedIndexChanged);
            // 
            // comboBoxOccup
            // 
            this.comboBoxOccup.FormattingEnabled = true;
            this.comboBoxOccup.Location = new System.Drawing.Point(142, 62);
            this.comboBoxOccup.MaxLength = 25;
            this.comboBoxOccup.Name = "comboBoxOccup";
            this.comboBoxOccup.Size = new System.Drawing.Size(189, 21);
            this.comboBoxOccup.TabIndex = 42;
            this.comboBoxOccup.SelectedIndexChanged += new System.EventHandler(this.comboBoxOccup_SelectedIndexChanged);
            // 
            // textBoxFullNamePrep
            // 
            this.textBoxFullNamePrep.Location = new System.Drawing.Point(142, 90);
            this.textBoxFullNamePrep.MaxLength = 100;
            this.textBoxFullNamePrep.Name = "textBoxFullNamePrep";
            this.textBoxFullNamePrep.Size = new System.Drawing.Size(290, 20);
            this.textBoxFullNamePrep.TabIndex = 43;
            this.textBoxFullNamePrep.TextChanged += new System.EventHandler(this.textBoxFullNamePrep_TextChanged);
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(3, 38);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(70, 13);
            this.labelDiscipline.TabIndex = 44;
            this.labelDiscipline.Text = "Дисциплина";
            // 
            // labelOccup
            // 
            this.labelOccup.AutoSize = true;
            this.labelOccup.Location = new System.Drawing.Point(3, 65);
            this.labelOccup.Name = "labelOccup";
            this.labelOccup.Size = new System.Drawing.Size(85, 13);
            this.labelOccup.TabIndex = 45;
            this.labelOccup.Text = "Статус занятия";
            // 
            // labelFullNamePrep
            // 
            this.labelFullNamePrep.AutoSize = true;
            this.labelFullNamePrep.Location = new System.Drawing.Point(3, 93);
            this.labelFullNamePrep.Name = "labelFullNamePrep";
            this.labelFullNamePrep.Size = new System.Drawing.Size(114, 13);
            this.labelFullNamePrep.TabIndex = 46;
            this.labelFullNamePrep.Text = "ФИО преподавателя";
            // 
            // panelAttendance
            // 
            this.panelAttendance.Controls.Add(this.labelFullNamePrep);
            this.panelAttendance.Controls.Add(this.labelOccup);
            this.panelAttendance.Controls.Add(this.labelDiscipline);
            this.panelAttendance.Controls.Add(this.textBoxFullNamePrep);
            this.panelAttendance.Controls.Add(this.comboBoxOccup);
            this.panelAttendance.Controls.Add(this.comboBoxDiscpline);
            this.panelAttendance.Controls.Add(this.bDelete);
            this.panelAttendance.Controls.Add(this.bSaveStudent);
            this.panelAttendance.Controls.Add(this.dgvStudent);
            this.panelAttendance.Controls.Add(this.lStudent);
            this.panelAttendance.Controls.Add(this.lDate);
            this.panelAttendance.Controls.Add(this.dateTimePickerAttendance);
            this.panelAttendance.Location = new System.Drawing.Point(34, 208);
            this.panelAttendance.Name = "panelAttendance";
            this.panelAttendance.Size = new System.Drawing.Size(510, 522);
            this.panelAttendance.TabIndex = 34;
            this.panelAttendance.Visible = false;
            // 
            // AttendanceCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(628, 509);
            this.Controls.Add(this.bAddAttendance);
            this.Controls.Add(this.panelAttendance);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AttendanceCheckForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panelAttendance.ResumeLayout(false);
            this.panelAttendance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Button bAddAttendance;
        private System.Windows.Forms.DateTimePicker dateTimePickerAttendance;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button bSaveStudent;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.ComboBox comboBoxDiscpline;
        private System.Windows.Forms.ComboBox comboBoxOccup;
        private System.Windows.Forms.TextBox textBoxFullNamePrep;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelOccup;
        private System.Windows.Forms.Label labelFullNamePrep;
        private System.Windows.Forms.Panel panelAttendance;
    }
}
