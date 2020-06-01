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
    public partial class EducationalWorkForm : Form
    {
        PrivateTalk privateTalk;
        PrivTalkStudent privTalkStudent;
        public EducationalWorkForm()
        {           
            InitializeComponent();
            FillTalkStudent();
        }
        private void FillTalkStudent()
        {
            dgvTopicTalc.DataSource = DBobjects.Entities.PrivateTalk.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            dgvTopicTalc.Columns[0].Visible = false;
            dgvTopicTalc.Columns[1].Visible = false;
            dgvTopicTalc.Columns[2].HeaderText = "Дата проведения";
            dgvTopicTalc.Columns[3].HeaderText = "Тема беседы";
            dgvTopicTalc.Columns[4].Visible = false;
            dgvTopicTalc.Columns[5].Visible = false;
        }

        private void FillStudent()
        {
            DataTable StudentTable = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            DataColumn status = new DataColumn("Статус", Type.GetType("System.Boolean"));
            DataColumn idPrivTalkStud = new DataColumn("idPrivTalkStud", Type.GetType("System.Int32"));
            StudentTable.Columns.Add(idStudent);
            StudentTable.Columns.Add(FIOstudent);
            StudentTable.Columns.Add(status);
            StudentTable.Columns.Add(idPrivTalkStud);
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            foreach (Student st in stud)
            {
                if (DBobjects.Entities.PrivTalkStudent.Where(p => p.idStudent == st.idStudent && p.idPrTalk == privateTalk.idPrTalk).Count() > 0)
                    StudentTable.Rows.Add(st.idStudent, st, true, DBobjects.Entities.PrivTalkStudent.FirstOrDefault(p => p.idStudent == st.idStudent && p.idPrTalk == privateTalk.idPrTalk).idPrivTalkStudent);
                else
                    StudentTable.Rows.Add(st.idStudent, st, false, 0);
            }
            dgvStudent.DataSource = StudentTable;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].ReadOnly = true;
            dgvStudent.Columns[3].Visible = false;
        }

        private void dgvTopicTalc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                privateTalk = (PrivateTalk)dgvTopicTalc.Rows[e.RowIndex].DataBoundItem;
                panelFill();
                buttonDelete.Visible = true;
                FillTalkStudent();
            }
        }
        private void panelFill()
        {            
            panelPrivTalc.Visible = true;
            dateTimePickerTalkStudent.Value = privateTalk.datePrTalk.Date;
            textBoxTopic.Text = privateTalk.topicPrTalk;
            FillStudent();
        }
        private void bAddPrivTalc_Click(object sender, EventArgs e)
        {
            dgvTopicTalc.ClearSelection();
            privateTalk = new PrivateTalk();
            privateTalk.datePrTalk = DateTime.Now.Date;
            privateTalk.idJournal = JournalForm.Journal.idJournal;
            buttonDelete.Visible = false;
            panelFill();
            FillTalkStudent();
        }
        private void SaveStudent()
        {
            foreach (DataGridViewRow dgvr in dgvStudent.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[3].Value) == 0)
                    privTalkStudent = new PrivTalkStudent();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[3].Value);
                    privTalkStudent = DBobjects.Entities.PrivTalkStudent.FirstOrDefault(p => p.idPrivTalkStudent == id);
                }
                if (Convert.ToBoolean(dgvr.Cells[2].Value) == true)
                {
                    privTalkStudent.idPrTalk = privateTalk.idPrTalk;
                    privTalkStudent.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                    if (DBobjects.Entities.PrivTalkStudent.Where(p => p.idPrivTalkStudent == privTalkStudent.idPrivTalkStudent).Count() == 0)
                        DBobjects.Entities.PrivTalkStudent.Add(privTalkStudent);
                    DBobjects.Entities.SaveChanges();
                }
                else if (privTalkStudent.idPrivTalkStudent != 0 && Convert.ToBoolean(dgvr.Cells[2].Value) == false)
                    DeletePrivTalkStudent();
            }
        }
        private void DeletePrivTalkStudent()
        {
            DBobjects.Entities.PrivTalkStudent.Remove(privTalkStudent);
            DBobjects.Entities.SaveChanges();
        }
        private void DeletePrivTalk()
        {
            if (DBobjects.Entities.PrivateTalk.Where(p => p.idPrTalk == privateTalk.idPrTalk).Count() > 0)
                DBobjects.Entities.PrivateTalk.Remove(privateTalk);
            DBobjects.Entities.SaveChanges();
        }
        private void SavePrivTalk()
        {
            try
            {                
                if (IsFieldsEmptePrivTalk())
                    throw new Exception("Заполните обязательные поля");
                if (DBobjects.Entities.PrivateTalk.Where(p => p.idPrTalk == privateTalk.idPrTalk).Count() == 0)
                    DBobjects.Entities.PrivateTalk.Add(privateTalk);
                DBobjects.Entities.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool IsFieldsEmptePrivTalk()
        {
            if (privateTalk.topicPrTalk == "" )
            {
                return true;
            }
            return false;
        }

        private void dateTimePickerTalkStudent_ValueChanged(object sender, EventArgs e)
        {
            privateTalk.datePrTalk = dateTimePickerTalkStudent.Value.Date;
        }

        private void textBoxTopic_TextChanged(object sender, EventArgs e)
        {
            privateTalk.topicPrTalk = textBoxTopic.Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SavePrivTalk();
            FillTalkStudent();
            SaveStudent();
            MessageBox.Show("Сохранено");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletePrivTalk();
            panelPrivTalc.Visible = false;
            FillTalkStudent(); 
        }
    }
}
