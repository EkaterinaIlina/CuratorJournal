﻿using System;
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
    public partial class RatingForm : Form
    {
        Discipline discipline;
        public RatingForm()
        {
            InitializeComponent();
            fillDiscipline();
        }
        private void fillDiscipline()
        {
            List<Discipline> disciplines = new List<Discipline>();
            foreach (Discipline discipline in DBobjects.Entities.Discipline.ToList())
            {
                if (DBobjects.Entities.RatingMark.Where(p => p.idDiscipline == discipline.idDiscipline && p.idJournal == JournalForm.Journal.idJournal).Count() > 0)
                {
                    disciplines.Add(discipline);
                }
            }
            comboBoxDiscpline.DataSource = disciplines;
            comboBoxDiscpline.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDiscpline.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void SaveDiscipline()
        {
            if (comboBoxDiscpline.Text != "")
            {
                if (DBobjects.Entities.Discipline.Where(p => p.nameDiscipline == comboBoxDiscpline.Text).Count() == 0)
                {
                    discipline = new Discipline();
                    discipline.nameDiscipline = comboBoxDiscpline.Text;
                    DBobjects.Entities.Discipline.Add(discipline);
                    DBobjects.Entities.SaveChanges();
                }              
               else
                    discipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscpline.Text);
                RatingMark ratingMark = new RatingMark();
                ratingMark.idDiscipline = discipline.idDiscipline;
                ratingMark.idJournal = JournalForm.Journal.idJournal;
                ratingMark.idRating = DBobjects.Entities.Rating.First().idRating;
                ratingMark.idStudent = DBobjects.Entities.Student.FirstOrDefault(p => p.idGroup == JournalForm.Journal.idGroup).idStudent;
                ratingMark.ratingMark1 = 0;
                DBobjects.Entities.RatingMark.Add(ratingMark);
                DBobjects.Entities.SaveChanges();
                comboBoxDiscpline.SelectedItem =discipline.nameDiscipline;
                fillDiscipline();
                comboBoxDiscpline.SelectedIndex = comboBoxDiscpline.Items.Count - 1;
            }
        }
        private void comboBoxDiscpline_SelectedIndexChanged(object sender, EventArgs e)
        {
            discipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscpline.Text);
            FillTable();
        }

        private void FillTable()
        {
            DataTable StudentTable = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            StudentTable.Columns.Add(idStudent);
            StudentTable.Columns.Add(FIOstudent);
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            foreach (Rating rating in DBobjects.Entities.Rating.ToList())
            {
                StudentTable.Columns.Add(rating.nameRating);
                StudentTable.Columns.Add("ID" + rating.nameRating);
            }
            foreach (Student st in stud)
            {
                DataRow dr = StudentTable.NewRow();
                dr["id"] = st.idStudent;
                dr["Фамилия Имя"] = st;               
                foreach (Rating rating in DBobjects.Entities.Rating.ToList())
                    {
                    if (DBobjects.Entities.RatingMark.Where(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idJournal == JournalForm.Journal.idJournal&& p.idRating==rating.idRating).Count() > 0)
                    {
                        dr[rating.ToString()] = DBobjects.Entities.RatingMark.FirstOrDefault(p=> p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idRating ==rating.idRating && p.idJournal == JournalForm.Journal.idJournal).ratingMark1;
                        dr["ID" + rating.ToString()] = DBobjects.Entities.RatingMark.FirstOrDefault(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idRating == rating.idRating && p.idJournal == JournalForm.Journal.idJournal).idRatingMark ;
                    }                
                    else
                    {
                        dr[rating.ToString()] = 0;
                        dr["ID" + rating.ToString()] = 0;
                    }                  
                }
                StudentTable.Rows.Add(dr);
            }
            dgvStudentMark.DataSource = StudentTable;
            dgvStudentMark.Columns[0].Visible = false;
            dgvStudentMark.Columns[1].ReadOnly = true;
            foreach (Rating rating in DBobjects.Entities.Rating.ToList())
            {
                dgvStudentMark.Columns["ID" + rating.nameRating].Visible = false;
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
                e.Handled = true;
        }

        private void dgvStudentMark_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox textBox = (TextBox)e.Control;
            if ((dgvStudentMark.CurrentCell.ColumnIndex == 2 || dgvStudentMark.CurrentCell.ColumnIndex == 5 && dgvStudentMark.CurrentCell.ColumnIndex == 3 || dgvStudentMark.CurrentCell.ColumnIndex == 4))
            {
                textBox.KeyPress += new KeyPressEventHandler(textBox_KeyPress);
            }
        }
        private void SaveRatingMark()
        {
            foreach (DataGridViewRow dgvr in dgvStudentMark.Rows)
            {
                RatingMark ratingMark;
                foreach (Rating rating in DBobjects.Entities.Rating.ToList())
                {
                    if (Convert.ToInt32(dgvr.Cells["ID" + rating.nameRating].Value) == 0)
                        ratingMark = new RatingMark();
                    else
                    {
                        int id = Convert.ToInt32(dgvr.Cells["ID" + rating.nameRating].Value);
                        ratingMark = DBobjects.Entities.RatingMark.FirstOrDefault(p => p.idRatingMark == id);
                    }
                    ratingMark.idRatingMark = Convert.ToInt32(dgvr.Cells["ID" + rating.nameRating].Value);
                    ratingMark.idRating = rating.idRating;
                    ratingMark.idJournal = JournalForm.Journal.idJournal;
                    ratingMark.idStudent = Convert.ToInt32(dgvr.Cells[0].Value);
                    ratingMark.ratingMark1 = Convert.ToInt32(dgvr.Cells[rating.nameRating].Value);
                    if (comboBoxDiscpline.Text != "")
                    {
                        ratingMark.idDiscipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscpline.Text).idDiscipline;
                        if (DBobjects.Entities.RatingMark.Where(p => p.idRatingMark == ratingMark.idRatingMark).Count() == 0)
                            DBobjects.Entities.RatingMark.Add(ratingMark);
                        DBobjects.Entities.SaveChanges();
                    }
                    else
                    MessageBox.Show("Заполните поле дисциплина");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveRatingMark();
            MessageBox.Show("Сохранено");
        }

        private void comboBoxDiscpline_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxDiscpline.FindString(comboBoxDiscpline.Text) == -1)
            {
                SaveDiscipline();
            }
        }

    }
}
