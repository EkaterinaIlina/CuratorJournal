namespace CuratorJournal
{
    partial class GroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupForm));
            this.lNumberGroup = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.lSipher = new System.Windows.Forms.Label();
            this.lspecialty = new System.Windows.Forms.Label();
            this.tbNumberGroup = new System.Windows.Forms.TextBox();
            this.tbSpecialty = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdition = new System.Windows.Forms.Button();
            this.maskedtbSipher = new System.Windows.Forms.MaskedTextBox();
            this.tbInstitute = new System.Windows.Forms.TextBox();
            this.lInstitute = new System.Windows.Forms.Label();
            this.tbDepartment = new System.Windows.Forms.TextBox();
            this.lDepartment = new System.Windows.Forms.Label();
            this.lPrim = new System.Windows.Forms.Label();
            this.numericUpDownKurs = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.lKurs = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lNumberGroup
            // 
            this.lNumberGroup.AutoSize = true;
            this.lNumberGroup.Location = new System.Drawing.Point(12, 115);
            this.lNumberGroup.Name = "lNumberGroup";
            this.lNumberGroup.Size = new System.Drawing.Size(87, 13);
            this.lNumberGroup.TabIndex = 0;
            this.lNumberGroup.Text = "Номер группы *";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(24, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(205, 26);
            this.lTitle.TabIndex = 19;
            this.lTitle.Text = "Добавление группы";
            // 
            // lSipher
            // 
            this.lSipher.AutoSize = true;
            this.lSipher.Location = new System.Drawing.Point(12, 145);
            this.lSipher.Name = "lSipher";
            this.lSipher.Size = new System.Drawing.Size(43, 13);
            this.lSipher.TabIndex = 20;
            this.lSipher.Text = "Шифр *";
            // 
            // lspecialty
            // 
            this.lspecialty.AutoSize = true;
            this.lspecialty.Location = new System.Drawing.Point(12, 174);
            this.lspecialty.Name = "lspecialty";
            this.lspecialty.Size = new System.Drawing.Size(92, 13);
            this.lspecialty.TabIndex = 21;
            this.lspecialty.Text = "Специальность *";
            // 
            // tbNumberGroup
            // 
            this.tbNumberGroup.Location = new System.Drawing.Point(119, 112);
            this.tbNumberGroup.MaxLength = 20;
            this.tbNumberGroup.Name = "tbNumberGroup";
            this.tbNumberGroup.Size = new System.Drawing.Size(369, 20);
            this.tbNumberGroup.TabIndex = 3;
            this.tbNumberGroup.TextChanged += new System.EventHandler(this.tbNumberGroup_TextChanged);
            // 
            // tbSpecialty
            // 
            this.tbSpecialty.Location = new System.Drawing.Point(119, 171);
            this.tbSpecialty.MaxLength = 100;
            this.tbSpecialty.Name = "tbSpecialty";
            this.tbSpecialty.Size = new System.Drawing.Size(369, 20);
            this.tbSpecialty.TabIndex = 5;
            this.tbSpecialty.TextChanged += new System.EventHandler(this.tbSpecialty_TextChanged);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(332, 203);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(75, 23);
            this.bDelete.TabIndex = 25;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bEdition
            // 
            this.bEdition.Location = new System.Drawing.Point(413, 203);
            this.bEdition.Name = "bEdition";
            this.bEdition.Size = new System.Drawing.Size(75, 23);
            this.bEdition.TabIndex = 26;
            this.bEdition.Text = "Добавить";
            this.bEdition.UseVisualStyleBackColor = true;
            this.bEdition.Click += new System.EventHandler(this.bEdition_Click);
            // 
            // maskedtbSipher
            // 
            this.maskedtbSipher.Location = new System.Drawing.Point(119, 142);
            this.maskedtbSipher.Mask = "00.00.00";
            this.maskedtbSipher.Name = "maskedtbSipher";
            this.maskedtbSipher.Size = new System.Drawing.Size(369, 20);
            this.maskedtbSipher.TabIndex = 4;
            this.maskedtbSipher.TextChanged += new System.EventHandler(this.maskedtbSipher_TextChanged);
            // 
            // tbInstitute
            // 
            this.tbInstitute.Location = new System.Drawing.Point(119, 55);
            this.tbInstitute.MaxLength = 100;
            this.tbInstitute.Name = "tbInstitute";
            this.tbInstitute.ShortcutsEnabled = false;
            this.tbInstitute.Size = new System.Drawing.Size(369, 20);
            this.tbInstitute.TabIndex = 1;
            this.tbInstitute.TextChanged += new System.EventHandler(this.tbInstitute_TextChanged);
            // 
            // lInstitute
            // 
            this.lInstitute.AutoSize = true;
            this.lInstitute.Location = new System.Drawing.Point(12, 58);
            this.lInstitute.Name = "lInstitute";
            this.lInstitute.Size = new System.Drawing.Size(60, 13);
            this.lInstitute.TabIndex = 28;
            this.lInstitute.Text = "Институт *";
            // 
            // tbDepartment
            // 
            this.tbDepartment.Location = new System.Drawing.Point(119, 83);
            this.tbDepartment.MaxLength = 100;
            this.tbDepartment.Name = "tbDepartment";
            this.tbDepartment.Size = new System.Drawing.Size(369, 20);
            this.tbDepartment.TabIndex = 2;
            this.tbDepartment.TextChanged += new System.EventHandler(this.tbDepartment_TextChanged);
            // 
            // lDepartment
            // 
            this.lDepartment.AutoSize = true;
            this.lDepartment.Location = new System.Drawing.Point(12, 86);
            this.lDepartment.Name = "lDepartment";
            this.lDepartment.Size = new System.Drawing.Size(52, 13);
            this.lDepartment.TabIndex = 30;
            this.lDepartment.Text = "Кафедра";
            // 
            // lPrim
            // 
            this.lPrim.AutoSize = true;
            this.lPrim.Location = new System.Drawing.Point(319, 18);
            this.lPrim.Name = "lPrim";
            this.lPrim.Size = new System.Drawing.Size(169, 13);
            this.lPrim.TabIndex = 32;
            this.lPrim.Text = "* - обязательно для заполнения";
            // 
            // numericUpDownKurs
            // 
            this.numericUpDownKurs.Location = new System.Drawing.Point(110, 8);
            this.numericUpDownKurs.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownKurs.Name = "numericUpDownKurs";
            this.numericUpDownKurs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKurs.TabIndex = 6;
            this.numericUpDownKurs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerYear.Location = new System.Drawing.Point(110, 39);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(120, 20);
            this.dateTimePickerYear.TabIndex = 7;
            // 
            // lKurs
            // 
            this.lKurs.AutoSize = true;
            this.lKurs.Location = new System.Drawing.Point(3, 10);
            this.lKurs.Name = "lKurs";
            this.lKurs.Size = new System.Drawing.Size(38, 13);
            this.lKurs.TabIndex = 35;
            this.lKurs.Text = "Курс *";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(3, 39);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(102, 26);
            this.lYear.TabIndex = 36;
            this.lYear.Text = "Дата начала \r\nведения журнала *";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lKurs);
            this.panel1.Controls.Add(this.lYear);
            this.panel1.Controls.Add(this.numericUpDownKurs);
            this.panel1.Controls.Add(this.dateTimePickerYear);
            this.panel1.Location = new System.Drawing.Point(7, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 71);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // GroupForm
            // 
            this.AcceptButton = this.bEdition;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 278);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lPrim);
            this.Controls.Add(this.tbDepartment);
            this.Controls.Add(this.lDepartment);
            this.Controls.Add(this.tbInstitute);
            this.Controls.Add(this.lInstitute);
            this.Controls.Add(this.maskedtbSipher);
            this.Controls.Add(this.bEdition);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tbSpecialty);
            this.Controls.Add(this.tbNumberGroup);
            this.Controls.Add(this.lspecialty);
            this.Controls.Add(this.lSipher);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.lNumberGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GroupForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKurs)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumberGroup;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lSipher;
        private System.Windows.Forms.Label lspecialty;
        private System.Windows.Forms.TextBox tbNumberGroup;
        private System.Windows.Forms.TextBox tbSpecialty;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEdition;
        private System.Windows.Forms.MaskedTextBox maskedtbSipher;
        private System.Windows.Forms.TextBox tbInstitute;
        private System.Windows.Forms.Label lInstitute;
        private System.Windows.Forms.TextBox tbDepartment;
        private System.Windows.Forms.Label lDepartment;
        private System.Windows.Forms.Label lPrim;
        private System.Windows.Forms.NumericUpDown numericUpDownKurs;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Label lKurs;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Panel panel1;
    }
}