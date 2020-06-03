namespace CuratorJournal
{
    partial class AddJournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddJournalForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.lNameGroup = new System.Windows.Forms.Label();
            this.lNameCurator = new System.Windows.Forms.Label();
            this.lGroup = new System.Windows.Forms.Label();
            this.lCurator = new System.Windows.Forms.Label();
            this.lKours = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerJournal = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonPrintJournal = new System.Windows.Forms.Button();
            this.saveFileDialogJournal = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(23, 22);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(375, 28);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Основная информация о журнале";
            // 
            // lNameGroup
            // 
            this.lNameGroup.AutoSize = true;
            this.lNameGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameGroup.Location = new System.Drawing.Point(13, 92);
            this.lNameGroup.Name = "lNameGroup";
            this.lNameGroup.Size = new System.Drawing.Size(55, 16);
            this.lNameGroup.TabIndex = 1;
            this.lNameGroup.Text = "Группа";
            // 
            // lNameCurator
            // 
            this.lNameCurator.AutoSize = true;
            this.lNameCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lNameCurator.Location = new System.Drawing.Point(13, 127);
            this.lNameCurator.Name = "lNameCurator";
            this.lNameCurator.Size = new System.Drawing.Size(63, 16);
            this.lNameCurator.TabIndex = 2;
            this.lNameCurator.Text = "Куратор";
            // 
            // lGroup
            // 
            this.lGroup.AutoSize = true;
            this.lGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGroup.Location = new System.Drawing.Point(170, 92);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(0, 16);
            this.lGroup.TabIndex = 3;
            // 
            // lCurator
            // 
            this.lCurator.AutoSize = true;
            this.lCurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lCurator.Location = new System.Drawing.Point(170, 127);
            this.lCurator.Name = "lCurator";
            this.lCurator.Size = new System.Drawing.Size(0, 16);
            this.lCurator.TabIndex = 4;
            // 
            // lKours
            // 
            this.lKours.AutoSize = true;
            this.lKours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lKours.Location = new System.Drawing.Point(13, 177);
            this.lKours.Name = "lKours";
            this.lKours.Size = new System.Drawing.Size(89, 16);
            this.lKours.TabIndex = 5;
            this.lKours.Text = "Курс группы";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.Location = new System.Drawing.Point(13, 227);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(123, 32);
            this.lDate.TabIndex = 6;
            this.lDate.Text = "Дата начала \r\nведения журнала";
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Location = new System.Drawing.Point(173, 177);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKurs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKurs.TabIndex = 7;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKurs.ValueChanged += new System.EventHandler(this.numericUpDownKurs_ValueChanged);
            // 
            // dateTimePickerJournal
            // 
            this.dateTimePickerJournal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerJournal.Location = new System.Drawing.Point(173, 239);
            this.dateTimePickerJournal.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerJournal.Name = "dateTimePickerJournal";
            this.dateTimePickerJournal.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerJournal.TabIndex = 8;
            this.dateTimePickerJournal.ValueChanged += new System.EventHandler(this.dateTimePickerJournal_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(323, 296);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(16, 296);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonPrintJournal
            // 
            this.buttonPrintJournal.Location = new System.Drawing.Point(16, 359);
            this.buttonPrintJournal.Name = "buttonPrintJournal";
            this.buttonPrintJournal.Size = new System.Drawing.Size(390, 37);
            this.buttonPrintJournal.TabIndex = 11;
            this.buttonPrintJournal.Text = "Сформировать журнал за год";
            this.buttonPrintJournal.UseVisualStyleBackColor = true;
            this.buttonPrintJournal.Visible = false;
            this.buttonPrintJournal.Click += new System.EventHandler(this.buttonPrintJournal_Click);
            // 
            // AddJournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(418, 426);
            this.Controls.Add(this.buttonPrintJournal);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerJournal);
            this.Controls.Add(this.numericUpDownKurs);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lKours);
            this.Controls.Add(this.lCurator);
            this.Controls.Add(this.lGroup);
            this.Controls.Add(this.lNameCurator);
            this.Controls.Add(this.lNameGroup);
            this.Controls.Add(this.lTitle);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddJournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lNameGroup;
        private System.Windows.Forms.Label lNameCurator;
        private System.Windows.Forms.Label lGroup;
        private System.Windows.Forms.Label lCurator;
        private System.Windows.Forms.Label lKours;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.DateTimePicker dateTimePickerJournal;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPrintJournal;
        private System.Windows.Forms.SaveFileDialog saveFileDialogJournal;
    }
}