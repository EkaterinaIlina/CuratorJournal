namespace CuratorJournal
{
    partial class DisciplinaryCommissionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplinaryCommissionForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.dgvOffence = new System.Windows.Forms.DataGridView();
            this.bAddOffence = new System.Windows.Forms.Button();
            this.panelOffence = new System.Windows.Forms.Panel();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTimePickerOffence = new System.Windows.Forms.DateTimePicker();
            this.lDescision = new System.Windows.Forms.Label();
            this.lNumberProt = new System.Windows.Forms.Label();
            this.textBoxNumberProt = new System.Windows.Forms.TextBox();
            this.tbDecision = new System.Windows.Forms.TextBox();
            this.labelCause = new System.Windows.Forms.Label();
            this.textBoxCause = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffence)).BeginInit();
            this.panelOffence.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(135, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(417, 28);
            this.lTitle.TabIndex = 4;
            this.lTitle.Text = "Заседания дисциплинарной комиссии";
            // 
            // dgvOffence
            // 
            this.dgvOffence.AllowUserToAddRows = false;
            this.dgvOffence.AllowUserToDeleteRows = false;
            this.dgvOffence.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOffence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffence.Location = new System.Drawing.Point(62, 57);
            this.dgvOffence.Name = "dgvOffence";
            this.dgvOffence.ReadOnly = true;
            this.dgvOffence.RowHeadersVisible = false;
            this.dgvOffence.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvOffence.Size = new System.Drawing.Size(496, 150);
            this.dgvOffence.TabIndex = 35;
            this.dgvOffence.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOffence_CellMouseClick);
            // 
            // bAddOffence
            // 
            this.bAddOffence.Image = ((System.Drawing.Image)(resources.GetObject("bAddOffence.Image")));
            this.bAddOffence.Location = new System.Drawing.Point(564, 57);
            this.bAddOffence.Name = "bAddOffence";
            this.bAddOffence.Size = new System.Drawing.Size(43, 23);
            this.bAddOffence.TabIndex = 34;
            this.bAddOffence.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddOffence.UseVisualStyleBackColor = true;
            this.bAddOffence.Click += new System.EventHandler(this.bAddOffence_Click);
            // 
            // panelOffence
            // 
            this.panelOffence.Controls.Add(this.labelCause);
            this.panelOffence.Controls.Add(this.textBoxCause);
            this.panelOffence.Controls.Add(this.lDescision);
            this.panelOffence.Controls.Add(this.lNumberProt);
            this.panelOffence.Controls.Add(this.textBoxNumberProt);
            this.panelOffence.Controls.Add(this.tbDecision);
            this.panelOffence.Controls.Add(this.lDate);
            this.panelOffence.Controls.Add(this.dateTimePickerOffence);
            this.panelOffence.Location = new System.Drawing.Point(62, 213);
            this.panelOffence.Name = "panelOffence";
            this.panelOffence.Size = new System.Drawing.Size(496, 245);
            this.panelOffence.TabIndex = 36;
            this.panelOffence.Visible = false;
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(3, 11);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(96, 13);
            this.lDate.TabIndex = 7;
            this.lDate.Text = "Дата проведения";
            // 
            // dateTimePickerOffence
            // 
            this.dateTimePickerOffence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOffence.Location = new System.Drawing.Point(105, 8);
            this.dateTimePickerOffence.Name = "dateTimePickerOffence";
            this.dateTimePickerOffence.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerOffence.TabIndex = 6;
            this.dateTimePickerOffence.ValueChanged += new System.EventHandler(this.dateTimePickerOffence_ValueChanged);
            // 
            // lDescision
            // 
            this.lDescision.AutoSize = true;
            this.lDescision.Location = new System.Drawing.Point(3, 155);
            this.lDescision.Name = "lDescision";
            this.lDescision.Size = new System.Drawing.Size(107, 13);
            this.lDescision.TabIndex = 13;
            this.lDescision.Text = "Принятое решение*";
            // 
            // lNumberProt
            // 
            this.lNumberProt.AutoSize = true;
            this.lNumberProt.Location = new System.Drawing.Point(3, 37);
            this.lNumberProt.Name = "lNumberProt";
            this.lNumberProt.Size = new System.Drawing.Size(101, 13);
            this.lNumberProt.TabIndex = 12;
            this.lNumberProt.Text = "Номер протокола*";
            // 
            // textBoxNumberProt
            // 
            this.textBoxNumberProt.Location = new System.Drawing.Point(6, 53);
            this.textBoxNumberProt.MaxLength = 100;
            this.textBoxNumberProt.Multiline = true;
            this.textBoxNumberProt.Name = "textBoxNumberProt";
            this.textBoxNumberProt.Size = new System.Drawing.Size(471, 20);
            this.textBoxNumberProt.TabIndex = 11;
            this.textBoxNumberProt.TextChanged += new System.EventHandler(this.textBoxNumberProt_TextChanged);
            // 
            // tbDecision
            // 
            this.tbDecision.Location = new System.Drawing.Point(6, 171);
            this.tbDecision.MaxLength = 300;
            this.tbDecision.Multiline = true;
            this.tbDecision.Name = "tbDecision";
            this.tbDecision.Size = new System.Drawing.Size(471, 59);
            this.tbDecision.TabIndex = 10;
            this.tbDecision.TextChanged += new System.EventHandler(this.tbDecision_TextChanged);
            // 
            // labelCause
            // 
            this.labelCause.AutoSize = true;
            this.labelCause.Location = new System.Drawing.Point(3, 77);
            this.labelCause.Name = "labelCause";
            this.labelCause.Size = new System.Drawing.Size(118, 13);
            this.labelCause.TabIndex = 15;
            this.labelCause.Text = "Причина обсуждения*\r\n";
            // 
            // textBoxCause
            // 
            this.textBoxCause.Location = new System.Drawing.Point(6, 93);
            this.textBoxCause.MaxLength = 300;
            this.textBoxCause.Multiline = true;
            this.textBoxCause.Name = "textBoxCause";
            this.textBoxCause.Size = new System.Drawing.Size(471, 59);
            this.textBoxCause.TabIndex = 14;
            this.textBoxCause.TextChanged += new System.EventHandler(this.textBoxCause_TextChanged);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(406, 473);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(133, 28);
            this.bDelete.TabIndex = 41;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(95, 473);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(133, 28);
            this.bSave.TabIndex = 40;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // DisciplinaryCommissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 513);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.panelOffence);
            this.Controls.Add(this.dgvOffence);
            this.Controls.Add(this.bAddOffence);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisciplinaryCommissionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffence)).EndInit();
            this.panelOffence.ResumeLayout(false);
            this.panelOffence.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.DataGridView dgvOffence;
        private System.Windows.Forms.Button bAddOffence;
        private System.Windows.Forms.Panel panelOffence;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerOffence;
        private System.Windows.Forms.Label labelCause;
        private System.Windows.Forms.TextBox textBoxCause;
        private System.Windows.Forms.Label lDescision;
        private System.Windows.Forms.Label lNumberProt;
        private System.Windows.Forms.TextBox textBoxNumberProt;
        private System.Windows.Forms.TextBox tbDecision;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
    }
}