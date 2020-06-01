namespace CuratorJournal
{
    partial class TalcParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalcParentForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.comboBoxStudent = new System.Windows.Forms.ComboBox();
            this.labelStudent = new System.Windows.Forms.Label();
            this.dgvTopicTalc = new System.Windows.Forms.DataGridView();
            this.bAddPrivTalc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTopic = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTimePickerTalkStudent = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.labelStatusTopic = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicTalc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(148, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(348, 28);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Работа с родителями студентов";
            // 
            // comboBoxStudent
            // 
            this.comboBoxStudent.FormattingEnabled = true;
            this.comboBoxStudent.Location = new System.Drawing.Point(153, 56);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(454, 21);
            this.comboBoxStudent.TabIndex = 5;
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(26, 59);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(105, 13);
            this.labelStudent.TabIndex = 6;
            this.labelStudent.Text = "Выберите студента";
            // 
            // dgvTopicTalc
            // 
            this.dgvTopicTalc.AllowUserToAddRows = false;
            this.dgvTopicTalc.AllowUserToDeleteRows = false;
            this.dgvTopicTalc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopicTalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopicTalc.Location = new System.Drawing.Point(29, 97);
            this.dgvTopicTalc.Name = "dgvTopicTalc";
            this.dgvTopicTalc.ReadOnly = true;
            this.dgvTopicTalc.RowHeadersVisible = false;
            this.dgvTopicTalc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTopicTalc.Size = new System.Drawing.Size(503, 128);
            this.dgvTopicTalc.TabIndex = 46;
            // 
            // bAddPrivTalc
            // 
            this.bAddPrivTalc.Image = ((System.Drawing.Image)(resources.GetObject("bAddPrivTalc.Image")));
            this.bAddPrivTalc.Location = new System.Drawing.Point(538, 97);
            this.bAddPrivTalc.Name = "bAddPrivTalc";
            this.bAddPrivTalc.Size = new System.Drawing.Size(43, 23);
            this.bAddPrivTalc.TabIndex = 48;
            this.bAddPrivTalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddPrivTalc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStatusTopic);
            this.panel1.Controls.Add(this.comboBoxTopic);
            this.panel1.Controls.Add(this.labelTopic);
            this.panel1.Controls.Add(this.textBoxTopic);
            this.panel1.Controls.Add(this.lDate);
            this.panel1.Controls.Add(this.dateTimePickerTalkStudent);
            this.panel1.Location = new System.Drawing.Point(29, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 236);
            this.panel1.TabIndex = 49;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(6, 108);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(129, 13);
            this.labelTopic.TabIndex = 45;
            this.labelTopic.Text = "Вопрос для обсуждения";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(9, 124);
            this.textBoxTopic.MaxLength = 300;
            this.textBoxTopic.Multiline = true;
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(272, 100);
            this.textBoxTopic.TabIndex = 44;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(6, 56);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(96, 13);
            this.lDate.TabIndex = 43;
            this.lDate.Text = "Дата проведения";
            // 
            // dateTimePickerTalkStudent
            // 
            this.dateTimePickerTalkStudent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTalkStudent.Location = new System.Drawing.Point(9, 72);
            this.dateTimePickerTalkStudent.Name = "dateTimePickerTalkStudent";
            this.dateTimePickerTalkStudent.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerTalkStudent.TabIndex = 42;
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(9, 23);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(272, 21);
            this.comboBoxTopic.TabIndex = 46;
            // 
            // labelStatusTopic
            // 
            this.labelStatusTopic.AutoSize = true;
            this.labelStatusTopic.Location = new System.Drawing.Point(6, 7);
            this.labelStatusTopic.Name = "labelStatusTopic";
            this.labelStatusTopic.Size = new System.Drawing.Size(139, 13);
            this.labelStatusTopic.TabIndex = 47;
            this.labelStatusTopic.Text = "Вид работы с родителями";
            // 
            // TalcParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(628, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bAddPrivTalc);
            this.Controls.Add(this.dgvTopicTalc);
            this.Controls.Add(this.labelStudent);
            this.Controls.Add(this.comboBoxStudent);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TalcParentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicTalc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataGridView dgvTopicTalc;
        private System.Windows.Forms.Button bAddPrivTalc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatusTopic;
        private System.Windows.Forms.ComboBox comboBoxTopic;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTalkStudent;
    }
}