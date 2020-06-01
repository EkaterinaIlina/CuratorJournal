namespace CuratorJournal
{
    partial class EducationalWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EducationalWorkForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.panelPrivTalc = new System.Windows.Forms.Panel();
            this.labelTopic = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.lStudent = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTalkStudent = new System.Windows.Forms.DateTimePicker();
            this.dgvTopicTalc = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.bAddPrivTalc = new System.Windows.Forms.Button();
            this.panelPrivTalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicTalc)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(105, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(432, 28);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Индивидуальные беседы со студентами";
            // 
            // panelPrivTalc
            // 
            this.panelPrivTalc.Controls.Add(this.labelTopic);
            this.panelPrivTalc.Controls.Add(this.textBoxTopic);
            this.panelPrivTalc.Controls.Add(this.lStudent);
            this.panelPrivTalc.Controls.Add(this.lDate);
            this.panelPrivTalc.Controls.Add(this.dgvStudent);
            this.panelPrivTalc.Controls.Add(this.dateTimePickerTalkStudent);
            this.panelPrivTalc.Location = new System.Drawing.Point(292, 40);
            this.panelPrivTalc.Name = "panelPrivTalc";
            this.panelPrivTalc.Size = new System.Drawing.Size(304, 459);
            this.panelPrivTalc.TabIndex = 46;
            this.panelPrivTalc.Visible = false;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(10, 45);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(79, 13);
            this.labelTopic.TabIndex = 41;
            this.labelTopic.Text = "Тема беседы*";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(13, 61);
            this.textBoxTopic.MaxLength = 300;
            this.textBoxTopic.Multiline = true;
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(286, 84);
            this.textBoxTopic.TabIndex = 40;
            this.textBoxTopic.TextChanged += new System.EventHandler(this.textBoxTopic_TextChanged);
            // 
            // lStudent
            // 
            this.lStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStudent.AutoSize = true;
            this.lStudent.Location = new System.Drawing.Point(11, 148);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(199, 13);
            this.lStudent.TabIndex = 36;
            this.lStudent.Text = "Студенты, с которыми велась беседа";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(10, 15);
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
            this.dgvStudent.Size = new System.Drawing.Size(286, 284);
            this.dgvStudent.TabIndex = 37;
            // 
            // dateTimePickerTalkStudent
            // 
            this.dateTimePickerTalkStudent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTalkStudent.Location = new System.Drawing.Point(121, 9);
            this.dateTimePickerTalkStudent.Name = "dateTimePickerTalkStudent";
            this.dateTimePickerTalkStudent.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerTalkStudent.TabIndex = 4;
            this.dateTimePickerTalkStudent.ValueChanged += new System.EventHandler(this.dateTimePickerTalkStudent_ValueChanged);
            // 
            // dgvTopicTalc
            // 
            this.dgvTopicTalc.AllowUserToAddRows = false;
            this.dgvTopicTalc.AllowUserToDeleteRows = false;
            this.dgvTopicTalc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopicTalc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopicTalc.Location = new System.Drawing.Point(67, 40);
            this.dgvTopicTalc.Name = "dgvTopicTalc";
            this.dgvTopicTalc.ReadOnly = true;
            this.dgvTopicTalc.RowHeadersVisible = false;
            this.dgvTopicTalc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTopicTalc.Size = new System.Drawing.Size(210, 407);
            this.dgvTopicTalc.TabIndex = 45;
            this.dgvTopicTalc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTopicTalc_CellMouseClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(67, 486);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(210, 24);
            this.buttonDelete.TabIndex = 49;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(67, 456);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(210, 24);
            this.buttonSave.TabIndex = 48;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // bAddPrivTalc
            // 
            this.bAddPrivTalc.Image = ((System.Drawing.Image)(resources.GetObject("bAddPrivTalc.Image")));
            this.bAddPrivTalc.Location = new System.Drawing.Point(18, 40);
            this.bAddPrivTalc.Name = "bAddPrivTalc";
            this.bAddPrivTalc.Size = new System.Drawing.Size(43, 23);
            this.bAddPrivTalc.TabIndex = 47;
            this.bAddPrivTalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddPrivTalc.UseVisualStyleBackColor = true;
            this.bAddPrivTalc.Click += new System.EventHandler(this.bAddPrivTalc_Click);
            // 
            // EducationalWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(632, 513);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.bAddPrivTalc);
            this.Controls.Add(this.panelPrivTalc);
            this.Controls.Add(this.dgvTopicTalc);
            this.Controls.Add(this.lTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EducationalWorkForm";
            this.panelPrivTalc.ResumeLayout(false);
            this.panelPrivTalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopicTalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Button bAddPrivTalc;
        private System.Windows.Forms.Panel panelPrivTalc;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DateTimePicker dateTimePickerTalkStudent;
        private System.Windows.Forms.DataGridView dgvTopicTalc;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
    }
}