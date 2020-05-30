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
        RatingMark ratingsMarkOne;
        RatingMark ratingsMarkTwo;
        RatingMark ratingsMarkTree;
        RatingMark rezultMark;
        public RatingForm()
        {
            InitializeComponent();
        }
        private void SaveDiscipline()
        {
                discipline = new Discipline();
                discipline.nameDiscipline = comboBoxDiscpline.Text;
                DBobjects.Entities.Discipline.Add(discipline);
                DBobjects.Entities.SaveChanges();
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
        }
         private void FillTable()
        {
            DataTable StudentTable = new DataTable();
            DataColumn idStudent = new DataColumn("id", Type.GetType("System.Int32"));
            DataColumn FIOstudent = new DataColumn("Фамилия Имя", Type.GetType("System.String"));
            DataColumn ratingMarkOne = new DataColumn("Рейтинг-контроль №1", Type.GetType("System.Int32"));
            DataColumn ratingMarkTwo = new DataColumn("Рейтинг-контроль №2", Type.GetType("System.Int32"));
            DataColumn ratingMarkFree = new DataColumn("Рейтинг-контроль №3", Type.GetType("System.Int32"));
            DataColumn rezMark = new DataColumn("Рейтинг-контроль №3", Type.GetType("System.Int32"));
           // DataColumn idRatingMark = new DataColumn("idRatingMark", Type.GetType("System.Int32"));
            StudentTable.Columns.Add(idStudent);
            StudentTable.Columns.Add(FIOstudent);
            StudentTable.Columns.Add(ratingMarkOne);
            StudentTable.Columns.Add(ratingMarkTwo);
            StudentTable.Columns.Add(ratingMarkFree);
            StudentTable.Columns.Add(rezMark);
            //StudentTable.Columns.Add(idRatingMark);
            List<Student> stud = DBobjects.Entities.Student.Where(p => p.idGroup == JournalForm.Journal.idGroup).ToList();
            foreach (Student st in stud)
            {
                if (DBobjects.Entities.RatingMark.Where(p => p.idStudent == st.idStudent && p.idDiscipline==discipline.idDiscipline ).Count() > 0)
                {
                    ratingsMarkOne = DBobjects.Entities.RatingMark.FirstOrDefault(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idRating == 1);
                    ratingsMarkTwo = DBobjects.Entities.RatingMark.FirstOrDefault(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idRating == 2);
                    ratingsMarkTree = DBobjects.Entities.RatingMark.FirstOrDefault(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idRating == 3);
                    rezultMark = DBobjects.Entities.RatingMark.FirstOrDefault(p => p.idStudent == st.idStudent && p.idDiscipline == discipline.idDiscipline && p.idRating == 4);
                    StudentTable.Rows.Add(st.idStudent, st, ratingsMarkOne.ratingMark1, ratingsMarkTwo.ratingMark1, ratingsMarkTree.ratingMark1,rezultMark.ratingMark1);
                }
                else
                    StudentTable.Rows.Add(st.idStudent, st, 0,0,0,0);
            }
            dgvStudentMark.DataSource = StudentTable;
           // dgvStudent.Columns[0].Visible = false;
            //dgvStudent.Columns[1].ReadOnly = true;
            //dgvStudent.Columns[3].Visible = false;
        }
    }
}
