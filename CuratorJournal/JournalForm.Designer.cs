namespace CuratorJournal
{
    partial class JournalForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Основная информация о журнале");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Сведения о студентах");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Динамика основных показателей группы за учебный год");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("График учебного процесса");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Собрания");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Проверка посещаемости занятий студентами");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Индивидуальные беседы со студентами");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Работа с родителями студентов");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Обсуждение проступках на заседаниии кафедры");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Воспитательные воздействия куратора", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Посещение студенческого общежития");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Достижения студентов");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Текущий контроль успеваемости");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.Name = "MainInformation";
            treeNode1.Text = "Основная информация о журнале";
            treeNode2.Name = "StudentInformation";
            treeNode2.Text = "Сведения о студентах";
            treeNode3.Name = "DinamicGroup";
            treeNode3.Text = "Динамика основных показателей группы за учебный год";
            treeNode4.Name = "GraficProcess";
            treeNode4.Text = "График учебного процесса";
            treeNode5.Name = "MeetingJournal";
            treeNode5.Text = "Собрания";
            treeNode6.Name = "Attendance";
            treeNode6.Text = "Проверка посещаемости занятий студентами";
            treeNode7.Name = "PrivateTalcParents";
            treeNode7.Text = "Индивидуальные беседы со студентами";
            treeNode8.Name = "TalckParents";
            treeNode8.Text = "Работа с родителями студентов";
            treeNode9.Name = "Offence";
            treeNode9.Text = "Обсуждение проступках на заседаниии кафедры";
            treeNode10.Name = "EducationActivities";
            treeNode10.Text = "Воспитательные воздействия куратора";
            treeNode11.Name = "VisitHostel";
            treeNode11.Text = "Посещение студенческого общежития";
            treeNode12.Name = "StudentAchivment";
            treeNode12.Text = "Достижения студентов";
            treeNode13.Name = "PerformeMonitor";
            treeNode13.Text = "Текущий контроль успеваемости";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            this.treeViewMenu.Size = new System.Drawing.Size(343, 563);
            this.treeViewMenu.TabIndex = 1;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(953, 563);
            this.Controls.Add(this.treeViewMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "JournalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewMenu;
    }
}