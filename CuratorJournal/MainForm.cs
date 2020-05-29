using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuratorJournal
{
    public partial class MainForm : Form
    {
        private Group group;
        private Curator curator;
        private Journal journal;
        public MainForm()
        {
            InitializeComponent();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            curator = auth.Cur;
            if(curator!=null)
            Fill();


        }
        private void Fill()
        {
            List<Journal> Jo = DBobjects.Entities.Journal.Where(p => p.idCurator == curator.idCurator).ToList();
            List<Group> Gr = new List<Group>();
            foreach (Journal j in Jo)
            {
                Gr.Add(DBobjects.Entities.Group.FirstOrDefault(p => p.idGroup == j.idGroup));
            }
            Gr = Gr.Distinct().ToList();
            dgvGroup.DataSource = Gr;
            dgvGroup.Columns[0].Visible = false;
            dgvGroup.Columns[1].Visible = false;
            dgvGroup.Columns[2].Visible = false;
            dgvGroup.Columns[3].HeaderText = "Номер группы";
            dgvGroup.Columns[4].HeaderText = "Шифр группы";
            dgvGroup.Columns[5].HeaderText = "Специальность";
            dgvGroup.Columns[6].Visible = false;
            dgvGroup.Columns[7].Visible = false;
        }
        private void FillDop(Group group)
        {
            dgvJournal.DataSource = DBobjects.Entities.Journal.Where(p => p.idGroup == group.idGroup).ToList();
            dgvJournal.Columns[0].Visible = false; dgvJournal.Columns[1].Visible = false;
            dgvJournal.Columns[2].HeaderText = "Курс группы"; dgvJournal.Columns[3].HeaderText = "Год ведения журнала";
            dgvJournal.Columns[4].Visible = false; dgvJournal.Columns[5].Visible = false;
            dgvJournal.Columns[7].Visible = false; dgvJournal.Columns[6].HeaderText = "Куратор"; dgvJournal.Columns[8].Visible = false;
            dgvJournal.Columns[9].Visible = false; dgvJournal.Columns[10].Visible = false;
            dgvJournal.Columns[11].Visible = false; dgvJournal.Columns[12].Visible = false;
            dgvJournal.Columns[13].Visible = false; dgvJournal.Columns[14].Visible = false;
            dgvJournal.Columns[15].Visible = false; dgvJournal.Columns[16].Visible = false;
            dgvStudent.DataSource = DBobjects.Entities.Student.Where(p => p.idGroup == group.idGroup).ToList();
            dgvStudent.Columns[0].Visible = false; dgvStudent.Columns[1].Visible = false;
            dgvStudent.Columns[2].HeaderText = "Фамилия"; dgvStudent.Columns[3].HeaderText = "Имя";
            dgvStudent.Columns[4].HeaderText = "Отчество"; dgvStudent.Columns[5].Visible = false;
            dgvStudent.Columns[6].Visible = false; dgvStudent.Columns[7].Visible = false;
            dgvStudent.Columns[8].Visible = false; dgvStudent.Columns[17].Visible = false;
            dgvStudent.Columns[9].Visible = false; dgvStudent.Columns[18].Visible = false;
            dgvStudent.Columns[10].Visible = false; dgvStudent.Columns[19].Visible = false;
            dgvStudent.Columns[11].Visible = false; dgvStudent.Columns[20].Visible = false;
            dgvStudent.Columns[12].Visible = false; dgvStudent.Columns[21].Visible = false;
            dgvStudent.Columns[13].Visible = false; dgvStudent.Columns[22].Visible = false;
            dgvStudent.Columns[14].Visible = false; dgvStudent.Columns[23].Visible = false;
            dgvStudent.Columns[15].Visible = false; dgvStudent.Columns[24].Visible = false;
            dgvStudent.Columns[16].Visible = false; dgvStudent.Columns[25].Visible = false;
            dgvStudent.Columns[26].Visible = false; dgvStudent.Columns[27].Visible = false;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("При изменении данных о пользователе требуется сменить пароль. Продолжить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Registration form = new Registration(curator);
                form.Visible = true;
            }
        }

        private void dgvGroup_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panelStudent.Visible = true;
                panelJournal.Visible = true;
                bEditGrop.Visible = true;
                group = (Group)dgvGroup.Rows[e.RowIndex].DataBoundItem;
                FillDop(group);
            }
        }

        private void bEditGrop_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm(group);
            groupForm.ShowDialog();
            Fill();
        }

        private void bAddGroup_Click(object sender, EventArgs e)
        {
            GroupForm groupForm = new GroupForm(curator.idCurator);
            groupForm.ShowDialog();
            Fill();
        }

        private void bAddJour_Click(object sender, EventArgs e)
        {
            journal = new Journal();
            journal.idCurator = curator.idCurator;
            journal.idGroup = group.idGroup;
            JournalForm journalForm = new JournalForm(journal);
            journalForm.ShowDialog();
            FillDop(group);
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization();
            auth.ShowDialog();
            curator = auth.Cur;
            if (curator != null)
                Fill();           
        }

        private void dgvStudent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Student student = new Student();
                student = (Student)dgvStudent.Rows[e.RowIndex].DataBoundItem;
                StudentForm studentForm = new StudentForm(student);
                studentForm.ShowDialog();
                FillDop(group);
            }
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(group.idGroup);
            studentForm.ShowDialog();
            FillDop(group);
        }

        private void dgvJournal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {                
                journal = (Journal)dgvJournal.Rows[e.RowIndex].DataBoundItem;
                JournalForm journalForm = new JournalForm(journal);
                journalForm.ShowDialog();
                FillDop(group);
            }
        }
    }
}
