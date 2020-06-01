namespace CuratorJournal
{
    partial class MeetingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeetingForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.bAddMeeting = new System.Windows.Forms.Button();
            this.dgvMeeting = new System.Windows.Forms.DataGridView();
            this.panelMeeting = new System.Windows.Forms.Panel();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.lDescr = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lStudent = new System.Windows.Forms.Label();
            this.lQuestion = new System.Windows.Forms.Label();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbDecision = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTimePickerMeeting = new System.Windows.Forms.DateTimePicker();
            this.lType = new System.Windows.Forms.Label();
            this.tableLayoutPanelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonPlanNo = new System.Windows.Forms.RadioButton();
            this.radioButtonPlan = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelType = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonHourInf = new System.Windows.Forms.RadioButton();
            this.radioButtonHourEduc = new System.Windows.Forms.RadioButton();
            this.lStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).BeginInit();
            this.panelMeeting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tableLayoutPanelStatus.SuspendLayout();
            this.tableLayoutPanelType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(188, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(214, 28);
            this.lTitle.TabIndex = 3;
            this.lTitle.Text = "Собрания в группе";
            // 
            // bAddMeeting
            // 
            this.bAddMeeting.Image = ((System.Drawing.Image)(resources.GetObject("bAddMeeting.Image")));
            this.bAddMeeting.Location = new System.Drawing.Point(485, 40);
            this.bAddMeeting.Name = "bAddMeeting";
            this.bAddMeeting.Size = new System.Drawing.Size(43, 23);
            this.bAddMeeting.TabIndex = 32;
            this.bAddMeeting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddMeeting.UseVisualStyleBackColor = true;
            this.bAddMeeting.Click += new System.EventHandler(this.bAddMeeting_Click);
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
            this.dgvMeeting.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMeeting_CellMouseClick);
            // 
            // panelMeeting
            // 
            this.panelMeeting.Controls.Add(this.bDelete);
            this.panelMeeting.Controls.Add(this.bSave);
            this.panelMeeting.Controls.Add(this.lDescr);
            this.panelMeeting.Controls.Add(this.dgvStudent);
            this.panelMeeting.Controls.Add(this.lStudent);
            this.panelMeeting.Controls.Add(this.lQuestion);
            this.panelMeeting.Controls.Add(this.tbQuestion);
            this.panelMeeting.Controls.Add(this.tbDecision);
            this.panelMeeting.Controls.Add(this.lDate);
            this.panelMeeting.Controls.Add(this.dateTimePickerMeeting);
            this.panelMeeting.Controls.Add(this.lType);
            this.panelMeeting.Controls.Add(this.tableLayoutPanelStatus);
            this.panelMeeting.Controls.Add(this.tableLayoutPanelType);
            this.panelMeeting.Controls.Add(this.lStatus);
            this.panelMeeting.Location = new System.Drawing.Point(34, 208);
            this.panelMeeting.Name = "panelMeeting";
            this.panelMeeting.Size = new System.Drawing.Size(510, 595);
            this.panelMeeting.TabIndex = 34;
            this.panelMeeting.Visible = false;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(3, 555);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(133, 28);
            this.bDelete.TabIndex = 39;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(3, 520);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(133, 28);
            this.bSave.TabIndex = 38;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lDescr
            // 
            this.lDescr.AutoSize = true;
            this.lDescr.Location = new System.Drawing.Point(248, 116);
            this.lDescr.Name = "lDescr";
            this.lDescr.Size = new System.Drawing.Size(107, 13);
            this.lDescr.TabIndex = 9;
            this.lDescr.Text = "Принятое решение*";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(142, 222);
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
            this.lStudent.Location = new System.Drawing.Point(3, 206);
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
            this.lQuestion.Size = new System.Drawing.Size(133, 13);
            this.lQuestion.TabIndex = 8;
            this.lQuestion.Text = "Вопрос для обсуждения*";
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(6, 132);
            this.tbQuestion.MaxLength = 300;
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(236, 59);
            this.tbQuestion.TabIndex = 7;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // tbDecision
            // 
            this.tbDecision.Location = new System.Drawing.Point(251, 132);
            this.tbDecision.MaxLength = 300;
            this.tbDecision.Multiline = true;
            this.tbDecision.Name = "tbDecision";
            this.tbDecision.Size = new System.Drawing.Size(236, 59);
            this.tbDecision.TabIndex = 6;
            this.tbDecision.TextChanged += new System.EventHandler(this.tbDecision_TextChanged);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(3, 86);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(96, 13);
            this.lDate.TabIndex = 5;
            this.lDate.Text = "Дата проведения";
            // 
            // dateTimePickerMeeting
            // 
            this.dateTimePickerMeeting.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMeeting.Location = new System.Drawing.Point(105, 83);
            this.dateTimePickerMeeting.Name = "dateTimePickerMeeting";
            this.dateTimePickerMeeting.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerMeeting.TabIndex = 4;
            this.dateTimePickerMeeting.ValueChanged += new System.EventHandler(this.dateTimePickerMeeting_ValueChanged);
            // 
            // lType
            // 
            this.lType.AutoSize = true;
            this.lType.Location = new System.Drawing.Point(3, 50);
            this.lType.Name = "lType";
            this.lType.Size = new System.Drawing.Size(77, 13);
            this.lType.TabIndex = 3;
            this.lType.Text = "Тип собрания";
            // 
            // tableLayoutPanelStatus
            // 
            this.tableLayoutPanelStatus.ColumnCount = 2;
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStatus.Controls.Add(this.radioButtonPlanNo, 1, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.radioButtonPlan, 0, 0);
            this.tableLayoutPanelStatus.Location = new System.Drawing.Point(105, 3);
            this.tableLayoutPanelStatus.Name = "tableLayoutPanelStatus";
            this.tableLayoutPanelStatus.RowCount = 1;
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStatus.Size = new System.Drawing.Size(287, 27);
            this.tableLayoutPanelStatus.TabIndex = 2;
            // 
            // radioButtonPlanNo
            // 
            this.radioButtonPlanNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPlanNo.AutoSize = true;
            this.radioButtonPlanNo.Checked = true;
            this.radioButtonPlanNo.Location = new System.Drawing.Point(146, 5);
            this.radioButtonPlanNo.Name = "radioButtonPlanNo";
            this.radioButtonPlanNo.Size = new System.Drawing.Size(138, 17);
            this.radioButtonPlanNo.TabIndex = 1;
            this.radioButtonPlanNo.TabStop = true;
            this.radioButtonPlanNo.Text = "Незапланированное";
            this.radioButtonPlanNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlan
            // 
            this.radioButtonPlan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonPlan.AutoSize = true;
            this.radioButtonPlan.Location = new System.Drawing.Point(3, 5);
            this.radioButtonPlan.Name = "radioButtonPlan";
            this.radioButtonPlan.Size = new System.Drawing.Size(137, 17);
            this.radioButtonPlan.TabIndex = 0;
            this.radioButtonPlan.Text = "Запланированное";
            this.radioButtonPlan.UseVisualStyleBackColor = true;
            this.radioButtonPlan.CheckedChanged += new System.EventHandler(this.radioButtonPlan_CheckedChanged);
            // 
            // tableLayoutPanelType
            // 
            this.tableLayoutPanelType.ColumnCount = 2;
            this.tableLayoutPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelType.Controls.Add(this.radioButtonHourInf, 0, 0);
            this.tableLayoutPanelType.Controls.Add(this.radioButtonHourEduc, 1, 0);
            this.tableLayoutPanelType.Location = new System.Drawing.Point(105, 36);
            this.tableLayoutPanelType.Name = "tableLayoutPanelType";
            this.tableLayoutPanelType.RowCount = 1;
            this.tableLayoutPanelType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelType.Size = new System.Drawing.Size(287, 41);
            this.tableLayoutPanelType.TabIndex = 1;
            // 
            // radioButtonHourInf
            // 
            this.radioButtonHourInf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonHourInf.AutoSize = true;
            this.radioButtonHourInf.Location = new System.Drawing.Point(3, 5);
            this.radioButtonHourInf.Name = "radioButtonHourInf";
            this.radioButtonHourInf.Size = new System.Drawing.Size(137, 30);
            this.radioButtonHourInf.TabIndex = 2;
            this.radioButtonHourInf.Text = "Информационные \r\nчасы";
            this.radioButtonHourInf.UseVisualStyleBackColor = true;
            this.radioButtonHourInf.CheckedChanged += new System.EventHandler(this.radioButtonHourInf_CheckedChanged);
            // 
            // radioButtonHourEduc
            // 
            this.radioButtonHourEduc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonHourEduc.AutoSize = true;
            this.radioButtonHourEduc.Checked = true;
            this.radioButtonHourEduc.Location = new System.Drawing.Point(146, 5);
            this.radioButtonHourEduc.Name = "radioButtonHourEduc";
            this.radioButtonHourEduc.Size = new System.Drawing.Size(138, 30);
            this.radioButtonHourEduc.TabIndex = 1;
            this.radioButtonHourEduc.TabStop = true;
            this.radioButtonHourEduc.Text = "Воспитательные\r\nчасы\r\n";
            this.radioButtonHourEduc.UseVisualStyleBackColor = true;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(3, 10);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(92, 13);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Статус собрания";
            // 
            // MeetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(594, 509);
            this.Controls.Add(this.panelMeeting);
            this.Controls.Add(this.dgvMeeting);
            this.Controls.Add(this.bAddMeeting);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MeetingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeeting)).EndInit();
            this.panelMeeting.ResumeLayout(false);
            this.panelMeeting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tableLayoutPanelStatus.ResumeLayout(false);
            this.tableLayoutPanelStatus.PerformLayout();
            this.tableLayoutPanelType.ResumeLayout(false);
            this.tableLayoutPanelType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bAddMeeting;
        private System.Windows.Forms.DataGridView dgvMeeting;
        private System.Windows.Forms.Panel panelMeeting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatus;
        private System.Windows.Forms.RadioButton radioButtonPlanNo;
        private System.Windows.Forms.RadioButton radioButtonPlan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelType;
        private System.Windows.Forms.RadioButton radioButtonHourInf;
        private System.Windows.Forms.RadioButton radioButtonHourEduc;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lType;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerMeeting;
        private System.Windows.Forms.Label lDescr;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbDecision;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bDelete;
    }
}