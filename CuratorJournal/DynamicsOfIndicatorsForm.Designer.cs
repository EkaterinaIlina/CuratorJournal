namespace CuratorJournal
{
    partial class DynamicsOfIndicatorsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DynamicsOfIndicatorsForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.dgvDynamics = new System.Windows.Forms.DataGridView();
            this.bSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDynamics)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(72, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(450, 28);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Динамика основных показателей группы";
            // 
            // dgvDynamics
            // 
            this.dgvDynamics.AllowUserToAddRows = false;
            this.dgvDynamics.AllowUserToDeleteRows = false;
            this.dgvDynamics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDynamics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDynamics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDynamics.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDynamics.Location = new System.Drawing.Point(12, 51);
            this.dgvDynamics.MultiSelect = false;
            this.dgvDynamics.Name = "dgvDynamics";
            this.dgvDynamics.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDynamics.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDynamics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDynamics.Size = new System.Drawing.Size(557, 236);
            this.dgvDynamics.TabIndex = 32;
            this.dgvDynamics.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDynamics_EditingControlShowing);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(405, 328);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(164, 23);
            this.bSave.TabIndex = 33;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // DynamicsOfIndicatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 463);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.dgvDynamics);
            this.Controls.Add(this.lTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DynamicsOfIndicatorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDynamics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.DataGridView dgvDynamics;
        private System.Windows.Forms.Button bSave;
    }
}