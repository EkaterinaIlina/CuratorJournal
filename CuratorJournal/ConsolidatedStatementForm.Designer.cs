namespace CuratorJournal
{
    partial class ConsolidatedStatementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidatedStatementForm));
            this.comboBoxDiscipline = new System.Windows.Forms.ComboBox();
            this.comboBoxFormControl = new System.Windows.Forms.ComboBox();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelFormofControl = new System.Windows.Forms.Label();
            this.labelSemestr = new System.Windows.Forms.Label();
            this.dataGridViewMark = new System.Windows.Forms.DataGridView();
            this.buttonlistMark = new System.Windows.Forms.Button();
            this.dataGridViewDiscControl = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSaveALl = new System.Windows.Forms.Button();
            this.panelFinalControl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscControl)).BeginInit();
            this.panelFinalControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDiscipline
            // 
            this.comboBoxDiscipline.FormattingEnabled = true;
            this.comboBoxDiscipline.Location = new System.Drawing.Point(116, 11);
            this.comboBoxDiscipline.Name = "comboBoxDiscipline";
            this.comboBoxDiscipline.Size = new System.Drawing.Size(276, 21);
            this.comboBoxDiscipline.TabIndex = 0;
            this.comboBoxDiscipline.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxDiscipline_Validating);
            // 
            // comboBoxFormControl
            // 
            this.comboBoxFormControl.FormattingEnabled = true;
            this.comboBoxFormControl.Location = new System.Drawing.Point(116, 54);
            this.comboBoxFormControl.Name = "comboBoxFormControl";
            this.comboBoxFormControl.Size = new System.Drawing.Size(276, 21);
            this.comboBoxFormControl.TabIndex = 1;
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Location = new System.Drawing.Point(116, 100);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(276, 21);
            this.comboBoxSemestr.TabIndex = 2;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(1, 14);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(70, 13);
            this.labelDiscipline.TabIndex = 3;
            this.labelDiscipline.Text = "Дисциплина";
            // 
            // labelFormofControl
            // 
            this.labelFormofControl.AutoSize = true;
            this.labelFormofControl.Location = new System.Drawing.Point(1, 57);
            this.labelFormofControl.Name = "labelFormofControl";
            this.labelFormofControl.Size = new System.Drawing.Size(94, 13);
            this.labelFormofControl.TabIndex = 4;
            this.labelFormofControl.Text = "Форма контроля";
            // 
            // labelSemestr
            // 
            this.labelSemestr.AutoSize = true;
            this.labelSemestr.Location = new System.Drawing.Point(1, 103);
            this.labelSemestr.Name = "labelSemestr";
            this.labelSemestr.Size = new System.Drawing.Size(51, 13);
            this.labelSemestr.TabIndex = 5;
            this.labelSemestr.Text = "Семестр";
            // 
            // dataGridViewMark
            // 
            this.dataGridViewMark.AllowUserToAddRows = false;
            this.dataGridViewMark.AllowUserToDeleteRows = false;
            this.dataGridViewMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMark.Location = new System.Drawing.Point(568, 15);
            this.dataGridViewMark.Name = "dataGridViewMark";
            this.dataGridViewMark.Size = new System.Drawing.Size(377, 408);
            this.dataGridViewMark.TabIndex = 6;
            this.dataGridViewMark.Visible = false;
            // 
            // buttonlistMark
            // 
            this.buttonlistMark.Location = new System.Drawing.Point(187, 146);
            this.buttonlistMark.Name = "buttonlistMark";
            this.buttonlistMark.Size = new System.Drawing.Size(206, 23);
            this.buttonlistMark.TabIndex = 7;
            this.buttonlistMark.Text = "Перейти к выставлению оценок";
            this.buttonlistMark.UseVisualStyleBackColor = true;
            this.buttonlistMark.Click += new System.EventHandler(this.buttonlistMark_Click);
            // 
            // dataGridViewDiscControl
            // 
            this.dataGridViewDiscControl.AllowUserToAddRows = false;
            this.dataGridViewDiscControl.AllowUserToDeleteRows = false;
            this.dataGridViewDiscControl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiscControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscControl.Location = new System.Drawing.Point(81, 15);
            this.dataGridViewDiscControl.Name = "dataGridViewDiscControl";
            this.dataGridViewDiscControl.ReadOnly = true;
            this.dataGridViewDiscControl.Size = new System.Drawing.Size(445, 239);
            this.dataGridViewDiscControl.TabIndex = 8;
            this.dataGridViewDiscControl.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewDiscControl_CellMouseClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::CuratorJournal.Properties.Resources.add_button;
            this.buttonAdd.Location = new System.Drawing.Point(13, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(62, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSaveALl
            // 
            this.buttonSaveALl.Location = new System.Drawing.Point(739, 440);
            this.buttonSaveALl.Name = "buttonSaveALl";
            this.buttonSaveALl.Size = new System.Drawing.Size(206, 23);
            this.buttonSaveALl.TabIndex = 10;
            this.buttonSaveALl.Text = "Сохранить";
            this.buttonSaveALl.UseVisualStyleBackColor = true;
            this.buttonSaveALl.Visible = false;
            this.buttonSaveALl.Click += new System.EventHandler(this.buttonSaveALl_Click);
            // 
            // panelFinalControl
            // 
            this.panelFinalControl.Controls.Add(this.labelDiscipline);
            this.panelFinalControl.Controls.Add(this.comboBoxDiscipline);
            this.panelFinalControl.Controls.Add(this.comboBoxFormControl);
            this.panelFinalControl.Controls.Add(this.comboBoxSemestr);
            this.panelFinalControl.Controls.Add(this.buttonlistMark);
            this.panelFinalControl.Controls.Add(this.labelFormofControl);
            this.panelFinalControl.Controls.Add(this.labelSemestr);
            this.panelFinalControl.Location = new System.Drawing.Point(93, 260);
            this.panelFinalControl.Name = "panelFinalControl";
            this.panelFinalControl.Size = new System.Drawing.Size(419, 191);
            this.panelFinalControl.TabIndex = 11;
            this.panelFinalControl.Visible = false;
            // 
            // ConsolidatedStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 465);
            this.Controls.Add(this.panelFinalControl);
            this.Controls.Add(this.buttonSaveALl);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewDiscControl);
            this.Controls.Add(this.dataGridViewMark);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsolidatedStatementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscControl)).EndInit();
            this.panelFinalControl.ResumeLayout(false);
            this.panelFinalControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiscipline;
        private System.Windows.Forms.ComboBox comboBoxFormControl;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelFormofControl;
        private System.Windows.Forms.Label labelSemestr;
        private System.Windows.Forms.DataGridView dataGridViewMark;
        private System.Windows.Forms.Button buttonlistMark;
        private System.Windows.Forms.DataGridView dataGridViewDiscControl;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSaveALl;
        private System.Windows.Forms.Panel panelFinalControl;
    }
}