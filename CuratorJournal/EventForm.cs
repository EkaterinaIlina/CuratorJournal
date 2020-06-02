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
    public partial class EventForm : Form
    {
        Event eventObj;
        TypeOfEvent typeOfEvent;
        AchivementStudent achivementStudent;

        public EventForm()
        {
            InitializeComponent();
            dgvEventFill();
        }
        private void saveTypeEvent()
        {
            if (comboBoxTypeEvent.Text != "")
            {
                typeOfEvent = new TypeOfEvent();
                typeOfEvent.nameTypeEvent = comboBoxTypeEvent.Text;
                DBobjects.Entities.TypeOfEvent.Add(typeOfEvent);
                DBobjects.Entities.SaveChanges();
                comboBoxTypeEvent.DataSource = DBobjects.Entities.TypeOfEvent.ToList();
                comboBoxTypeEvent.SelectedIndex = comboBoxTypeEvent.Items.Count-1;
            }
            else
            MessageBox.Show("Заполните поле тип мероприятия");

        }
        private void dgvEventFill()
        {
            dgvEvent.DataSource = DBobjects.Entities.Event.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            dgvEvent.Columns[0].Visible = false;
            dgvEvent.Columns[1].Visible = false;
            dgvEvent.Columns[2].Visible = false;
            dgvEvent.Columns[3].Visible = false;
            dgvEvent.Columns[4].HeaderText = "Название мероприятия";
            dgvEvent.Columns[5].HeaderText = "Дата мероприятия";
            dgvEvent.Columns[6].Visible = false;
            dgvEvent.Columns[7].Visible = false;
            dgvEvent.Columns[8].HeaderText = "Тип мероприятия";
        }

        private void bAddEvent_Click(object sender, EventArgs e)
        {
            dgvEvent.ClearSelection();
            eventObj = new Event();
            eventObj.dateEvent = DateTime.Now.Date;
            bDelete.Visible = false;
            panelFill();
        }

        private void dgvEvent_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                eventObj = (Event)dgvEvent.Rows[e.RowIndex].DataBoundItem;
                panelFill();
                bDelete.Visible = true;
                comboBoxTypeEvent.SelectedItem = eventObj.TypeOfEvent;
            }
        }
        private void panelFill()
        {
            comboBoxTypeEvent.DataSource = DBobjects.Entities.TypeOfEvent.ToList();
            comboBoxTypeEvent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxTypeEvent.AutoCompleteSource = AutoCompleteSource.ListItems;
            panelEvent.Visible = true;
            dateTimePickerEvent.Value = eventObj.dateEvent.Date;
            tbNazvanie.Text = eventObj.nameEvent;
            if (eventObj.statusEvent == true)
                radioButtonTraditional.Checked = true;
            else
                radioButtonTradNo.Checked = true;
        }
        private void FillStudent()
        {
            DataTable StudentTable = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            DataColumn idAchiv = new DataColumn("idAchiv", Type.GetType("System.Int32"));
            StudentTable.Columns.Add(idStudent);
            StudentTable.Columns.Add(FIOstudent);
            StudentTable.Columns.Add(idAchiv);
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            if (comboBoxTypeEvent.Text == "Научно-исследовательская работа")
            {
                DataColumn fioSupervis = new DataColumn("ФИО руководителя", Type.GetType("System.String"));
                DataColumn subject = new DataColumn("Тема", Type.GetType("System.String"));               
                StudentTable.Columns.Add(fioSupervis);
                StudentTable.Columns.Add(subject);
                foreach (Student st in stud)
                {
                    if (DBobjects.Entities.AchivementStudent.Where(p => p.idStudent == st.idStudent && p.idEvent == eventObj.idEvent).Count() > 0)
                    {
                        AchivementStudent achivementStudent = DBobjects.Entities.AchivementStudent.FirstOrDefault(p => p.idStudent == st.idStudent && p.idEvent == eventObj.idEvent);
                        StudentTable.Rows.Add(st.idStudent, st, achivementStudent.idAchivStud,achivementStudent.fullNameSupervis, achivementStudent.topicWork) ;
                    }
                    else
                        StudentTable.Rows.Add(st.idStudent, st, 0, "","");
                }
            }
            else
            {
                DataColumn Status = new DataColumn("Статус участия", Type.GetType("System.Boolean"));                
                StudentTable.Columns.Add(Status);
                foreach (Student st in stud)
                {
                    if (DBobjects.Entities.AchivementStudent.Where(p => p.idStudent == st.idStudent && p.idEvent == eventObj.idEvent).Count() > 0)
                    {
                        AchivementStudent achivementStudent = DBobjects.Entities.AchivementStudent.FirstOrDefault(p => p.idStudent == st.idStudent && p.idEvent == eventObj.idEvent);
                        StudentTable.Rows.Add(st.idStudent, st, achivementStudent.idAchivStud, true);
                    }
                    else
                        StudentTable.Rows.Add(st.idStudent, st, 0,  false);
                }
            }
            dgvStudent.DataSource = StudentTable;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].ReadOnly = true;
            dgvStudent.Columns[2].Visible = false;
        }

        private void comboBoxTypeEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillStudent();
        }

        private void comboBoxTypeEvent_Validated(object sender, EventArgs e)
        {
            if (comboBoxTypeEvent.FindString(comboBoxTypeEvent.Text) == -1)
            {
                saveTypeEvent();
            }            
        }

        private void tbNazvanie_TextChanged(object sender, EventArgs e)
        {
            eventObj.nameEvent = tbNazvanie.Text;
        }

        private void dateTimePickerEvent_ValueChanged(object sender, EventArgs e)
        {
            eventObj.dateEvent = dateTimePickerEvent.Value.Date;
        }

        private void radioButtonTradNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTradNo.Checked == true)
                eventObj.statusEvent = false;
            else
                eventObj.statusEvent = true;
        }
        private void saveEvent()
        {           
                eventObj.idTypeEvent = DBobjects.Entities.TypeOfEvent.FirstOrDefault(p => p.nameTypeEvent == comboBoxTypeEvent.Text).idTypeEvent;
                eventObj.idJournal = JournalForm.Journal.idJournal;
                if (DBobjects.Entities.Event.Where(p => p.idEvent == eventObj.idEvent).Count() == 0)
                    DBobjects.Entities.Event.Add(eventObj);
                DBobjects.Entities.SaveChanges();
        }
        private void saveStudent()
        {
            foreach (DataGridViewRow dgvr in dgvStudent.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[2].Value) == 0)
                    achivementStudent = new AchivementStudent();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[2].Value);
                    achivementStudent = DBobjects.Entities.AchivementStudent.FirstOrDefault(p => p.idAchivStud == id);
                }
                
                if (comboBoxTypeEvent.Text != "Научно-исследовательская работа")
                {
                    if (Convert.ToBoolean(dgvr.Cells[3].Value) == true)
                    {
                        achivementStudent.idEvent = eventObj.idEvent;
                        achivementStudent.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                        if (DBobjects.Entities.AchivementStudent.Where(p => p.idAchivStud == achivementStudent.idAchivStud).Count() == 0)
                            DBobjects.Entities.AchivementStudent.Add(achivementStudent);
                        DBobjects.Entities.SaveChanges();
                    }
                    else if (achivementStudent.idAchivStud != 0 && Convert.ToBoolean(dgvr.Cells[3].Value) == false)
                        DeleteAchivment();
                }
                else
                {
                    if ((dgvr.Cells[4].Value).ToString() != "" || (dgvr.Cells[3].Value).ToString() != "")
                    {
                        achivementStudent.idEvent = eventObj.idEvent;
                        achivementStudent.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                        achivementStudent.fullNameSupervis = dgvr.Cells[3].Value.ToString();
                        achivementStudent.topicWork = dgvr.Cells[4].Value.ToString();
                        if (DBobjects.Entities.AchivementStudent.Where(p => p.idAchivStud == achivementStudent.idAchivStud).Count() == 0)
                            DBobjects.Entities.AchivementStudent.Add(achivementStudent);
                        DBobjects.Entities.SaveChanges();
                    }
                    else if (achivementStudent.idAchivStud != 0 && Convert.ToString(dgvr.Cells[3].Value) == "" && Convert.ToString(dgvr.Cells[4].Value)=="")
                        DeleteAchivment();
                }

            }
        }
        private void DeleteAchivment()
        {
            DBobjects.Entities.AchivementStudent.Remove(achivementStudent);
            DBobjects.Entities.SaveChanges();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(eventObj.nameEvent))
                MessageBox.Show("Заполните обязательные поля");
            else
            {
                saveEvent();
                dgvEventFill();
                saveStudent();
                MessageBox.Show("Все сохранено");
            }
        }       

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                DeleteEvent();
                panelEvent.Visible = false;
                dgvEventFill();
            }
        }
        private void DeleteEvent()
        {
            if (DBobjects.Entities.Event.Where(p => p.idEvent == eventObj.idEvent).Count() > 0)
                DBobjects.Entities.Event.Remove(eventObj);
            DBobjects.Entities.SaveChanges();
        }
    }
}
