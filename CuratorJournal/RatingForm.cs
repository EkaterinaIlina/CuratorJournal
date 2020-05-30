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
    public partial class RatingForm : Form
    {
        Discipline discipline;
        public RatingForm()
        {
            InitializeComponent();
            comboBoxDiscpline.DataSource = DBobjects.Entities.Discipline.ToList();
            comboBoxDiscpline.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxDiscpline.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void SaveDiscipline()
        {
            if (comboBoxDiscpline.Text != "")
            {
                discipline = new Discipline();
                discipline.nameDiscipline = comboBoxDiscpline.Text;
                DBobjects.Entities.Discipline.Add(discipline);
                DBobjects.Entities.SaveChanges();
                comboBoxDiscpline.DataSource = DBobjects.Entities.Discipline.ToList();
            }
        }
        private void comboBoxDiscpline_SelectedIndexChanged(object sender, EventArgs e)
        {
            discipline = DBobjects.Entities.Discipline.FirstOrDefault(p => p.nameDiscipline == comboBoxDiscpline.Text);
        }

        private void buttonFiksDiscipline_Click(object sender, EventArgs e)
        {
            if (comboBoxDiscpline.FindString(comboBoxDiscpline.Text) == -1)
            {
                SaveDiscipline();
            }
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
            List<RatingMark> ratingMarks = DBobjects.Entities.RatingMark.Where(p => p.idJournal == JournalForm.Journal.idJournal).ToList();
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
                if (DBobjects.Entities.RatingMark.Where(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline).Count() > 0)
                {
                    foreach (RatingMark rating in ratingMarks.Where(p=>p.idStudent==st.idStudent).ToList()) {                   
                        dr[rating.Rating.ToString()] = rating.ratingMark1;
                        dr["ID" + rating.Rating.ToString()] = rating.idRating;
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
                    ratingMark.idDiscipline = discipline.idDiscipline;
                    if (DBobjects.Entities.RatingMark.Where(p => p.idRatingMark == ratingMark.idRatingMark).Count() == 0)
                        DBobjects.Entities.RatingMark.Add(ratingMark);
                    DBobjects.Entities.SaveChanges();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveRatingMark();
        }
    }
}
