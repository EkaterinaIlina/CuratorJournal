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
    public partial class ConsolidatedStatementForm : Form
    {
        int idGroup;
        Discipline discipline;
        FinalGrade finalGrade;
        ListMarkStud listMarkStud;
        public ConsolidatedStatementForm(Group group)
        {
            idGroup = group.idGroup;
            InitializeComponent();
            fillDiscKontrol();
        }
        private void fillDiscKontrol()
        {
            List<ListMarkStud> listMarkStuds = DBobjects.Entities.ListMarkStud.Where(p => p.Student.idGroup == idGroup).ToList();
            List<FinalGrade> finalGrades = new List<FinalGrade>();
            foreach (ListMarkStud markStud in listMarkStuds)
            {
                finalGrades.Add(DBobjects.Entities.FinalGrade.FirstOrDefault(p => p.idFinalGrade == markStud.idFinalGrade));
            }
            finalGrades = finalGrades.Distinct().ToList();
            dataGridViewDiscControl.DataSource = finalGrades;
            dataGridViewDiscControl.Columns[0].Visible = false;
            dataGridViewDiscControl.Columns[1].Visible = false;
            dataGridViewDiscControl.Columns[2].Visible = false;
            dataGridViewDiscControl.Columns[3].Visible = false;
            dataGridViewDiscControl.Columns[4].HeaderText = "Дисциплина";
            dataGridViewDiscControl.Columns[5].HeaderText = "Форма контроля";
            dataGridViewDiscControl.Columns[6].Visible = false;
            dataGridViewDiscControl.Columns[7].HeaderText = "Семестр";

        }
        private void fillCombobox()
        {
            List<Discipline> disciplines = new List<Discipline>();
            foreach (Discipline discipline in DBobjects.Entities.Discipline.ToList())
            {
                if (DBobjects.Entities.FinalGrade.Where(p => p.idDiscipline == discipline.idDiscipline).Count() > 0)
                {
                    disciplines.Add(discipline);
                }
            }
            comboBoxDiscipline.DataSource = disciplines;
            comboBoxDiscipline.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDiscipline.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxFormControl.DataSource = DBobjects.Entities.FormOfControl.ToList();
            comboBoxFormControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxFormControl.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxSemestr.DataSource = DBobjects.Entities.Semestr.ToList();
            comboBoxSemestr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxSemestr.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void SaveDiscipline()
        {
            if (comboBoxDiscipline.Text != "")
            {
                if (DBobjects.Entities.Discipline.Where(p => p.nameDiscipline == comboBoxDiscipline.Text).Count() == 0)
                {
                    discipline = new Discipline();
                    discipline.nameDiscipline = comboBoxDiscipline.Text;
                    DBobjects.Entities.Discipline.Add(discipline);
                    DBobjects.Entities.SaveChanges();
                }
                else
                    discipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscipline.Text);
                FinalGrade finalGrade = new FinalGrade();
                finalGrade.idDiscipline = discipline.idDiscipline;
                finalGrade.idFormContr = DBobjects.Entities.FormOfControl.First().idFormContr;
                finalGrade.idSemestr = DBobjects.Entities.Semestr.First().idSemestr;
                DBobjects.Entities.FinalGrade.Add(finalGrade);
                DBobjects.Entities.SaveChanges();
                comboBoxDiscipline.SelectedItem = discipline.nameDiscipline;
                fillCombobox();
                comboBoxDiscipline.SelectedIndex = comboBoxDiscipline.Items.Count - 1;
            }
        }
        private void comboBoxDiscipline_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxDiscipline.FindString(comboBoxDiscipline.Text) == -1)
            {
                SaveDiscipline();
            }
        }

        private void buttonlistMark_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscipline.Text != "" || comboBoxFormControl.Text != "" || comboBoxSemestr.Text != "")
            {
                finalGrade.idDiscipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscipline.Text).idDiscipline;
                finalGrade.idFormContr = DBobjects.Entities.FormOfControl.FirstOrDefault(p => p.nameFormContr == comboBoxFormControl.Text).idFormContr;
                finalGrade.idSemestr = DBobjects.Entities.Semestr.FirstOrDefault(p => p.semestrName == comboBoxSemestr.Text).idSemestr;
                if (DBobjects.Entities.FinalGrade.Where(p => p.idFinalGrade == finalGrade.idFinalGrade).Count() == 0)
                {
                    DBobjects.Entities.FinalGrade.Add(finalGrade);
                }
                DBobjects.Entities.SaveChanges();
                filltable();
                dataGridViewMark.Visible = true;
                buttonSaveALl.Visible = true;
            }
            else
                MessageBox.Show("Заполните поля информации о контроле");
        }
        private void filltable()
        {
            DataTable StudentMark = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            DataColumn idMark = new DataColumn("idMark", Type.GetType("System.Int32"));
            DataColumn Mark = new DataColumn("Оценка", Type.GetType("System.String"));
            StudentMark.Columns.Add(idStudent);
            StudentMark.Columns.Add(FIOstudent);
            StudentMark.Columns.Add(idMark);
            StudentMark.Columns.Add(Mark);
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == idGroup).ToList();
            foreach (Student st in stud)
            {                
                    if (DBobjects.Entities.ListMarkStud.Where(p => p.idStudent == st.idStudent && p.idFinalGrade == finalGrade.idFinalGrade ).Count() > 0)
                    {
                    ListMarkStud listMarkStud = DBobjects.Entities.ListMarkStud.FirstOrDefault(p => p.idStudent == st.idStudent && p.idFinalGrade == finalGrade.idFinalGrade);
                    StudentMark.Rows.Add(st.idStudent, st, listMarkStud.idListMarkStudent, listMarkStud.grade);
                    }
                    else
                    StudentMark.Rows.Add(st.idStudent, st, 0, "");
            }
            dataGridViewMark.DataSource = StudentMark;
            dataGridViewMark.Columns[0].Visible = false;
            dataGridViewMark.Columns[2].Visible = false;
            dataGridViewMark.Columns[1].ReadOnly = true;
        }

        private void dataGridViewDiscControl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                finalGrade = (FinalGrade)dataGridViewDiscControl.Rows[e.RowIndex].DataBoundItem;
                fillCombobox();
                comboBoxDiscipline.SelectedItem = finalGrade.Discipline;
                comboBoxFormControl.SelectedItem = finalGrade.FormOfControl;
                comboBoxSemestr.SelectedItem = finalGrade.Semestr;
                filltable();
                panelFinalControl.Visible = true;
                dataGridViewMark.Visible = true;
                buttonSaveALl.Visible = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            finalGrade = new FinalGrade();
            fillCombobox();
            panelFinalControl.Visible = true;
            comboBoxDiscipline.SelectedIndex = -1;
            comboBoxFormControl.SelectedIndex = -1;
            comboBoxSemestr.SelectedIndex = -1;
            filltable();
        }
        private void saveMark()
        {
            foreach (DataGridViewRow dgvr in dataGridViewMark.Rows)
            {
                    if (Convert.ToInt32(dgvr.Cells[2].Value) == 0)
                        listMarkStud = new ListMarkStud();
                    else
                    {
                        int id = Convert.ToInt32(dgvr.Cells[2].Value);
                    listMarkStud = DBobjects.Entities.ListMarkStud.FirstOrDefault(p => p.idListMarkStudent == id);
                    }
                    listMarkStud.grade = dgvr.Cells[3].Value.ToString();
                    listMarkStud.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                    listMarkStud.idFinalGrade = finalGrade.idFinalGrade;
                        if (DBobjects.Entities.ListMarkStud.Where(p => p.idListMarkStudent == listMarkStud.idListMarkStudent).Count() == 0)
                            DBobjects.Entities.ListMarkStud.Add(listMarkStud);
                        DBobjects.Entities.SaveChanges();
                fillDiscKontrol();               
            }
        }

        private void buttonSaveALl_Click(object sender, EventArgs e)
        {
            saveMark();
        }
    }
}
