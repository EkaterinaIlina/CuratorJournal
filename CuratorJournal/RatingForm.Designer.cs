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
            this.comboBoxDiscpline.Location = new System.Drawing.Point(35, 54);
            this.comboBoxDiscpline.MaxLength = 100;
            this.comboBoxDiscpline.Name = "comboBoxDiscpline";
            this.comboBoxDiscpline.Size = new System.Drawing.Size(541, 21);
            this.comboBoxDiscpline.TabIndex = 43;
            this.comboBoxDiscpline.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscpline_SelectedIndexChanged);
            this.comboBoxDiscpline.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDiscpline_Validating);
            // 
            // dgvStudentMark
            // 
            this.dgvStudentMark.AllowUserToAddRows = false;
            this.dgvStudentMark.AllowUserToDeleteRows = false;
            this.dgvStudentMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentMark.Location = new System.Drawing.Point(35, 81);
            this.dgvStudentMark.Name = "dgvStudentMark";
            this.dgvStudentMark.RowHeadersVisible = false;
            this.dgvStudentMark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudentMark.Size = new System.Drawing.Size(541, 374);
            this.dgvStudentMark.TabIndex = 44;
            this.dgvStudentMark.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvStudentMark_EditingControlShowing);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(163, 466);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(285, 24);
            this.buttonSave.TabIndex = 45;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 502);
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
    }
}