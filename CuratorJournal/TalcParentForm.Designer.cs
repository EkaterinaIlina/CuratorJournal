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
            this.panelTalkParent = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewKin = new System.Windows.Forms.DataGridView();
            this.labelStatusTopic = new System.Windows.Forms.Label();
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTimePickerTalkStudent = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicTalc)).BeginInit();
            this.panelTalkParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKin)).BeginInit();
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
            this.comboBoxStudent.Location = new System.Drawing.Point(127, 53);
            this.comboBoxStudent.Name = "comboBoxStudent";
            this.comboBoxStudent.Size = new System.Drawing.Size(454, 21);
            this.comboBoxStudent.TabIndex = 5;
            this.comboBoxStudent.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudent_SelectedIndexChanged);
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(12, 56);
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
            this.dgvTopicTalc.Location = new System.Drawing.Point(12, 97);
            this.dgvTopicTalc.Name = "dgvTopicTalc";
            this.dgvTopicTalc.ReadOnly = true;
            this.dgvTopicTalc.RowHeadersVisible = false;
            this.dgvTopicTalc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTopicTalc.Size = new System.Drawing.Size(503, 128);
            this.dgvTopicTalc.TabIndex = 46;
            this.dgvTopicTalc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTopicTalc_CellMouseClick);
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
            this.bAddPrivTalc.Click += new System.EventHandler(this.bAddPrivTalc_Click);
            // 
            // panelTalkParent
            // 
            this.panelTalkParent.Controls.Add(this.buttonDelete);
            this.panelTalkParent.Controls.Add(this.buttonSave);
            this.panelTalkParent.Controls.Add(this.dataGridViewKin);
            this.panelTalkParent.Controls.Add(this.labelStatusTopic);
            this.panelTalkParent.Controls.Add(this.comboBoxTopic);
            this.panelTalkParent.Controls.Add(this.labelTopic);
            this.panelTalkParent.Controls.Add(this.textBoxTopic);
            this.panelTalkParent.Controls.Add(this.lDate);
            this.panelTalkParent.Controls.Add(this.dateTimePickerTalkStudent);
            this.panelTalkParent.Location = new System.Drawing.Point(12, 231);
            this.panelTalkParent.Name = "panelTalkParent";
            this.panelTalkParent.Size = new System.Drawing.Size(569, 236);
            this.panelTalkParent.TabIndex = 49;
            this.panelTalkParent.Visible = false;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(439, 200);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 23);
            this.buttonDelete.TabIndex = 50;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(283, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 23);
            this.buttonSave.TabIndex = 49;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewKin
            // 
            this.dataGridViewKin.AllowUserToAddRows = false;
            this.dataGridViewKin.AllowUserToDeleteRows = false;
            this.dataGridViewKin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKin.Location = new System.Drawing.Point(283, 23);
            this.dataGridViewKin.Name = "dataGridViewKin";
            this.dataGridViewKin.RowHeadersVisible = false;
            this.dataGridViewKin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewKin.Size = new System.Drawing.Size(272, 157);
            this.dataGridViewKin.TabIndex = 48;
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
            // comboBoxTopic
            // 
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(9, 23);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(257, 21);
            this.comboBoxTopic.TabIndex = 46;
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
            this.textBoxTopic.Size = new System.Drawing.Size(257, 100);
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
            // TalcParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(628, 513);
            this.Controls.Add(this.panelTalkParent);
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
            this.panelTalkParent.ResumeLayout(false);
            this.panelTalkParent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ComboBox comboBoxStudent;
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.DataGridView dgvTopicTalc;
        private System.Windows.Forms.Button bAddPrivTalc;
        private System.Windows.Forms.Panel panelTalkParent;
        private System.Windows.Forms.Label labelStatusTopic;
        private System.Windows.Forms.ComboBox comboBoxTopic;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTalkStudent;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewKin;
    }
}