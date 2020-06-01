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
            this.bAddVisit = new System.Windows.Forms.Button();
            this.panelVisitRoom = new System.Windows.Forms.Panel();
            this.labelCause = new System.Windows.Forms.Label();
            this.textBoxCause = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSaveStudent = new System.Windows.Forms.Button();
            this.lStudent = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.dateTimePickerVisit = new System.Windows.Forms.DateTimePicker();
            this.dgvVisit = new System.Windows.Forms.DataGridView();
            this.lTitle = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelVisitRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // bAddVisit
            // 
            this.bAddVisit.Image = ((System.Drawing.Image)(resources.GetObject("bAddVisit.Image")));
            this.bAddVisit.Location = new System.Drawing.Point(15, 44);
            this.bAddVisit.Name = "bAddVisit";
            this.bAddVisit.Size = new System.Drawing.Size(43, 23);
            this.bAddVisit.TabIndex = 44;
            this.bAddVisit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddVisit.UseVisualStyleBackColor = true;
            this.bAddVisit.Click += new System.EventHandler(this.bAddVisit_Click);
            // 
            // panelVisitRoom
            // 
            this.panelVisitRoom.Controls.Add(this.labelCause);
            this.panelVisitRoom.Controls.Add(this.textBoxCause);
            this.panelVisitRoom.Controls.Add(this.bDelete);
            this.panelVisitRoom.Controls.Add(this.bSaveStudent);
            this.panelVisitRoom.Controls.Add(this.lStudent);
            this.panelVisitRoom.Controls.Add(this.lDate);
            this.panelVisitRoom.Controls.Add(this.dgvRoom);
            this.panelVisitRoom.Controls.Add(this.dateTimePickerVisit);
            this.panelVisitRoom.Location = new System.Drawing.Point(289, 44);
            this.panelVisitRoom.Name = "panelVisitRoom";
            this.panelVisitRoom.Size = new System.Drawing.Size(304, 459);
            this.panelVisitRoom.TabIndex = 43;
            this.panelVisitRoom.Visible = false;
            // 
            // labelCause
            // 
            this.labelCause.AutoSize = true;
            this.labelCause.Location = new System.Drawing.Point(10, 45);
            this.labelCause.Name = "labelCause";
            this.labelCause.Size = new System.Drawing.Size(114, 13);
            this.labelCause.TabIndex = 41;
            this.labelCause.Text = "Причина посещения*";
            // 
            // textBoxCause
            // 
            this.textBoxCause.Location = new System.Drawing.Point(13, 61);
            this.textBoxCause.MaxLength = 300;
            this.textBoxCause.Multiline = true;
            this.textBoxCause.Name = "textBoxCause";
            this.textBoxCause.Size = new System.Drawing.Size(286, 84);
            this.textBoxCause.TabIndex = 40;
            this.textBoxCause.TextChanged += new System.EventHandler(this.textBoxCause_TextChanged);
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
            this.lStudent.Location = new System.Drawing.Point(11, 148);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(125, 13);
            this.lStudent.TabIndex = 36;
            this.lStudent.Text = "Проверенные комнаты";
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
            // dgvRoom
            // 
            this.dgvRoom.AllowUserToAddRows = false;
            this.dgvRoom.AllowUserToDeleteRows = false;
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(13, 164);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersVisible = false;
            this.dgvRoom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRoom.Size = new System.Drawing.Size(286, 284);
            this.dgvRoom.TabIndex = 37;
            // 
            // dateTimePickerVisit
            // 
            this.dateTimePickerVisit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVisit.Location = new System.Drawing.Point(121, 9);
            this.dateTimePickerVisit.Name = "dateTimePickerVisit";
            this.dateTimePickerVisit.Size = new System.Drawing.Size(178, 20);
            this.dateTimePickerVisit.TabIndex = 4;
            this.dateTimePickerVisit.ValueChanged += new System.EventHandler(this.dateTimePickerVisit_ValueChanged);
            // 
            // dgvVisit
            // 
            this.dgvVisit.AllowUserToAddRows = false;
            this.dgvVisit.AllowUserToDeleteRows = false;
            this.dgvVisit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisit.Location = new System.Drawing.Point(64, 44);
            this.dgvVisit.Name = "dgvVisit";
            this.dgvVisit.ReadOnly = true;
            this.dgvVisit.RowHeadersVisible = false;
            this.dgvVisit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvVisit.Size = new System.Drawing.Size(210, 407);
            this.dgvVisit.TabIndex = 42;
            this.dgvVisit.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVisit_CellMouseClick);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(78, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(420, 28);
            this.lTitle.TabIndex = 41;
            this.lTitle.Text = "Посещение студенческого общежития";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(64, 457);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(210, 24);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(64, 487);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(210, 24);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // VisitHostelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.bAddVisit);
            this.Controls.Add(this.panelVisitRoom);
            this.Controls.Add(this.dgvVisit);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VisitHostelForm";
            this.panelVisitRoom.ResumeLayout(false);
            this.panelVisitRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddVisit;
        private System.Windows.Forms.Panel panelVisitRoom;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSaveStudent;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisit;
        private System.Windows.Forms.DataGridView dgvVisit;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label labelCause;
        private System.Windows.Forms.TextBox textBoxCause;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
    }
}