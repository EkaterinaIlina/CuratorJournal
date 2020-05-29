namespace CuratorJournal
{
    partial class StudentInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInformationForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lOpisanie = new System.Windows.Forms.Label();
            this.checkBoxSemestrOne = new System.Windows.Forms.CheckBox();
            this.checkBoxSemestrTwo = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(166, 4);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(242, 28);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Сведения о студентах";
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(19, 62);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudent.Size = new System.Drawing.Size(529, 398);
            this.dgvStudent.TabIndex = 31;
            this.dgvStudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStudent_CellFormatting);
            this.dgvStudent.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellMouseEnter);
            this.dgvStudent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvStudent_MouseUp);
            // 
            // lOpisanie
            // 
            this.lOpisanie.AutoSize = true;
            this.lOpisanie.Location = new System.Drawing.Point(96, 32);
            this.lOpisanie.Name = "lOpisanie";
            this.lOpisanie.Size = new System.Drawing.Size(386, 26);
            this.lOpisanie.TabIndex = 32;
            this.lOpisanie.Text = "Студенты, обучающие на бюджетные средства \r\n(отметить тех, кто получает стипендию" +
    " в осеннем и весеннем семестрах):";
            this.lOpisanie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxSemestrOne
            // 
            this.checkBoxSemestrOne.AutoSize = true;
            this.checkBoxSemestrOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSemestrOne.Location = new System.Drawing.Point(266, 466);
            this.checkBoxSemestrOne.Name = "checkBoxSemestrOne";
            this.checkBoxSemestrOne.Size = new System.Drawing.Size(100, 28);
            this.checkBoxSemestrOne.TabIndex = 33;
            this.checkBoxSemestrOne.Text = "Выделить все/\r\nСнять выделение\r\n";
            this.checkBoxSemestrOne.UseVisualStyleBackColor = true;
            this.checkBoxSemestrOne.CheckedChanged += new System.EventHandler(this.checkBoxSemestrOne_CheckedChanged);
            // 
            // checkBoxSemestrTwo
            // 
            this.checkBoxSemestrTwo.AutoSize = true;
            this.checkBoxSemestrTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSemestrTwo.Location = new System.Drawing.Point(431, 466);
            this.checkBoxSemestrTwo.Name = "checkBoxSemestrTwo";
            this.checkBoxSemestrTwo.Size = new System.Drawing.Size(100, 28);
            this.checkBoxSemestrTwo.TabIndex = 34;
            this.checkBoxSemestrTwo.Text = "Выделить все/\r\nСнять выделение";
            this.checkBoxSemestrTwo.UseVisualStyleBackColor = true;
            this.checkBoxSemestrTwo.CheckedChanged += new System.EventHandler(this.checkBoxSemestrTwo_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(466, 500);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(82, 23);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // StudentInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 523);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxSemestrTwo);
            this.Controls.Add(this.checkBoxSemestrOne);
            this.Controls.Add(this.lOpisanie);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentInformation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lOpisanie;
        private System.Windows.Forms.CheckBox checkBoxSemestrOne;
        private System.Windows.Forms.CheckBox checkBoxSemestrTwo;
        private System.Windows.Forms.Button buttonSave;
    }
}