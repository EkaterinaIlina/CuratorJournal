using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CuratorJournal
{
    public partial class StudentInformationForm : Form
    {
        JournalStudent journalStudent;
        ContextMenu contextMenuStatus;

        public StudentInformationForm()
        {
            InitializeComponent();
            if (DBobjects.Entities.JournalStudent.Where(p => p.idJournal == JournalForm.Journal.idJournal).Count() == 0)
            {
                AddTable();
            }
            else
                FillTable();
            contextMenuStatus = new ContextMenu();
            foreach (var var1 in DBobjects.Entities.StatusStudent.ToList())
            {
                MenuItem menuItem = new MenuItem();
                menuItem.Name = var1.idStatusSt.ToString();
                menuItem.Text = var1.nameSatusSt;
                contextMenuStatus.MenuItems.Add(menuItem);
                menuItem.Click += new System.EventHandler(menuItem_Click);
            }

        }
        private DataTable StudentTable()
        {
            DataTable StudentTable = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn idJouralStudent = new DataColumn("idJouralStudent", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            DataColumn OneSemestr = new DataColumn("1-ый семестр", Type.GetType("System.Boolean"));
            DataColumn TwoSemestr = new DataColumn("2-ой семестр", Type.GetType("System.Boolean"));
            DataColumn StatusStudent = new DataColumn("idStatus", Type.GetType("System.Int32"));
            StudentTable.Columns.Add(idStudent);
            StudentTable.Columns.Add(idJouralStudent);
            StudentTable.Columns.Add(FIOstudent);
            StudentTable.Columns.Add(OneSemestr);
            StudentTable.Columns.Add(TwoSemestr);
            StudentTable.Columns.Add(StatusStudent);
            return StudentTable;
        }
        private void FillTable()
        {
            DataTable StudentJournalTable = StudentTable();
            List<JournalStudent> stud = DBobjects.Entities.JournalStudent.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            foreach (JournalStudent st in stud)
            {
                StudentJournalTable.Rows.Add(st.idStudent, st.idJournalStudent, st.Student.surnameStudent + " " + st.Student.nameStudent, st.stipendSemOne, st.stipendSemTwo, st.idStatusSt);
            }
            dgvStudent.DataSource = StudentJournalTable;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].Visible = false;
            dgvStudent.Columns[2].ReadOnly = true;
            dgvStudent.Columns[5].Visible = false;

        }
        private void AddTable()
        {
            DataTable StudentJournalTable = StudentTable();
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            foreach (Student st in stud)
            {
                StudentJournalTable.Rows.Add(st.idStudent, 0, st, false, false, 4);
            }
            dgvStudent.DataSource = StudentJournalTable;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].Visible = false;
            dgvStudent.Columns[2].ReadOnly = true;
            dgvStudent.Columns[5].Visible = false;
        }

        private void checkBoxSemestrTwo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSemestrTwo.Checked == true)
            {
                foreach (DataGridViewRow dgvr in dgvStudent.Rows)
                {
                    dgvr.Cells["2-ой семестр"].Value = true;
                }
            }
            else if (checkBoxSemestrTwo.Checked == false)
            {
                foreach (DataGridViewRow dgvr in dgvStudent.Rows)
                {
                    dgvr.Cells["2-ой семестр"].Value = false;
                }
            }
        }

        private void SaveStudentJournal()
        {
            foreach (DataGridViewRow dgvr in dgvStudent.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[0].Value) == 0)
                    journalStudent = new JournalStudent();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[1].Value);
                    journalStudent = DBobjects.Entities.JournalStudent.FirstOrDefault(p => p.idJournalStudent == id);
                }
                journalStudent.idJournal = JournalForm.Journal.idJournal;
                journalStudent.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                if (dgvr.Cells[3].Value.ToString() == "")
                    dgvr.Cells[3].Value = false;
                if (dgvr.Cells[4].Value.ToString() == "")
                    dgvr.Cells[4].Value = false;
                journalStudent.stipendSemOne = Convert.ToBoolean(dgvr.Cells[3].Value);
                journalStudent.stipendSemTwo = Convert.ToBoolean(dgvr.Cells[4].Value);
                journalStudent.idStatusSt = Convert.ToInt32(dgvr.Cells[5].Value);
                if (DBobjects.Entities.JournalStudent.Where(p => p.idJournalStudent == journalStudent.idJournalStudent).Count() == 0)
                {
                    DBobjects.Entities.JournalStudent.Add(journalStudent);
                }
                DBobjects.Entities.SaveChanges();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveStudentJournal();
            MessageBox.Show("Сохранено");
        }

        private void checkBoxSemestrOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSemestrOne.Checked == true)
            {
                foreach (DataGridViewRow dgvr in dgvStudent.Rows)
                {
                    dgvr.Cells["1-ый семестр"].Value = true;
                }
            }
            else if (checkBoxSemestrOne.Checked == false)
            {
                foreach (DataGridViewRow dgvr in dgvStudent.Rows)
                {
                    dgvr.Cells["1-ый семестр"].Value = false;
                }
            }
        }

        private void dgvStudent_MouseUp(object sender, MouseEventArgs e)
        {
            dgvStudent.ClearSelection();
            DataGridView.HitTestInfo hitTestInfo;                            
                hitTestInfo = dgvStudent.HitTest(e.X, e.Y);
                dgvStudent.Rows[hitTestInfo.RowIndex].Selected = true;
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                        contextMenuStatus.Show(dgvStudent, e.Location);                           
                }
        }

        private void menuItem_Click(object sender, System.EventArgs e)
        {
            int id = dgvStudent.SelectedRows[0].Index;
            var itemRez = (MenuItem)sender;
            if (itemRez.Name == "1" && DBobjects.Entities.JournalStudent.Where(p => p.idJournal == JournalForm.Journal.idJournal && p.idStatusSt == 1).Count() == 1)
                MessageBox.Show("Староста может быть только один");
            else
               dgvStudent.Rows[id].Cells["idStatus"].Value = itemRez.Name;
            switch (Convert.ToInt32(dgvStudent.Rows[id].Cells["idStatus"].Value))
            {
                case 1:
                    dgvStudent.Rows[id].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Bold);
                    break;
                case 2:
                    dgvStudent.Rows[id].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Underline);
                    break;
                case 3:
                    dgvStudent.Rows[id].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Italic);
                    break;
                case 4:
                    dgvStudent.Rows[id].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Regular);
                    break;
                default:
                    dgvStudent.Rows[id].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Regular);
                    break;
            }
        }


        private void dgvStudent_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewCell cell = dgvStudent.Rows[e.RowIndex].Cells[e.ColumnIndex];
                int index = Convert.ToInt32(dgvStudent.Rows[e.RowIndex].Cells["idStatus"].Value);
                cell.ToolTipText = DBobjects.Entities.StatusStudent.FirstOrDefault(p => p.idStatusSt == index).nameSatusSt;
            }
                
        }


        private void dgvStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch (Convert.ToInt32(dgvStudent.Rows[e.RowIndex].Cells["idStatus"].Value))
            {
                case 1:
                    dgvStudent.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Bold);
                    break;
                case 2:
                    dgvStudent.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Underline);
                    break;
                case 3:
                    dgvStudent.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Italic);
                    break;
                case 4:
                    dgvStudent.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Regular);
                    break;
                default:
                    dgvStudent.Rows[e.RowIndex].Cells[2].Style.Font = new Font(dgvStudent.DefaultCellStyle.Font, FontStyle.Regular);
                    break;
            }
        }
    }
        
    
}