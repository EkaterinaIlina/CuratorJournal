namespace CuratorJournal
{
    partial class RatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.comboBoxDiscpline = new System.Windows.Forms.ComboBox();
            this.dgvStudentMark = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFiksDiscipline = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMark)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(143, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(364, 28);
            this.lTitle.TabIndex = 42;
            this.lTitle.Text = "Контроль текущей успеваемости";
            // 
            // comboBoxDiscpline
            // 
            this.comboBoxDiscpline.FormattingEnabled = true;
            this.comboBoxDiscpline.Location = new System.Drawing.Point(148, 54);
            this.comboBoxDiscpline.MaxLength = 25;
            this.comboBoxDiscpline.Name = "comboBoxDiscpline";
            this.comboBoxDiscpline.Size = new System.Drawing.Size(189, 21);
            this.comboBoxDiscpline.TabIndex = 43;
            this.comboBoxDiscpline.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscpline_SelectedIndexChanged);
            // 
            // dgvStudentMark
            // 
            this.dgvStudentMark.AllowUserToAddRows = false;
            this.dgvStudentMark.AllowUserToDeleteRows = false;
            this.dgvStudentMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentMark.Location = new System.Drawing.Point(148, 81);
            this.dgvStudentMark.Name = "dgvStudentMark";
            this.dgvStudentMark.RowHeadersVisible = false;
            this.dgvStudentMark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudentMark.Size = new System.Drawing.Size(428, 374);
            this.dgvStudentMark.TabIndex = 44;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 388);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(119, 24);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(23, 432);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 23);
            this.buttonDelete.TabIndex = 46;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonFiksDiscipline
            // 
            this.buttonFiksDiscipline.Location = new System.Drawing.Point(343, 52);
            this.buttonFiksDiscipline.Name = "buttonFiksDiscipline";
            this.buttonFiksDiscipline.Size = new System.Drawing.Size(233, 23);
            this.buttonFiksDiscipline.TabIndex = 47;
            this.buttonFiksDiscipline.Text = "Перейти к выставлению оценок";
            this.buttonFiksDiscipline.UseVisualStyleBackColor = true;
            this.buttonFiksDiscipline.Click += new System.EventHandler(this.buttonFiksDiscipline_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 467);
            this.Controls.Add(this.buttonFiksDiscipline);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dgvStudentMark);
            this.Controls.Add(this.comboBoxDiscpline);
            this.Controls.Add(this.lTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RatingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ComboBox comboBoxDiscpline;
        private System.Windows.Forms.DataGridView dgvStudentMark;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFiksDiscipline;
    }
}