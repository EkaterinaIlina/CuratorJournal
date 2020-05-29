namespace CuratorJournal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bEditGrop = new System.Windows.Forms.Button();
            this.lGroup = new System.Windows.Forms.Label();
            this.bAddGroup = new System.Windows.Forms.Button();
            this.dgvGroup = new System.Windows.Forms.DataGridView();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.bAddStudent = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lSpisok = new System.Windows.Forms.Label();
            this.panelJournal = new System.Windows.Forms.Panel();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.bAddJour = new System.Windows.Forms.Button();
            this.lJournal = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).BeginInit();
            this.panelStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.panelJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bEditGrop);
            this.panel1.Controls.Add(this.lGroup);
            this.panel1.Controls.Add(this.bAddGroup);
            this.panel1.Controls.Add(this.dgvGroup);
            this.panel1.Location = new System.Drawing.Point(1, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 206);
            this.panel1.TabIndex = 0;
            // 
            // bEditGrop
            // 
            this.bEditGrop.Image = ((System.Drawing.Image)(resources.GetObject("bEditGrop.Image")));
            this.bEditGrop.Location = new System.Drawing.Point(213, 12);
            this.bEditGrop.Name = "bEditGrop";
            this.bEditGrop.Size = new System.Drawing.Size(43, 23);
            this.bEditGrop.TabIndex = 6;
            this.bEditGrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bEditGrop.UseVisualStyleBackColor = true;
            this.bEditGrop.Visible = false;
            this.bEditGrop.Click += new System.EventHandler(this.bEditGrop_Click);
            // 
            // lGroup
            // 
            this.lGroup.AutoSize = true;
            this.lGroup.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lGroup.Location = new System.Drawing.Point(14, 12);
            this.lGroup.Name = "lGroup";
            this.lGroup.Size = new System.Drawing.Size(144, 21);
            this.lGroup.TabIndex = 5;
            this.lGroup.Text = "Выберите группу";
            // 
            // bAddGroup
            // 
            this.bAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("bAddGroup.Image")));
            this.bAddGroup.Location = new System.Drawing.Point(164, 12);
            this.bAddGroup.Name = "bAddGroup";
            this.bAddGroup.Size = new System.Drawing.Size(43, 23);
            this.bAddGroup.TabIndex = 4;
            this.bAddGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddGroup.UseVisualStyleBackColor = true;
            this.bAddGroup.Click += new System.EventHandler(this.bAddGroup_Click);
            // 
            // dgvGroup
            // 
            this.dgvGroup.AllowUserToAddRows = false;
            this.dgvGroup.AllowUserToDeleteRows = false;
            this.dgvGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroup.Location = new System.Drawing.Point(8, 41);
            this.dgvGroup.Name = "dgvGroup";
            this.dgvGroup.ReadOnly = true;
            this.dgvGroup.RowHeadersVisible = false;
            this.dgvGroup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvGroup.Size = new System.Drawing.Size(327, 150);
            this.dgvGroup.TabIndex = 3;
            this.dgvGroup.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGroup_CellMouseClick);
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.bAddStudent);
            this.panelStudent.Controls.Add(this.dgvStudent);
            this.panelStudent.Controls.Add(this.lSpisok);
            this.panelStudent.Location = new System.Drawing.Point(342, 23);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(399, 441);
            this.panelStudent.TabIndex = 1;
            this.panelStudent.Visible = false;
            // 
            // bAddStudent
            // 
            this.bAddStudent.Location = new System.Drawing.Point(223, 413);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(150, 23);
            this.bAddStudent.TabIndex = 31;
            this.bAddStudent.Text = "Добавить студента";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(56, 35);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudent.Size = new System.Drawing.Size(317, 372);
            this.dgvStudent.TabIndex = 30;
            this.dgvStudent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudent_CellMouseClick);
            // 
            // lSpisok
            // 
            this.lSpisok.AutoSize = true;
            this.lSpisok.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSpisok.Location = new System.Drawing.Point(102, 4);
            this.lSpisok.Name = "lSpisok";
            this.lSpisok.Size = new System.Drawing.Size(202, 28);
            this.lSpisok.TabIndex = 26;
            this.lSpisok.Text = "Список студентов";
            // 
            // panelJournal
            // 
            this.panelJournal.Controls.Add(this.dgvJournal);
            this.panelJournal.Controls.Add(this.bAddJour);
            this.panelJournal.Controls.Add(this.lJournal);
            this.panelJournal.Location = new System.Drawing.Point(1, 235);
            this.panelJournal.Name = "panelJournal";
            this.panelJournal.Size = new System.Drawing.Size(344, 229);
            this.panelJournal.TabIndex = 2;
            this.panelJournal.Visible = false;
            // 
            // dgvJournal
            // 
            this.dgvJournal.AllowUserToAddRows = false;
            this.dgvJournal.AllowUserToDeleteRows = false;
            this.dgvJournal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Location = new System.Drawing.Point(9, 43);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.ReadOnly = true;
            this.dgvJournal.RowHeadersVisible = false;
            this.dgvJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvJournal.Size = new System.Drawing.Size(317, 150);
            this.dgvJournal.TabIndex = 26;
            this.dgvJournal.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvJournal_CellMouseClick);
            // 
            // bAddJour
            // 
            this.bAddJour.Image = global::CuratorJournal.Properties.Resources.add_button;
            this.bAddJour.Location = new System.Drawing.Point(164, 12);
            this.bAddJour.Name = "bAddJour";
            this.bAddJour.Size = new System.Drawing.Size(43, 23);
            this.bAddJour.TabIndex = 25;
            this.bAddJour.UseVisualStyleBackColor = true;
            this.bAddJour.Click += new System.EventHandler(this.bAddJour_Click);
            // 
            // lJournal
            // 
            this.lJournal.AutoSize = true;
            this.lJournal.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lJournal.Location = new System.Drawing.Point(9, 14);
            this.lJournal.Name = "lJournal";
            this.lJournal.Size = new System.Drawing.Size(148, 21);
            this.lJournal.TabIndex = 24;
            this.lJournal.Text = "Выберите журнал";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.SettingsToolStripMenuItem});
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(79, 20);
            this.ToolStripMenuItemSettings.Text = "Настройки";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.SettingsToolStripMenuItem.Text = "Настройки пользователя";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 476);
            this.Controls.Add(this.panelJournal);
            this.Controls.Add(this.panelStudent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroup)).EndInit();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.panelJournal.ResumeLayout(false);
            this.panelJournal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lGroup;
        private System.Windows.Forms.Button bAddGroup;
        private System.Windows.Forms.DataGridView dgvGroup;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lSpisok;
        private System.Windows.Forms.Panel panelJournal;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.Button bAddJour;
        private System.Windows.Forms.Label lJournal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.Button bEditGrop;
    }
}