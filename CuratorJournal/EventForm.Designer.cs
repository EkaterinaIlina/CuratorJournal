namespace CuratorJournal
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.lTitle = new System.Windows.Forms.Label();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.lTypeEvent = new System.Windows.Forms.Label();
            this.comboBoxTypeEvent = new System.Windows.Forms.ComboBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.lStudent = new System.Windows.Forms.Label();
            this.lNazv = new System.Windows.Forms.Label();
            this.tbNazvanie = new System.Windows.Forms.TextBox();
            this.lDate = new System.Windows.Forms.Label();
            this.dateTimePickerEvent = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanelStatus = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonTradNo = new System.Windows.Forms.RadioButton();
            this.radioButtonTraditional = new System.Windows.Forms.RadioButton();
            this.lStatus = new System.Windows.Forms.Label();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.bAddEvent = new System.Windows.Forms.Button();
            this.panelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tableLayoutPanelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lTitle.Location = new System.Drawing.Point(184, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(278, 28);
            this.lTitle.TabIndex = 42;
            this.lTitle.Text = "Участие в мероприятиях";
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(this.lTypeEvent);
            this.panelEvent.Controls.Add(this.comboBoxTypeEvent);
            this.panelEvent.Controls.Add(this.bDelete);
            this.panelEvent.Controls.Add(this.bSave);
            this.panelEvent.Controls.Add(this.dgvStudent);
            this.panelEvent.Controls.Add(this.lStudent);
            this.panelEvent.Controls.Add(this.lNazv);
            this.panelEvent.Controls.Add(this.tbNazvanie);
            this.panelEvent.Controls.Add(this.lDate);
            this.panelEvent.Controls.Add(this.dateTimePickerEvent);
            this.panelEvent.Controls.Add(this.tableLayoutPanelStatus);
            this.panelEvent.Controls.Add(this.lStatus);
            this.panelEvent.Location = new System.Drawing.Point(45, 211);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(514, 595);
            this.panelEvent.TabIndex = 45;
            this.panelEvent.Visible = false;
            // 
            // lTypeEvent
            // 
            this.lTypeEvent.AutoSize = true;
            this.lTypeEvent.Location = new System.Drawing.Point(5, 52);
            this.lTypeEvent.Name = "lTypeEvent";
            this.lTypeEvent.Size = new System.Drawing.Size(96, 13);
            this.lTypeEvent.TabIndex = 46;
            this.lTypeEvent.Text = "Тип мероприятия";
            // 
            // comboBoxTypeEvent
            // 
            this.comboBoxTypeEvent.FormattingEnabled = true;
            this.comboBoxTypeEvent.Location = new System.Drawing.Point(120, 49);
            this.comboBoxTypeEvent.Name = "comboBoxTypeEvent";
            this.comboBoxTypeEvent.Size = new System.Drawing.Size(256, 21);
            this.comboBoxTypeEvent.TabIndex = 40;
            this.comboBoxTypeEvent.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeEvent_SelectedIndexChanged);
            this.comboBoxTypeEvent.Validated += new System.EventHandler(this.comboBoxTypeEvent_Validated);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(332, 555);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(133, 28);
            this.bDelete.TabIndex = 39;
            this.bDelete.Text = "Удалить";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(48, 555);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(133, 28);
            this.bSave.TabIndex = 38;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(8, 210);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudent.Size = new System.Drawing.Size(479, 339);
            this.dgvStudent.TabIndex = 37;
            // 
            // lStudent
            // 
            this.lStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lStudent.AutoSize = true;
            this.lStudent.Location = new System.Drawing.Point(5, 194);
            this.lStudent.Name = "lStudent";
            this.lStudent.Size = new System.Drawing.Size(96, 13);
            this.lStudent.TabIndex = 36;
            this.lStudent.Text = "Приняли участие:";
            // 
            // lNazv
            // 
            this.lNazv.AutoSize = true;
            this.lNazv.Location = new System.Drawing.Point(3, 116);
            this.lNazv.Name = "lNazv";
            this.lNazv.Size = new System.Drawing.Size(131, 13);
            this.lNazv.TabIndex = 8;
            this.lNazv.Text = "Название мероприятия*";
            // 
            // tbNazvanie
            // 
            this.tbNazvanie.Location = new System.Drawing.Point(6, 132);
            this.tbNazvanie.MaxLength = 100;
            this.tbNazvanie.Multiline = true;
            this.tbNazvanie.Name = "tbNazvanie";
            this.tbNazvanie.Size = new System.Drawing.Size(481, 59);
            this.tbNazvanie.TabIndex = 7;
            this.tbNazvanie.TextChanged += new System.EventHandler(this.tbNazvanie_TextChanged);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Location = new System.Drawing.Point(3, 83);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(96, 13);
            this.lDate.TabIndex = 5;
            this.lDate.Text = "Дата проведения";
            // 
            // dateTimePickerEvent
            // 
            this.dateTimePickerEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEvent.Location = new System.Drawing.Point(120, 77);
            this.dateTimePickerEvent.Name = "dateTimePickerEvent";
            this.dateTimePickerEvent.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerEvent.TabIndex = 4;
            this.dateTimePickerEvent.ValueChanged += new System.EventHandler(this.dateTimePickerEvent_ValueChanged);
            // 
            // tableLayoutPanelStatus
            // 
            this.tableLayoutPanelStatus.ColumnCount = 2;
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStatus.Controls.Add(this.radioButtonTradNo, 1, 0);
            this.tableLayoutPanelStatus.Controls.Add(this.radioButtonTraditional, 0, 0);
            this.tableLayoutPanelStatus.Location = new System.Drawing.Point(120, 3);
            this.tableLayoutPanelStatus.Name = "tableLayoutPanelStatus";
            this.tableLayoutPanelStatus.RowCount = 1;
            this.tableLayoutPanelStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelStatus.Size = new System.Drawing.Size(287, 27);
            this.tableLayoutPanelStatus.TabIndex = 2;
            // 
            // radioButtonTradNo
            // 
            this.radioButtonTradNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTradNo.AutoSize = true;
            this.radioButtonTradNo.Checked = true;
            this.radioButtonTradNo.Location = new System.Drawing.Point(146, 5);
            this.radioButtonTradNo.Name = "radioButtonTradNo";
            this.radioButtonTradNo.Size = new System.Drawing.Size(138, 17);
            this.radioButtonTradNo.TabIndex = 1;
            this.radioButtonTradNo.TabStop = true;
            this.radioButtonTradNo.Text = "Не традиционное";
            this.radioButtonTradNo.UseVisualStyleBackColor = true;
            this.radioButtonTradNo.CheckedChanged += new System.EventHandler(this.radioButtonTradNo_CheckedChanged);
            // 
            // radioButtonTraditional
            // 
            this.radioButtonTraditional.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTraditional.AutoSize = true;
            this.radioButtonTraditional.Location = new System.Drawing.Point(3, 5);
            this.radioButtonTraditional.Name = "radioButtonTraditional";
            this.radioButtonTraditional.Size = new System.Drawing.Size(137, 17);
            this.radioButtonTraditional.TabIndex = 0;
            this.radioButtonTraditional.Text = "Традиционное";
            this.radioButtonTraditional.UseVisualStyleBackColor = true;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(3, 10);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(111, 13);
            this.lStatus.TabIndex = 0;
            this.lStatus.Text = "Статус мероприятия";
            // 
            // dgvEvent
            // 
            this.dgvEvent.AllowUserToAddRows = false;
            this.dgvEvent.AllowUserToDeleteRows = false;
            this.dgvEvent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Location = new System.Drawing.Point(45, 43);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.ReadOnly = true;
            this.dgvEvent.RowHeadersVisible = false;
            this.dgvEvent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEvent.Size = new System.Drawing.Size(461, 150);
            this.dgvEvent.TabIndex = 44;
            this.dgvEvent.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEvent_CellMouseClick);
            // 
            // bAddEvent
            // 
            this.bAddEvent.Image = ((System.Drawing.Image)(resources.GetObject("bAddEvent.Image")));
            this.bAddEvent.Location = new System.Drawing.Point(512, 43);
            this.bAddEvent.Name = "bAddEvent";
            this.bAddEvent.Size = new System.Drawing.Size(43, 23);
            this.bAddEvent.TabIndex = 43;
            this.bAddEvent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bAddEvent.UseVisualStyleBackColor = true;
            this.bAddEvent.Click += new System.EventHandler(this.bAddEvent_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(609, 467);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.bAddEvent);
            this.Controls.Add(this.lTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EventForm";
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tableLayoutPanelStatus.ResumeLayout(false);
            this.tableLayoutPanelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lStudent;
        private System.Windows.Forms.Label lNazv;
        private System.Windows.Forms.TextBox tbNazvanie;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEvent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStatus;
        private System.Windows.Forms.RadioButton radioButtonTradNo;
        private System.Windows.Forms.RadioButton radioButtonTraditional;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.Button bAddEvent;
        private System.Windows.Forms.Label lTypeEvent;
        private System.Windows.Forms.ComboBox comboBoxTypeEvent;
    }
}