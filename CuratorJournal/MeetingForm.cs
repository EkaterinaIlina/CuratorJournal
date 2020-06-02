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
    public partial class MeetingForm : Form
    {
        Meeting meeting;
        LackMeeting lackMeeting;
        public MeetingForm()
        {
            InitializeComponent();
            dgvMeetingFill();
        }
        private void dgvMeetingFill()
        {
            dgvMeeting.DataSource = DBobjects.Entities.Meeting.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            dgvMeeting.Columns[0].Visible = false;
            dgvMeeting.Columns[1].Visible = false;
            dgvMeeting.Columns[2].HeaderText = "Дата проведения";
            dgvMeeting.Columns[5].HeaderText = "Тема собрания";
            dgvMeeting.Columns[4].Visible = false;
            dgvMeeting.Columns[3].Visible = false;
            dgvMeeting.Columns[6].Visible = false;
            dgvMeeting.Columns[7].Visible = false;
            dgvMeeting.Columns[8].Visible = false;
        }
        private void dgvMeeting_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                panelMeeting.Visible = true;
                meeting = (Meeting)dgvMeeting.Rows[e.RowIndex].DataBoundItem;
                if (meeting.statusMeeting == true)
                    radioButtonPlan.Checked = true;
                else
                    radioButtonPlanNo.Checked = true;
                if (meeting.typeMeeting == true)
                    radioButtonHourInf.Checked = true;
                else
                    radioButtonHourEduc.Checked = true;
                dateTimePickerMeeting.Value = meeting.dateMeeting.Date;
                tbDecision.Text = meeting.decisionMeeting;
                tbQuestion.Text = meeting.questionMeeting;
                FillStudent();
                bDelete.Visible = true;
            }
        }

        private void bAddMeeting_Click(object sender, EventArgs e)
        {
            dgvMeeting.ClearSelection();
            panelMeeting.Visible = true;
            meeting = new Meeting();
            meeting.dateMeeting = DateTime.Now.Date;
            dateTimePickerMeeting.Value = DateTime.Now.Date;
            radioButtonPlanNo.Checked = true;
            radioButtonHourEduc.Checked = true;
            meeting.idJournal = JournalForm.Journal.idJournal;
            tbQuestion.Text = "";
            tbDecision.Text = "";
            FillStudent();
            bDelete.Visible = false;
        }

 
        private void SaveMeeting()
        {
                if (DBobjects.Entities.Meeting.Where(p => p.idMeeting == meeting.idMeeting).Count() == 0)
                    DBobjects.Entities.Meeting.Add(meeting);
                DBobjects.Entities.SaveChanges();           
        }
        private void tbDecision_TextChanged(object sender, EventArgs e)
        {
            meeting.decisionMeeting = tbDecision.Text;
        }

        private void radioButtonPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlan.Checked == true)
                meeting.statusMeeting = true;
            else
                meeting.statusMeeting = false;
        }

        private void radioButtonHourInf_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHourInf.Checked == true)
                meeting.typeMeeting = true;
            else
                meeting.statusMeeting = false;
        }

        private void dateTimePickerMeeting_ValueChanged(object sender, EventArgs e)
        {
            meeting.dateMeeting = dateTimePickerMeeting.Value.Date;
        }

        private void tbQuestion_TextChanged(object sender, EventArgs e)
        {
            meeting.questionMeeting = tbQuestion.Text;
        }
        private void FillStudent()
        {
            DataTable StudentTable = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            DataColumn Ots = new DataColumn("Статус отсутствия", Type.GetType("System.Boolean"));
            DataColumn PropuskId = new DataColumn("PropuskId", Type.GetType("System.Int32"));
            StudentTable.Columns.Add(idStudent);
            StudentTable.Columns.Add(FIOstudent);
            StudentTable.Columns.Add(Ots);
            StudentTable.Columns.Add(PropuskId);
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            foreach (Student st in stud)
            {
                if (DBobjects.Entities.LackMeeting.Where(p => p.idStudent == st.idStudent && p.idMeeting == meeting.idMeeting).Count() > 0)
                    StudentTable.Rows.Add(st.idStudent, st, true, DBobjects.Entities.LackMeeting.FirstOrDefault(p => p.idStudent == st.idStudent && p.idMeeting == meeting.idMeeting).idLackMeeting);
                else
                    StudentTable.Rows.Add(st.idStudent, st, false, 0);
            }
            dgvStudent.DataSource = StudentTable;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].ReadOnly = true;
            dgvStudent.Columns[3].Visible = false;
        }


        private void SaveStudent()
        {            
                foreach (DataGridViewRow dgvr in dgvStudent.Rows)
                {
                    if (Convert.ToInt32(dgvr.Cells[3].Value) == 0)
                        lackMeeting = new LackMeeting();
                    else
                    {
                        int id = Convert.ToInt32(dgvr.Cells[3].Value);
                        lackMeeting = DBobjects.Entities.LackMeeting.FirstOrDefault(p => p.idLackMeeting == id);
                    }
                    if (Convert.ToBoolean(dgvr.Cells[2].Value) == true)
                    {
                        lackMeeting.idMeeting = meeting.idMeeting;
                        lackMeeting.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                        if (DBobjects.Entities.LackMeeting.Where(p => p.idLackMeeting == lackMeeting.idLackMeeting).Count() == 0)
                            DBobjects.Entities.LackMeeting.Add(lackMeeting);
                        DBobjects.Entities.SaveChanges();
                    }
                    else if (lackMeeting.idLackMeeting != 0 && Convert.ToBoolean(dgvr.Cells[2].Value) == false)
                        DeleteLackMeeting();
                }
            
        }
       
        private void DeleteLackMeeting()
        {
            DBobjects.Entities.LackMeeting.Remove(lackMeeting);
            DBobjects.Entities.SaveChanges();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DeleteMeetig();
                panelMeeting.Visible = false;
                dgvMeetingFill();
            }
        }
        private void DeleteMeetig()
        {
            if (DBobjects.Entities.Meeting.Where(p => p.idMeeting == meeting.idMeeting).Count() > 0)
                DBobjects.Entities.Meeting.Remove(meeting);
            DBobjects.Entities.SaveChanges();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(meeting.questionMeeting) || String.IsNullOrWhiteSpace(meeting.decisionMeeting ))
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                SaveMeeting();
                dgvMeetingFill();
                SaveStudent();
                MessageBox.Show("Все сохранено");
            }
        }
      
    }
}
