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
    public partial class AttendanceCheckForm : Form
    {
        Attendance attendance;
        LackAttendance lackAttendance;
        Discipline discipline;
        public AttendanceCheckForm()
        {
            InitializeComponent();
            dgvAttendanceFill();

        }
        private void dgvAttendanceFill()
        {
            dgvAttendance.DataSource = DBobjects.Entities.Attendance.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
            dgvAttendance.Columns[0].Visible = false;
            dgvAttendance.Columns[1].Visible = false;
            dgvAttendance.Columns[2].HeaderText = "Дата проведения";
            dgvAttendance.Columns[5].HeaderText = "ФИО преподавателя";
            dgvAttendance.Columns[4].Visible = false;
            dgvAttendance.Columns[3].Visible = false;
            dgvAttendance.Columns[6].HeaderText = "Дисциплина";
            dgvAttendance.Columns[7].Visible = false;
            dgvAttendance.Columns[8].HeaderText = "Статус занятия";
            dgvAttendance.Columns[9].Visible = false;
        }
        private void FillcomboBoxDiscpline()
        {
            comboBoxDiscpline.DataSource = DBobjects.Entities.Discipline.ToList();
            comboBoxDiscpline.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDiscpline.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxOccup.DataSource = DBobjects.Entities.OccupationStatus.ToList();
            comboBoxOccup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxOccup.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void FillPanel()
        {
            panelAttendance.Visible = true;
            dateTimePickerAttendance.Value = attendance.dateAttendance;
            comboBoxDiscpline.SelectedItem = attendance.Discipline;
            comboBoxOccup.SelectedItem = attendance.OccupationStatus;
            textBoxFullNamePrep.Text = attendance.fullNameTeach;

        }
        private void bAddAttendance_Click(object sender, EventArgs e)
        {
            attendance = new Attendance();
            panelAttendance.Visible = true;
            FillcomboBoxDiscpline();
            dgvAttendance.ClearSelection();
            attendance.dateAttendance = DateTime.Now.Date;
            attendance.fullNameTeach = "";
            dateTimePickerAttendance.Value = attendance.dateAttendance;
            attendance.idJournal = JournalForm.Journal.idJournal;
            textBoxFullNamePrep.Text = "";
            FillStudent();
            bDelete.Visible = false;
        }

        private void dgvAttendance_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                attendance = (Attendance)dgvAttendance.Rows[e.RowIndex].DataBoundItem;
                FillcomboBoxDiscpline();
                panelAttendance.Visible = true;
                FillPanel();
                FillStudent();
                bDelete.Visible = true;
            }
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
                if (DBobjects.Entities.LackAttendance.Where(p => p.idStudent == st.idStudent && p.idAttendance == attendance.idAttendance).Count() > 0)
                    StudentTable.Rows.Add(st.idStudent, st, true, DBobjects.Entities.LackAttendance.FirstOrDefault(p => p.idStudent == st.idStudent && p.idAttendance == attendance.idAttendance).idLackAttendance);
                else
                    StudentTable.Rows.Add(st.idStudent, st, false, 0);
            }
            dgvStudent.DataSource = StudentTable;
            dgvStudent.Columns[0].Visible = false;
            dgvStudent.Columns[1].ReadOnly = true;
            dgvStudent.Columns[3].Visible = false;
        }

        private void bSaveStudent_Click(object sender, EventArgs e)
        {
            SaveAttendance();
            dgvAttendanceFill();
            SaveStudent();
            MessageBox.Show("Все сохранено");
        }
        private void SaveAttendance()
        {
            try
            {
                attendance.idDiscipline = discipline.idDiscipline;
                if (IsFieldsEmpteAttendance())
                    throw new Exception("Заполните обязательные поля");
                if (DBobjects.Entities.Attendance.Where(p => p.idAttendance == attendance.idAttendance).Count() == 0)
                    DBobjects.Entities.Attendance.Add(attendance);
                DBobjects.Entities.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SaveStudent()
        {
            foreach (DataGridViewRow dgvr in dgvStudent.Rows)
            {
                if (Convert.ToInt32(dgvr.Cells[3].Value) == 0)
                    lackAttendance = new LackAttendance();
                else
                {
                    int id = Convert.ToInt32(dgvr.Cells[3].Value);
                    lackAttendance = DBobjects.Entities.LackAttendance.FirstOrDefault(p => p.idLackAttendance == id);
                }
                if (Convert.ToBoolean(dgvr.Cells[2].Value) == true)
                {
                    lackAttendance.idAttendance = attendance.idAttendance;
                    lackAttendance.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                    if (DBobjects.Entities.LackAttendance.Where(p => p.idLackAttendance == lackAttendance.idLackAttendance).Count() == 0)
                        DBobjects.Entities.LackAttendance.Add(lackAttendance);
                    DBobjects.Entities.SaveChanges();
                }
                else if (lackAttendance.idLackAttendance != 0 && Convert.ToBoolean(dgvr.Cells[2].Value) == false)
                    DeleteLackAttendance();
            }
        }
        private void DeleteLackAttendance()
        {
            DBobjects.Entities.LackAttendance.Remove(lackAttendance);
            DBobjects.Entities.SaveChanges();
        }
        private bool IsFieldsEmpteAttendance()
        {
            if (attendance.fullNameTeach == "" || attendance.idDiscipline == 0
                )
            {
                return true;
            }
            return false;
        }

        private void comboBoxDiscpline_SelectedIndexChanged(object sender, EventArgs e)
        {
            discipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscpline.Text);
        }

        private void comboBoxOccup_SelectedIndexChanged(object sender, EventArgs e)
        {
            attendance.idOccupStat = DBobjects.Entities.OccupationStatus.FirstOrDefault(p => p.nameOccupStat == comboBoxOccup.Text).idOccupStat;
        }
        private void DeleteAttendance()
        {
            if (DBobjects.Entities.Attendance.Where(p => p.idAttendance == attendance.idAttendance).Count() > 0)
                DBobjects.Entities.Attendance.Remove(attendance);
            DBobjects.Entities.SaveChanges();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            DeleteAttendance();
            panelAttendance.Visible = false;
            dgvAttendanceFill();
        }

        private void textBoxFullNamePrep_TextChanged(object sender, EventArgs e)
        {
            attendance.fullNameTeach = textBoxFullNamePrep.Text;
        }

        private void dateTimePickerAttendance_ValueChanged(object sender, EventArgs e)
        {
            attendance.dateAttendance = dateTimePickerAttendance.Value.Date;
        }
        private void saveDiscipline()
        {
            if (comboBoxDiscpline.FindString(comboBoxDiscpline.Text) == -1)
            {
                discipline = new Discipline();
                discipline.nameDiscipline = comboBoxDiscpline.Text;
                DBobjects.Entities.Discipline.Add(discipline);
                DBobjects.Entities.SaveChanges();
                comboBoxDiscpline.DataSource = DBobjects.Entities.Discipline.ToList();
                comboBoxDiscpline.SelectedIndex = comboBoxDiscpline.Items.Count - 1;
            }
            else
                MessageBox.Show("Заполните поле тип мероприятия");
        
    }
        
        private void comboBoxDiscpline_Validated(object sender, EventArgs e)
        {
            if (comboBoxDiscpline.FindString(comboBoxDiscpline.Text) == -1)
            {
                saveDiscipline();
            }
        }
    }
}
